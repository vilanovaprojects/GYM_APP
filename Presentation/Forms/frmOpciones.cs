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
    public partial class frmOpciones : Form
    {
        public frmOpciones()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void ReiniciarEtiquetas()
        {
            lblHost.Text = "";
            lblDB.Text = "";
            lblUser.Text = "";
            lblConexion.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string host = txtHost.Text;
            string db = txtDB.Text;
            string user = txtUser.Text;
            string pass = txtPass.Text;
            ReiniciarEtiquetas();

            if (user != string.Empty && pass != string.Empty && host != string.Empty && db != string.Empty)
            {
                string newConnectionString = "Server=" + host + ";Database=" + db + ";Uid=" + user + ";Pwd=" + pass + ";";

                try
                {
                    XML objeto = new XML();

                    objeto.SavetoXML(newConnectionString);

                    MessageBox.Show("Guardado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo XML: " + ex.Message);
                }
            }

            else
            {
                MessageBox.Show("Debes introducir todos los datos.");
            }
        }

        private void btnComprobarConexion_Click(object sender, EventArgs e)
        {
            ReiniciarEtiquetas();

            try
            {
                var clase = new ClassOpciones();
                string[] datosconexion = clase.TestConnection();

                lblHost.Text = datosconexion[0];
                lblDB.Text = datosconexion[1];
                lblUser.Text = datosconexion[2];
                lblConexion.Text = "Conexión establecida.";

            }
            catch (Exception ex)
            {
                lblConexion.Text = "Error de conexión.\n" + ex.Message;

            }

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != string.Empty && txtContrasena.Text != string.Empty)
            {
                try
                {
                    string nombre = txtNombre.Text;
                    string contrasena = txtContrasena.Text;

                    var clase = new ClassOpciones();
                    string resultado = clase.CreaUsuario(nombre, contrasena);

                    labelErrorConexion.Text = resultado;

                }
                catch (Exception ex)
                {
                    labelErrorConexion.Text = "Error.\n" + ex.Message;
                }

                CargarUsuarios();

            }
            else
            {
                labelErrorConexion.Text = "Introduce nombre y contraseña";
            }
        }
        private void CargarUsuarios()
        {
            dgvNombres.Rows.Clear();
            try
            {
                var clase = new ClassOpciones();
                List<string> nombre = clase.ListaDeUsuarios();

                foreach (string nom in nombre)
                {
                    dgvNombres.Rows.Add(nom);
                }
            }
            catch
            {
                lblConexion.Text = "Error de conexión.";
            }


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection selectedCells = dgvNombres.SelectedCells;

            string nombre = selectedCells[0].Value.ToString();
            try
            {
                var clase = new ClassOpciones();
                string resultado = clase.EliminaUsuario(nombre);

                labelErrorConexion.Text = resultado;

            }
            catch (Exception ex)
            {
                labelErrorConexion.Text = "Error.\n" + ex.Message;
            }

            CargarUsuarios();

        }
    }
}
