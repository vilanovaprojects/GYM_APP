using Domain;
using Domain.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Seleccione una imagen";
            dialog.Filter = "Archivos de imagen| *.jpg; *.jpeg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string archivoSeleccionado = dialog.FileName;
                long tamanoArchivoBytes = new FileInfo(archivoSeleccionado).Length;       // Validar el tamaño del archivo en bytes
                long tamanoArchivoKB = tamanoArchivoBytes / 1024;                                   // Convertir bytes a kilobytes (KB)
                long limiteTamanoKB = 500;                                                           // Establecer el límite de tamaño permitido en KB (50 KB en este ejemplo)

                if (tamanoArchivoKB > limiteTamanoKB)
                {
                    MessageBox.Show("El archivo seleccionado excede el límite de tamaño permitido de " + limiteTamanoKB + " KB.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pbImagen.ImageLocation = dialog.FileName;
                }

            }
        }

        public void CargardgvBorrarEjercicio()
        {
            try
            {
                var clase = new ClassAdd();
                List<string> nombres = clase.ListaDeEjercicios();

                foreach (string nombre in nombres)
                {
                    dgvBorradoDatos.Rows.Add(nombre);
                }
            }
            catch(Exception ex)
            {
                labelError.Text = "No hay conexión con la base de datos:\n" + ex.Message;
            }


        }

        private void btnBorrarImagen_Click(object sender, EventArgs e)
        {
            pbImagen.Image = null;
        }

        private void btnBorrarEjercicio_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection selectedCells = dgvBorradoDatos.SelectedCells;
            List<string> listado = new List<string>();
            foreach(DataGridViewCell cell in selectedCells)
            {
                listado.Add(cell.Value.ToString());
            }

            var clase = new ClassAdd();
            string resultado = clase.BorradoDeEjercicios(listado);

            MessageBox.Show(resultado);

            CargardgvBorrarEjercicio();
        }

        private void btnAnadirEjercicio_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != string.Empty && txtTipo.Text != string.Empty)
            {
                string nombre = txtNombre.Text;
                string tipo = txtTipo.Text;
                string comentario = txtComentarios.Text;
                byte[] imagen = clsImagen.ImageToByte(pbImagen.Image);

                var clase = new ClassAdd();
                string resultado = clase.AnadirEjercicio(nombre, tipo, comentario, imagen);

                MessageBox.Show(resultado);

                txtNombre.Text = string.Empty;
                txtTipo.Text = string.Empty;
                txtComentarios.Text = string.Empty;
                pbImagen.Image = null;
            }
            else
            {
                MessageBox.Show("Nombre y tipo no pueden estar vacíos.");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargardgvBorrarEjercicio();
        }
    }
}
