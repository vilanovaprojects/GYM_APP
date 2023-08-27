using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GYM_APP
{
    public partial class frmOpciones : Form
    {
        private List<Registros> registros = new List<Registros>();
        private List<string> columnas = new List<string>();



        public frmOpciones()
        {
            InitializeComponent();
            CargarUsuarios();

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

                string filePath = "Connection/connection.xml";
                XmlDocument xmlDoc = new XmlDocument();

                try
                {
                    xmlDoc.Load(filePath);

                    XmlNode connectionStringNode = xmlDoc.SelectSingleNode("/configuration/appSettings/add[@key='ConnectionString']");

                    if (connectionStringNode != null)
                    {
                        // Obtener el atributo 'value'
                        XmlAttribute valueAttribute = connectionStringNode.Attributes["value"];

                        if (valueAttribute != null)
                        {

                            string newConnectionString = "Server=" + host + ";Database=" + db + ";Uid=" + user + ";Pwd=" + pass + ";";

                            valueAttribute.Value = newConnectionString;

                            xmlDoc.Save(filePath);

                            MessageBox.Show("Guardado correctamente");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encuentra la cadena de conexión en el archivo XML.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar/modificar/guardar el archivo XML: " + ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Debes introducir todos los datos.");
            }

        }
        private void ReiniciarEtiquetas()
        {
            lblHost.Text = "";
            lblDB.Text = "";
            lblUser.Text = "";
            lblConexion.Text = "";
        }

        private void btnComprobarConexion_Click(object sender, EventArgs e)
        {
            ReiniciarEtiquetas();

            try
            {
                string filePath = "Connection/connection.xml";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);

                XmlNode connectionStringNode = xmlDoc.SelectSingleNode("/configuration/appSettings/add[@key='ConnectionString']");
                string connectionString = connectionStringNode.Attributes["value"].Value;

                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder(connectionString);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        lblConexion.Text = "Conexión establecida.";
                        lblHost.Text = builder.Server;
                        lblDB.Text = builder.Database;
                        lblUser.Text = builder.UserID;
                    }
                    catch
                    {
                        lblConexion.Text = "Error de conexión.";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de lectura de archivo XML." + ex.Message);
            }


        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string contrasena = txtContrasena.Text;
                string filePath = "Connection/connection.xml";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);

                XmlNode connectionStringNode = xmlDoc.SelectSingleNode("/configuration/appSettings/add[@key='ConnectionString']");
                string connectionString = connectionStringNode.Attributes["value"].Value;

                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder(connectionString);

                MySqlConnection connection = new MySqlConnection(connectionString);

                connection.Open();
                MySqlCommand comand = new MySqlCommand("CrearUsuario", connection);
                comand.CommandType = CommandType.StoredProcedure;

                comand.Parameters.Add(new MySqlParameter("@Inombre", MySqlDbType.VarChar)).Value = nombre;
                comand.Parameters.Add(new MySqlParameter("@Icontrasena", MySqlDbType.VarChar)).Value = contrasena;

                try
                {
                    comand.ExecuteNonQuery();
                    labelErrorConexion.Text = "Procedimiento ejecutado correctamente";
                }
                catch (Exception ex)
                {
                    labelErrorConexion.Text = "Error: " + ex.Message;
                }
                finally
                {
                    connection.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.\n" + ex.Message);
            }

            CargarUsuarios();


        }

        private void CargarUsuarios()
        {
            dgvNombres.Rows.Clear();
            try
            {
                string filePath = "Connection/connection.xml";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);

                XmlNode connectionStringNode = xmlDoc.SelectSingleNode("/configuration/appSettings/add[@key='ConnectionString']");
                string connectionString = connectionStringNode.Attributes["value"].Value;

                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder(connectionString);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "SELECT USUARIO FROM USUARIOS";
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    MySqlDataReader rd = command.ExecuteReader();

                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            dgvNombres.Rows.Add(rd.GetString(0));

                        }
                    }
                }
            }
            catch
            {
                lblConexion.Text = "Error de conexión.";
            }


        }


        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedCellCollection selectedCells = dgvNombres.SelectedCells;

                string nombre = selectedCells[0].Value.ToString();

                string filePath = "Connection/connection.xml";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);

                XmlNode connectionStringNode = xmlDoc.SelectSingleNode("/configuration/appSettings/add[@key='ConnectionString']");
                string connectionString = connectionStringNode.Attributes["value"].Value;

                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder(connectionString);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand comand = new MySqlCommand("EliminarUsuario", connection);
                    comand.CommandType = CommandType.StoredProcedure;

                    comand.Parameters.Add(new MySqlParameter("@Inombre", MySqlDbType.VarChar)).Value = nombre;


                    try
                    {
                        comand.ExecuteNonQuery();
                        labelErrorConexion.Text = "Procedimiento ejecutado correctamente";
                    }
                    catch (Exception ex)
                    {
                        labelErrorConexion.Text = "Error: " + ex.Message;
                    }

                    CargarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar." + ex.Message);
            }


        }
    }

}
