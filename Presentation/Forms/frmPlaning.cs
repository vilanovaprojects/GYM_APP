using Domain.Clases;
using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Presentation.Forms
{
    public partial class frmPlaning : Form
    {
        public frmPlaning()
        {
            InitializeComponent();
            ReiniciarLabelErrorConexion();
            CargarNombres();
        }

        private void CargarNombres()
        {
            cbNombres.Items.Clear();
            try
            {
                var clase = new ClassPlaning();
                List<string> nombres = clase.ListaDeUsuarios();

                foreach (string nombre in nombres)
                {
                    cbNombres.Items.Add(nombre);
                }
            }
            catch
            {
                timerParpadeo.Start();
            }

            

        }
        private void CargarDatos(string nombre)
        {
            try
            {
                var clase = new ClassPlaning();
                List<Planing2> planing = clase.DescargarPlan(nombre);


                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add();
                dataGridView1.Rows.Add();
                dataGridView1.Rows.Add();

                foreach (var registro in planing)
                {
                    // Buscar el índice de la columna correspondiente a registro.Tipo
                    int columnIndex = dataGridView1.Columns.Cast<DataGridViewColumn>()
                                        .Select((col, index) => new { Column = col, Index = index })
                                        .FirstOrDefault(x => x.Column.HeaderText == registro.Dia)?.Index ?? -1;

                    if (columnIndex != -1)
                    {

                        int fila = 0;

                        do
                        {
                            if (fila < dataGridView1.Rows.Count - 1)
                            {

                                if (dataGridView1.Rows[fila].Cells[columnIndex].Value == null ||
                                    string.IsNullOrWhiteSpace(dataGridView1.Rows[fila].Cells[columnIndex].Value.ToString()))
                                {
                                    // La celda está vacía
                                    DataGridViewImageCell celdaImagen = new DataGridViewImageCell();


                                    int nuevoAncho = 100;
                                    int nuevoAlto = 100;
                                    System.Drawing.Image imagenOriginal = clsImagen.ByteToImage(registro.Imagen);
                                    System.Drawing.Image imagenRedimensionada = new Bitmap(imagenOriginal, nuevoAncho, nuevoAlto);

                                    celdaImagen.Value = imagenRedimensionada;


                                    dataGridView1.Rows[fila].Height = nuevoAlto;
                                    dataGridView1.Rows[fila].Cells[columnIndex] = celdaImagen;

                                    dataGridView1.Rows[fila + 1].Cells[columnIndex].Value = registro.Ejercicio;
                                    dataGridView1.Rows[fila + 1].Cells[columnIndex].ReadOnly = true;

                                    dataGridView1.Rows[fila + 2].Cells[columnIndex].Value = registro.Repes;
                                    dataGridView1.Rows[fila + 2].Cells[columnIndex].ReadOnly = true;



                                    break;
                                }
                                else
                                {
                                    // La celda tiene un valor
                                    fila = fila + 3;
                                }
                            }
                            else    //si está fuera de rango aumenta 
                            {
                                dataGridView1.Rows.Add();
                                dataGridView1.Rows.Add();
                                dataGridView1.Rows.Add();
                            }

                        } while (true);

                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error. El tipo de dato no se encuentra en la columna");
                    }

                }
            }
            catch
            {
                timerParpadeo.Start();
            }
            

        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    PdfWriter writer = new PdfWriter(fs);
                    PdfDocument pdf = new PdfDocument(writer);
                    Document doc = new Document(pdf);

                    Paragraph header = new Paragraph("Entrenamiento semanal")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(20);


                    Table table = new Table(dataGridView1.Columns.Count);
                    table.SetMarginLeft(100);

                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        Cell cell = new Cell();
                        cell.Add(new Paragraph(column.HeaderText));
                        table.AddCell(cell);
                    }

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null)
                            {
                                if (cell.Value is System.Drawing.Image)
                                {
                                    // Si es una imagen, agrega la imagen a la celda en el PDF
                                    System.Drawing.Image image = (System.Drawing.Image)cell.Value;
                                    ImageData imageData = ImageDataFactory.Create(clsImagen.ImageToByte(image));

                                    iText.Layout.Element.Image pdfImage = new iText.Layout.Element.Image(imageData);
                                    pdfImage.ScaleAbsolute(image.Width * 0.7f, image.Height * 0.7f); // Reducción del 50%

                                    table.AddCell(new Cell().Add(pdfImage));
                                }
                                else
                                {
                                    Cell pdfCell = new Cell().Add(new Paragraph(cell.Value.ToString()));
                                    pdfCell.SetFontSize(8); // Cambiado el tamaño de la fuente
                                    pdfCell.SetHeight(11); // Cambiada la altura de la celda 
                                    table.AddCell(pdfCell);

                                }
                            }
                            else
                            {
                                table.AddCell("");
                            }

                        }
                    }

                    doc.Add(header);
                    doc.Add(table);
                    doc.Close();
                }

                MessageBox.Show("PDF generado y guardado correctamente.");
            }
        }

        private void ReiniciarLabelErrorConexion()
        {
            lblSinConexion.Visible = false;
            pbSinConexion.Visible = false;
        }

        private void timerParpadeo_Tick(object sender, EventArgs e)
        {
            lblSinConexion.Visible = !lblSinConexion.Visible;
            pbSinConexion.Visible = !pbSinConexion.Visible;
        }

        private void cbNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = cbNombres.SelectedItem != null ? cbNombres.SelectedItem.ToString() : null;

            if (nombre != string.Empty && nombre != null && nombre != "-1")
            {
                CargarDatos(nombre);
            }
        }
    }
}
