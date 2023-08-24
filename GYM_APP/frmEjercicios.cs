using Microsoft.Win32;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GYM_APP
{
    public partial class frmEjercicios : Form
    {

        private List<Planing> listaLunes = new List<Planing>();
        private List<Planing> listaMartes = new List<Planing>();
        private List<Planing> listaMiercoles = new List<Planing>();
        private List<Planing> listaJueves = new List<Planing>();
        private List<Planing> listaViernes = new List<Planing>();

        private List<Registros> registros = new List<Registros>();
        private List<string> columnas = new List<string>();

        public frmEjercicios()
        {
            InitializeComponent();
            Restablecer();
            LeerDatabase();
            CargarDataGridView();

        }

        private static string ConnectionDB()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("connection/connection.xml");

                XmlNode connectionStringNode = xmlDoc.SelectSingleNode("/configuration/appSettings/add[@key='ConnectionString']");
                XmlAttribute valueAttribute = connectionStringNode.Attributes["value"];

                if (valueAttribute != null)
                {
                    return valueAttribute.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido leer el archivo de conexión." + ex);
            }

            return "conexion fallida";
        }
        private void LeerDatabase()
        {

            registros.Clear();
            columnas.Clear();

            string cadenaConexion = ConnectionDB();
            if (cadenaConexion == "conexion fallida")
            {
                timerParpadeo.Start();
            }
            else
            {
                try
                {
                    MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                    conexion.Open();
                    MySqlCommand comand = new MySqlCommand("Readonly", conexion);
                    comand.CommandType = CommandType.StoredProcedure;

                    MySqlDataReader rd = comand.ExecuteReader();

                    //List<Registros> registros = new List<Registros>();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            registros.Add(new Registros
                            {
                                Nombre = rd.GetString(0),
                                Tipo = rd.GetString(1),
                                Comentarios = rd.IsDBNull(2) ? "" : rd.GetString(2),
                                Imagen = rd.IsDBNull(3) ? null : (byte[])rd.GetValue(3),
                            });

                            // Agrega el tipo a la lista 'columnas' si aún no existe
                            string tipo = rd.GetString(1);
                            if (!columnas.Contains(tipo))
                            {
                                columnas.Add(tipo);
                            }
                        }
                    }
                    conexion.Close();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("No se ha podido conectar con la base de datos. " + ex.Message);
                    timerParpadeo.Start();
                }


            }


        }

        private void CargarDataGridView()
        {
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
                listaLunes.Clear();
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
                listaMartes.Clear();
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
                listaMiercoles.Clear();
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
                listaJueves.Clear();
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
                listaViernes.Clear();
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

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection(ConnectionDB());
            conexion.Open();

            //Borrado previo de la tabla
            string truncateQuery = "TRUNCATE TABLE PLANING";
            MySqlCommand truncateCommand = new MySqlCommand(truncateQuery, conexion);
            truncateCommand.ExecuteNonQuery();



            string insertQuery = "INSERT INTO PLANING (dia, ejercicio, repes) VALUES (@dia, @ejercicio, @repes)";
            MySqlCommand command = new MySqlCommand(insertQuery, conexion);


            command.Parameters.Add("@dia", MySqlDbType.VarChar);
            command.Parameters.Add("@ejercicio", MySqlDbType.VarChar);
            command.Parameters.Add("@repes", MySqlDbType.VarChar);


            foreach (Planing dato in listaLunes)
            {
                command.Parameters["@dia"].Value = "Lunes";
                command.Parameters["@ejercicio"].Value = dato.Ejercicio;
                command.Parameters["@repes"].Value = dato.Repes;
                command.ExecuteNonQuery();
            }
            foreach (Planing dato in listaMartes)
            {
                command.Parameters["@dia"].Value = "Martes";
                command.Parameters["@ejercicio"].Value = dato.Ejercicio;
                command.Parameters["@repes"].Value = dato.Repes;
                command.ExecuteNonQuery();
            }
            foreach (Planing dato in listaMiercoles)
            {
                command.Parameters["@dia"].Value = "Miercoles";
                command.Parameters["@ejercicio"].Value = dato.Ejercicio;
                command.Parameters["@repes"].Value = dato.Repes;
                command.ExecuteNonQuery();
            }
            foreach (Planing dato in listaJueves)
            {
                command.Parameters["@dia"].Value = "Jueves";
                command.Parameters["@ejercicio"].Value = dato.Ejercicio;
                command.Parameters["@repes"].Value = dato.Repes;
                command.ExecuteNonQuery();
            }
            foreach (Planing dato in listaViernes)
            {
                command.Parameters["@dia"].Value = "Viernes";
                command.Parameters["@ejercicio"].Value = dato.Ejercicio;
                command.Parameters["@repes"].Value = dato.Repes;
                command.ExecuteNonQuery();
            }

            conexion.Close();

            btnLunes.BackColor = Color.White;
            btnMartes.BackColor = Color.White;
            btnMiercoles.BackColor = Color.White;
            btnJueves.BackColor = Color.White;
            btnViernes.BackColor = Color.White;

            MessageBox.Show("Programa semanal actualizado correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void Pintar(int fila, int columna)
        {
            DataGridViewCell selectedCell = dataGridView1.Rows[fila].Cells[columna];
            if (fila >= 0 && columna >= 0)
            {
                dataGridView1.Rows[fila].Cells[columna].Style.BackColor = Color.PaleTurquoise;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ClearSelection();

            if (e.RowIndex != -1 && e.ColumnIndex >= 0)
            {
                DataGridViewCell selectedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (btnLunes.Text == "Confirmar" && listaLunes.Count < 8)
                {
                    Planing dato = new Planing();
                    if (e.RowIndex < 2 && selectedCell.Value != null && dataGridView1.Rows[1].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                    {
                        dato.Ejercicio = (string)dataGridView1.Rows[1].Cells[e.ColumnIndex].Value;
                        dato.Repes = (string)dataGridView1.Rows[2].Cells[e.ColumnIndex].Value;
                        listaLunes.Add(dato);
                        Pintar(1, e.ColumnIndex);

                    }
                    else if (e.RowIndex > 2 && selectedCell.Value != null)
                    {

                        switch ((e.RowIndex) % 3)
                        {
                            case 0:
                                if (dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                                {
                                    dato.Ejercicio = (string)dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value;
                                    dato.Repes = (string)dataGridView1.Rows[e.RowIndex + 2].Cells[e.ColumnIndex].Value;
                                    listaLunes.Add(dato);
                                    Pintar(e.RowIndex + 1, e.ColumnIndex);
                                }
                                break;
                            case 1:
                                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                                {
                                    dato.Ejercicio = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                                    dato.Repes = (string)dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value;
                                    listaLunes.Add(dato);
                                    Pintar(e.RowIndex, e.ColumnIndex);
                                }
                                break;
                            case 2:
                                break;
                        }

                    }

                }

                if (btnMartes.Text == "Confirmar" && listaMartes.Count < 8)
                {
                    Planing dato = new Planing();
                    if (e.RowIndex < 2 && selectedCell.Value != null && dataGridView1.Rows[1].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                    {
                        dato.Ejercicio = (string)dataGridView1.Rows[1].Cells[e.ColumnIndex].Value;
                        dato.Repes = (string)dataGridView1.Rows[2].Cells[e.ColumnIndex].Value;
                        listaMartes.Add(dato);
                        Pintar(1, e.ColumnIndex);

                    }
                    else if (e.RowIndex > 2 && selectedCell.Value != null)
                    {

                        switch ((e.RowIndex) % 3)
                        {
                            case 0:
                                if (dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                                {
                                    dato.Ejercicio = (string)dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value;
                                    dato.Repes = (string)dataGridView1.Rows[e.RowIndex + 2].Cells[e.ColumnIndex].Value;
                                    listaMartes.Add(dato);
                                    Pintar(e.RowIndex + 1, e.ColumnIndex);
                                }
                                break;
                            case 1:
                                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                                {
                                    dato.Ejercicio = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                                    dato.Repes = (string)dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value;
                                    listaMartes.Add(dato);
                                    Pintar(e.RowIndex, e.ColumnIndex);
                                }
                                break;
                            case 2:
                                break;
                        }

                    }

                }

                if (btnMiercoles.Text == "Confirmar" && listaMiercoles.Count < 8)
                {
                    Planing dato = new Planing();
                    if (e.RowIndex < 2 && selectedCell.Value != null && dataGridView1.Rows[1].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                    {
                        dato.Ejercicio = (string)dataGridView1.Rows[1].Cells[e.ColumnIndex].Value;
                        dato.Repes = (string)dataGridView1.Rows[2].Cells[e.ColumnIndex].Value;
                        listaMiercoles.Add(dato);
                        Pintar(e.RowIndex + 1, e.ColumnIndex);

                    }
                    else if (e.RowIndex > 2 && selectedCell.Value != null)
                    {

                        switch ((e.RowIndex) % 3)
                        {
                            case 0:
                                if (dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                                {
                                    dato.Ejercicio = (string)dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value;
                                    dato.Repes = (string)dataGridView1.Rows[e.RowIndex + 2].Cells[e.ColumnIndex].Value;
                                    listaMiercoles.Add(dato);
                                    Pintar(e.RowIndex + 1, e.ColumnIndex);
                                }
                                break;
                            case 1:
                                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                                {
                                    dato.Ejercicio = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                                    dato.Repes = (string)dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value;
                                    listaMiercoles.Add(dato);
                                    Pintar(e.RowIndex, e.ColumnIndex);
                                }
                                break;
                            case 2:
                                break;
                        }
                    }
                }

                if (btnJueves.Text == "Confirmar" && listaJueves.Count < 8)
                {
                    Planing dato = new Planing();
                    if (e.RowIndex < 2 && selectedCell.Value != null && dataGridView1.Rows[1].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                    {
                        dato.Ejercicio = (string)dataGridView1.Rows[1].Cells[e.ColumnIndex].Value;
                        dato.Repes = (string)dataGridView1.Rows[2].Cells[e.ColumnIndex].Value;
                        listaJueves.Add(dato);
                        Pintar(1, e.ColumnIndex);

                    }
                    else if (e.RowIndex > 2 && selectedCell.Value != null)
                    {

                        switch ((e.RowIndex) % 3)
                        {
                            case 0:
                                if (dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                                {
                                    dato.Ejercicio = (string)dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value;
                                    dato.Repes = (string)dataGridView1.Rows[e.RowIndex + 2].Cells[e.ColumnIndex].Value;
                                    listaJueves.Add(dato);
                                    Pintar(e.RowIndex + 1, e.ColumnIndex);
                                }
                                break;
                            case 1:
                                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                                {
                                    dato.Ejercicio = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                                    dato.Repes = (string)dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value;
                                    listaJueves.Add(dato);
                                    Pintar(e.RowIndex, e.ColumnIndex);
                                }
                                break;
                            case 2:
                                break;
                        }
                    }
                }

                if (btnViernes.Text == "Confirmar" && listaViernes.Count < 8)
                {
                    Planing dato = new Planing();
                    if (e.RowIndex < 2 && selectedCell.Value != null && dataGridView1.Rows[1].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                    {
                        dato.Ejercicio = (string)dataGridView1.Rows[1].Cells[e.ColumnIndex].Value;
                        dato.Repes = (string)dataGridView1.Rows[2].Cells[e.ColumnIndex].Value;
                        listaJueves.Add(dato);
                        Pintar(1, e.ColumnIndex);

                    }
                    else if (e.RowIndex > 2 && selectedCell.Value != null)
                    {

                        switch ((e.RowIndex) % 3)
                        {
                            case 0:
                                if (dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                                {
                                    dato.Ejercicio = (string)dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value;
                                    dato.Repes = (string)dataGridView1.Rows[e.RowIndex + 2].Cells[e.ColumnIndex].Value;
                                    listaViernes.Add(dato);
                                    Pintar(e.RowIndex + 1, e.ColumnIndex);
                                }
                                break;
                            case 1:
                                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.PaleTurquoise)
                                {
                                    dato.Ejercicio = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                                    dato.Repes = (string)dataGridView1.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value;
                                    listaViernes.Add(dato);
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

        private void Restablecer()
        {
            lblSinConexion.Visible = false;
            pbSinConexion.Visible = false;
        }

        private void timerSinConexion_Tick(object sender, EventArgs e)
        {
            lblSinConexion.Visible = !lblSinConexion.Visible;
            pbSinConexion.Visible = !pbSinConexion.Visible;
        }

    }
}

