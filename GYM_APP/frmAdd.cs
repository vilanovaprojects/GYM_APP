using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GYM_APP
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
            CargardgvBorrarEjercicio();
        }

        private static string ConnectionDB()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("connection/connection.xml");


            XmlNode connectionStringNode = xmlDoc.SelectSingleNode("/configuration/appSettings/add[@key='ConnectionString']");
            XmlAttribute valueAttribute = connectionStringNode.Attributes["value"];

            if (valueAttribute != null)
            {

                return valueAttribute.Value;

            }


            return "conexion fallida";
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

            dgvBorradoDatos.Rows.Clear();
            try
            {
                MySqlConnection conexion = new MySqlConnection(ConnectionDB());
                conexion.Open();
                string insertQuery = "SELECT nombre FROM EJERCICIOS";
                MySqlCommand command = new MySqlCommand(insertQuery, conexion);
                MySqlDataReader rd = command.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        dgvBorradoDatos.Rows.Add(rd.GetString(0));

                    }
                }

                conexion.Close();
                labelError.Text = string.Empty;
            }
            catch (MySqlException ex)
            {
                labelError.Text = "No hay conexión con la base de datos:\n" + ex.Message;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message);
            }


        }

        private void btnBorrarImagen_Click(object sender, EventArgs e)
        {
            pbImagen.Image = null;
        }

        private void btnBorrarEjercicio_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection selectedCells = dgvBorradoDatos.SelectedCells;

            try
            {
                foreach (DataGridViewCell cell in selectedCells)
                {
                    string nombre = cell.Value.ToString();

                    MySqlConnection conexion = new MySqlConnection(ConnectionDB());
                    conexion.Open();

                    string deleteQuery = "DELETE FROM EJERCICIOS WHERE nombre = @nombre";
                    MySqlCommand command = new MySqlCommand(deleteQuery, conexion);
                    command.Parameters.AddWithValue("@nombre", nombre);

                    command.ExecuteNonQuery();

                    conexion.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar con la base de datos:\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message);
            }

            CargardgvBorrarEjercicio();

        }

        private void btnAnadirEjercicio_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text != string.Empty && txtTipo.Text != string.Empty)
            {
                try
                {
                    string nombre = txtNombre.Text;
                    string tipo = txtTipo.Text;
                    string comentarios = txtComentarios.Text;
                    byte[] imagen = clsImagen.ImageToByte(pbImagen.Image);

                    MySqlConnection conexion = new MySqlConnection(ConnectionDB());
                    conexion.Open();

                    string insertQuery = "INSERT INTO EJERCICIOS (nombre, tipo, comentarios, img_ejercicio) VALUES (@nombre, @tipo, @comentarios, @imagen)";

                    MySqlCommand command = new MySqlCommand(insertQuery, conexion);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@tipo", tipo);
                    command.Parameters.AddWithValue("@comentarios", comentarios);
                    command.Parameters.AddWithValue("@imagen", imagen);


                    command.ExecuteNonQuery();
                    conexion.Close();

                    MessageBox.Show("Añadido correctamente");

                    txtNombre.Text = string.Empty;
                    txtTipo.Text = string.Empty;
                    txtComentarios.Text = string.Empty;
                    pbImagen.Image = null;
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos:\n" + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:\n" + ex.Message);
                }
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
