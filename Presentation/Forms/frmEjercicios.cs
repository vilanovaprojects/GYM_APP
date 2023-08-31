using Domain;
using Domain.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class frmEjercicios : Form
    {
        private MainModel model;
        public frmEjercicios()
        {
            InitializeComponent();
            Restablecer();
            CargarDataGridView();
            CargarNombres();
        }


        private void CargarDataGridView()
        {
            try
            {
                model = new MainModel();

                List<Registros> registros = model.ObtenerRegistros();
                List<string> columnas = model.ObtenerColumnas();


                if (registros.Count > 0)
                {
                    foreach (string columna in columnas)
                    {

                        DataGridViewColumn nuevaColumna = dataGridView1.Columns[dataGridView1.Columns.Add(columna, columna)];
                        nuevaColumna.SortMode = DataGridViewColumnSortMode.NotSortable;
                        nuevaColumna.Width = 140;

                    }
                    // Limpiar el DataGridView
                    dataGridView1.Rows.Clear();

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows.Add();


                    //Llenar el DataGridView
                    foreach (var registro in registros)
                    {
                        // Buscar el índice de la columna correspondiente a registro.Tipo
                        int columnIndex = dataGridView1.Columns.Cast<DataGridViewColumn>()
                                            .Select((col, index) => new { Column = col, Index = index })
                                            .FirstOrDefault(x => x.Column.HeaderText == registro.Tipo)?.Index ?? -1;

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

                                        DataGridViewImageCell celdaImagen = new DataGridViewImageCell();

                                        int nuevoAncho = 100;
                                        int nuevoAlto = 100;
                                        Image imagenOriginal = clsImagen.ByteToImage(registro.Imagen);
                                        Image imagenRedimensionada = new Bitmap(imagenOriginal, nuevoAncho, nuevoAlto);

                                        celdaImagen.Value = imagenRedimensionada;

                                        dataGridView1.Rows[fila].Height = nuevoAlto;
                                        dataGridView1.Rows[fila].Cells[columnIndex] = celdaImagen;

                                        dataGridView1.Rows[fila + 1].Cells[columnIndex].Value = registro.Nombre;
                                        dataGridView1.Rows[fila + 1].Cells[columnIndex].ReadOnly = true;

                                        //// Crear una nueva celda ComboBox
                                        //DataGridViewComboBoxCell celdaComboBox = new DataGridViewComboBoxCell();
                                        //// Agregar elementos al ComboBox
                                        //celdaComboBox.Items.Add("3 x 10 rep");
                                        //celdaComboBox.Items.Add("4 x 10 rep");
                                        //celdaComboBox.Value = "3 x 10 rep";
                                        //dataGridView1.Rows[fila + 2].Cells[columnIndex] = celdaComboBox;

                                        DataGridViewTextBoxCell celdarepes = new DataGridViewTextBoxCell();

                                        celdarepes.Value = "3 x 10 rep";

                                        dataGridView1.Rows[fila + 2].Cells[columnIndex] = celdarepes;


                                        break;
                                    }
                                    else
                                    {
                                        fila = fila + 3;
                                    }
                                }
                                else    //si está fuera de rango aumenta 3 filas
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

            }
            catch
            {
                timerParpadeo.Start();
            }
            
        }

        private void btnLunes_Click(object sender, EventArgs e)
        {
            if (btnLunes.Text == "Confirmar")
            {
                btnLunes.Text = "Lunes";
                btnLunes.BackColor = Color.Silver;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.White;
                    }
                }

                informacion.Text = "";
                btnMartes.Enabled = true;
                btnMiercoles.Enabled = true;
                btnJueves.Enabled = true;
                btnViernes.Enabled = true;
                btnCrarPrograma.Enabled = true;
            }
            else
            {
                model.BorrarPlanLunes();
                btnLunes.Text = "Confirmar";
                btnLunes.BackColor = Color.White;
                informacion.Text = "Selecciona los ejercicios para Lunes:";
                btnMartes.Enabled = false;
                btnMiercoles.Enabled = false;
                btnJueves.Enabled = false;
                btnViernes.Enabled = false;
                btnCrarPrograma.Enabled = false;
            }
        }

        private void btnMartes_Click(object sender, EventArgs e)
        {
            if (btnMartes.Text == "Confirmar")
            {
                btnMartes.Text = "Martes";
                btnMartes.BackColor = Color.Silver;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.White;
                    }
                }
                informacion.Text = "";
                btnLunes.Enabled = true;
                btnMiercoles.Enabled = true;
                btnJueves.Enabled = true;
                btnViernes.Enabled = true;
                btnCrarPrograma.Enabled = true;
            }
            else
            {
                model.BorrarPlanMartes();
                btnMartes.Text = "Confirmar";
                btnMartes.BackColor = Color.White;
                informacion.Text = "Selecciona los ejercicios para Martes:";
                btnLunes.Enabled = false;
                btnMiercoles.Enabled = false;
                btnJueves.Enabled = false;
                btnViernes.Enabled = false;
                btnCrarPrograma.Enabled = false;

            }

        }

        private void btnMiercoles_Click(object sender, EventArgs e)
        {
            if (btnMiercoles.Text == "Confirmar")
            {
                btnMiercoles.Text = "Miercoles";
                btnMiercoles.BackColor = Color.Silver;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.White;
                    }
                }
                informacion.Text = "";
                btnMartes.Enabled = true;
                btnLunes.Enabled = true;
                btnJueves.Enabled = true;
                btnViernes.Enabled = true;
                btnCrarPrograma.Enabled = true;
            }
            else
            {
                model.BorrarPlanMiercoles();
                btnMiercoles.Text = "Confirmar";
                btnMiercoles.BackColor = Color.White;
                informacion.Text = "Selecciona los ejercicios para Miercoles:";
                btnMartes.Enabled = false;
                btnLunes.Enabled = false;
                btnJueves.Enabled = false;
                btnViernes.Enabled = false;
                btnCrarPrograma.Enabled = false;

            }
        }

        private void btnJueves_Click(object sender, EventArgs e)
        {
            if (btnJueves.Text == "Confirmar")
            {
                btnJueves.Text = "Jueves";
                btnJueves.BackColor = Color.Silver;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.White;
                    }
                }
                informacion.Text = "";
                btnMartes.Enabled = true;
                btnMiercoles.Enabled = true;
                btnLunes.Enabled = true;
                btnViernes.Enabled = true;
                btnCrarPrograma.Enabled = true;
            }
            else
            {
                model.BorrarPlanJueves();
                btnJueves.Text = "Confirmar";
                btnJueves.BackColor = Color.White;
                informacion.Text = "Selecciona los ejercicios para Jueves:";
                btnMartes.Enabled = false;
                btnMiercoles.Enabled = false;
                btnLunes.Enabled = false;
                btnViernes.Enabled = false;
                btnCrarPrograma.Enabled = false;

            }
        }

        private void btnViernes_Click(object sender, EventArgs e)
        {
            if (btnViernes.Text == "Confirmar")
            {
                btnViernes.Text = "Viernes";
                btnViernes.BackColor = Color.Silver;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.White;
                    }
                }
                informacion.Text = "";
                btnMartes.Enabled = true;
                btnMiercoles.Enabled = true;
                btnJueves.Enabled = true;
                btnLunes.Enabled = true;
                btnCrarPrograma.Enabled = true;
            }
            else
            {
                model.BorrarPlanViernes();
                btnViernes.Text = "Confirmar";
                btnViernes.BackColor = Color.White;
                informacion.Text = "Selecciona los ejercicios para Viernes:";
                btnMartes.Enabled = false;
                btnMiercoles.Enabled = false;
                btnJueves.Enabled = false;
                btnLunes.Enabled = false;
                btnCrarPrograma.Enabled = false;

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ClearSelection();

            if (e.RowIndex != -1 && e.ColumnIndex >= 0)
            {
                DataGridViewCell selectedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (btnLunes.Text == "Confirmar" && model.LunesCount() < 8)
                {
                    Planing dato = new Planing();
                    if (e.RowIndex < 2 && selectedCell.Value != null && dataGridView1.Rows[1].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                    {
                        dato.Dia = "Lunes";
                        dato.Ejercicio = (string)dataGridView1.Rows[1].Cells[e.ColumnIndex].Value;
                        dato.Repes = (string)dataGridView1.Rows[2].Cells[e.ColumnIndex].Value;
                        model.LunesAdd(dato);
                        Pintar(1, e.ColumnIndex);

                    }
                    else if (e.RowIndex > 2 && selectedCell.Value != null)
                    {

                        switch ((e.RowIndex) % 3)
                        {
                            case 0:
                                if (dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                                {
                                    dato.Dia = "Lunes";
                                    dato.Ejercicio = (string)dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value;
                                    dato.Repes = (string)dataGridView1.Rows[e.RowIndex + 2].Cells[e.ColumnIndex].Value;
                                    model.LunesAdd(dato);

                                    Pintar(e.RowIndex + 1, e.ColumnIndex);
                                }
                                break;
                            case 1:
                                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                                {
                                    dato.Dia = "Lunes";
                                    dato.Ejercicio = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                                    dato.Repes = (string)dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value;
                                    model.LunesAdd(dato);
                                    Pintar(e.RowIndex, e.ColumnIndex);
                                }
                                break;
                            case 2:
                                break;
                        }

                    }

                }

                if (btnMartes.Text == "Confirmar" && model.MartesCount() < 8)
                {
                    Planing dato = new Planing();
                    if (e.RowIndex < 2 && selectedCell.Value != null && dataGridView1.Rows[1].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                    {
                        dato.Dia = "Martes";
                        dato.Ejercicio = (string)dataGridView1.Rows[1].Cells[e.ColumnIndex].Value;
                        dato.Repes = (string)dataGridView1.Rows[2].Cells[e.ColumnIndex].Value;
                        model.MartesAdd(dato);
                        Pintar(1, e.ColumnIndex);

                    }
                    else if (e.RowIndex > 2 && selectedCell.Value != null)
                    {

                        switch ((e.RowIndex) % 3)
                        {
                            case 0:
                                if (dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                                {
                                    dato.Dia = "Martes";
                                    dato.Ejercicio = (string)dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value;
                                    dato.Repes = (string)dataGridView1.Rows[e.RowIndex + 2].Cells[e.ColumnIndex].Value;
                                    model.MartesAdd(dato);
                                    Pintar(e.RowIndex + 1, e.ColumnIndex);
                                }
                                break;
                            case 1:
                                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                                {
                                    dato.Dia = "Martes";
                                    dato.Ejercicio = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                                    dato.Repes = (string)dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value;
                                    model.MartesAdd(dato);
                                    Pintar(e.RowIndex, e.ColumnIndex);
                                }
                                break;
                            case 2:
                                break;
                        }

                    }

                }

                if (btnMiercoles.Text == "Confirmar" && model.MiercolesCount() < 8)
                {
                    Planing dato = new Planing();
                    if (e.RowIndex < 2 && selectedCell.Value != null && dataGridView1.Rows[1].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                    {
                        dato.Dia = "Miercoles";
                        dato.Ejercicio = (string)dataGridView1.Rows[1].Cells[e.ColumnIndex].Value;
                        dato.Repes = (string)dataGridView1.Rows[2].Cells[e.ColumnIndex].Value;
                        model.MiercolesAdd(dato);
                        Pintar(e.RowIndex + 1, e.ColumnIndex);

                    }
                    else if (e.RowIndex > 2 && selectedCell.Value != null)
                    {

                        switch ((e.RowIndex) % 3)
                        {
                            case 0:
                                if (dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                                {
                                    dato.Dia = "Miercoles";
                                    dato.Ejercicio = (string)dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value;
                                    dato.Repes = (string)dataGridView1.Rows[e.RowIndex + 2].Cells[e.ColumnIndex].Value;
                                    model.MiercolesAdd(dato);
                                    Pintar(e.RowIndex + 1, e.ColumnIndex);
                                }
                                break;
                            case 1:
                                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                                {
                                    dato.Dia = "Miercoles";
                                    dato.Ejercicio = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                                    dato.Repes = (string)dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value;
                                    model.MiercolesAdd(dato);
                                    Pintar(e.RowIndex, e.ColumnIndex);
                                }
                                break;
                            case 2:
                                break;
                        }
                    }
                }

                if (btnJueves.Text == "Confirmar" && model.JuevesCount() < 8)
                {
                    Planing dato = new Planing();
                    if (e.RowIndex < 2 && selectedCell.Value != null && dataGridView1.Rows[1].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                    {
                        dato.Dia = "Jueves";
                        dato.Ejercicio = (string)dataGridView1.Rows[1].Cells[e.ColumnIndex].Value;
                        dato.Repes = (string)dataGridView1.Rows[2].Cells[e.ColumnIndex].Value;
                        model.JuevesAdd(dato);
                        Pintar(1, e.ColumnIndex);

                    }
                    else if (e.RowIndex > 2 && selectedCell.Value != null)
                    {

                        switch ((e.RowIndex) % 3)
                        {
                            case 0:
                                if (dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                                {
                                    dato.Dia = "Jueves";
                                    dato.Ejercicio = (string)dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value;
                                    dato.Repes = (string)dataGridView1.Rows[e.RowIndex + 2].Cells[e.ColumnIndex].Value;
                                    model.JuevesAdd(dato);
                                    Pintar(e.RowIndex + 1, e.ColumnIndex);
                                }
                                break;
                            case 1:
                                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                                {
                                    dato.Dia = "Jueves";
                                    dato.Ejercicio = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                                    dato.Repes = (string)dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value;
                                    model.JuevesAdd(dato);
                                    Pintar(e.RowIndex, e.ColumnIndex);
                                }
                                break;
                            case 2:
                                break;
                        }
                    }
                }

                if (btnViernes.Text == "Confirmar" && model.ViernesCount() < 8)
                {
                    Planing dato = new Planing();
                    if (e.RowIndex < 2 && selectedCell.Value != null && dataGridView1.Rows[1].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                    {
                        dato.Dia = "Viernes";
                        dato.Ejercicio = (string)dataGridView1.Rows[1].Cells[e.ColumnIndex].Value;
                        dato.Repes = (string)dataGridView1.Rows[2].Cells[e.ColumnIndex].Value;
                        model.ViernesAdd(dato);
                        Pintar(1, e.ColumnIndex);

                    }
                    else if (e.RowIndex > 2 && selectedCell.Value != null)
                    {

                        switch ((e.RowIndex) % 3)
                        {
                            case 0:
                                if (dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                                {
                                    dato.Dia = "Viernes";
                                    dato.Ejercicio = (string)dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value;
                                    dato.Repes = (string)dataGridView1.Rows[e.RowIndex + 2].Cells[e.ColumnIndex].Value;
                                    model.ViernesAdd(dato);
                                    Pintar(e.RowIndex + 1, e.ColumnIndex);
                                }
                                break;
                            case 1:
                                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                                {
                                    dato.Dia = "Viernes";
                                    dato.Ejercicio = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                                    dato.Repes = (string)dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value;
                                    model.ViernesAdd(dato);
                                    Pintar(e.RowIndex, e.ColumnIndex);
                                }
                                break;
                            case 2:
                                break;
                        }

                    }

                }
            }
        }
        private void Pintar(int fila, int columna)
        {
            DataGridViewCell selectedCell = dataGridView1.Rows[fila].Cells[columna];
            if (fila >= 0 && columna >= 0)
            {
                dataGridView1.Rows[fila].Cells[columna].Style.BackColor = Color.PaleTurquoise;
            }
        }
        private void btnCrarPrograma_Click(object sender, EventArgs e)
        {
            string nombre = cbNombres.SelectedItem != null ? cbNombres.SelectedItem.ToString() : null;

            if (nombre != string.Empty && nombre != null && nombre != "-1")
            {
                try
                {
                    model.GenerarRutina(nombre);
                    btnLunes.BackColor = Color.White;
                    btnMartes.BackColor = Color.White;
                    btnMiercoles.BackColor = Color.White;
                    btnJueves.BackColor = Color.White;
                    btnViernes.BackColor = Color.White;

                    MessageBox.Show("Programa semanal de " + nombre +
                                " actualizado correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido conectar con la base de datos. " + ex.Message);
                    timerParpadeo.Start();
                }
                
            }
        }
        private void Restablecer()
        {
            lblSinConexion.Visible = false;
            pbSinConexion.Visible = false;
        }
        private void timerParpadeo_Tick(object sender, EventArgs e)
        {
            lblSinConexion.Visible = !lblSinConexion.Visible;
            pbSinConexion.Visible = !pbSinConexion.Visible;
        }
        private void CargarNombres()
        {
            cbNombres.Items.Clear();

            try
            {
                List<string> lista = new List<string>();
                lista = model.ListaDeUsuarios();

                foreach (string nombre in lista)
                {
                    cbNombres.Items.Add(nombre);
                }
            }
            catch
            {
                timerParpadeo.Start();
            }

        }
    }
}
