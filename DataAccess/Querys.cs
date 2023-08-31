using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Querys:ConnectionToMySQL
    {
        private string conexion;
        public Querys(string conexion) : base(conexion)
        {
            this.conexion = conexion;  
        }

        public MySqlDataReader leerTodosLosEjercicios()
        {
            string leerejercicios = "SELECT * FROM EJERCICIOS";

            var connection = GetConnection();
            connection.Open();           //!!!!OJO¡¡¡ lector abierto hay que cerrarlo
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = leerejercicios;
                    
            MySqlDataReader rd = command.ExecuteReader();

            return rd;
                  
        }

        public void BorrarPlanUsuario(string usuario)
        {
            string deleteQuery = "DELETE FROM PLANING WHERE usuario = @usuario";

            var connection = GetConnection();
            connection.Open();
            MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection);
            deleteCommand.Parameters.Add("@usuario", MySqlDbType.VarChar);
            deleteCommand.Parameters["@usuario"].Value = usuario;
            deleteCommand.ExecuteNonQuery();
            connection.Close();

            


        }

        public MySqlCommand CreaPlanUsuario()
        {
            string insertQuery = "INSERT INTO PLANING (usuario, dia, ejercicio, repes) VALUES (@usuario, @dia, @ejercicio, @repes)";
            var connection = GetConnection();
            connection.Open();

            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            command.Parameters.Add("@usuario", MySqlDbType.VarChar);
            command.Parameters.Add("@dia", MySqlDbType.VarChar);
            command.Parameters.Add("@ejercicio", MySqlDbType.VarChar);
            command.Parameters.Add("@repes", MySqlDbType.VarChar);
            return command;

        }

        public List<string> ListaDeUsuarios()
        {
            List<string> list = new List<string>();

            string listaQuery = "SELECT * FROM USUARIOS";
            var connection = GetConnection();
            connection.Open();
            MySqlCommand comand = new MySqlCommand(listaQuery, connection);

            MySqlDataReader rd = comand.ExecuteReader();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    list.Add(rd.GetString(0));
                }
            }
            connection.Close();
            return list;
        }

        public string[] TestConnection()
        {
            string[] datosconexion = new string[3];

            
            
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder(conexion);

            var connection = GetConnection();

            connection.Open();

            datosconexion[0] = builder.Server;
            datosconexion[1] = builder.Database;
            datosconexion[2] = builder.UserID;



            return datosconexion;
        }

        public string CreaUsuario(string usuario, string contrasena)
        {
            var connection = GetConnection();
            connection.Open();
            MySqlCommand comand = new MySqlCommand("CrearUsuario", connection);
            comand.CommandType = CommandType.StoredProcedure;

            comand.Parameters.Add(new MySqlParameter("@Inombre", MySqlDbType.VarChar)).Value = usuario;
            comand.Parameters.Add(new MySqlParameter("@Icontrasena", MySqlDbType.VarChar)).Value = contrasena;
            try
            {
                comand.ExecuteNonQuery();
                string salebien = "Procedimiento ejecutado correctamente";
                return salebien;
            }
            catch (Exception ex)
            {
                string salemal = "Error: " + ex.Message;
                return salemal;
            }
        }

        public string EliminaUsuario(string usuario)
        {
            var connection = GetConnection();
            connection.Open();
            MySqlCommand comand = new MySqlCommand("EliminarUsuario", connection);
            comand.CommandType = CommandType.StoredProcedure;

            comand.Parameters.Add(new MySqlParameter("@Inombre", MySqlDbType.VarChar)).Value = usuario;

            try
            {
                comand.ExecuteNonQuery();
                string salebien = "Procedimiento ejecutado correctamente";
                return salebien;
            }
            catch (Exception ex)
            {
                string salemal = "Error: " + ex.Message;
                return salemal;
            }
        }

        public List<string> ListaDeEjercicios()
        {
            List<string> list = new List<string>();

            string listaQuery = "SELECT nombre FROM EJERCICIOS";
            var connection = GetConnection();
            connection.Open();
            MySqlCommand comand = new MySqlCommand(listaQuery, connection);

            MySqlDataReader rd = comand.ExecuteReader();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    list.Add(rd.GetString(0));
                }
            }
            connection.Close();
            return list;
        }

        public string BorradoDeEjercicios(List<string> listado)
        {
            try
            {
                foreach (string nombre in listado)
                {
                    string deleteQuery = "DELETE FROM EJERCICIOS WHERE nombre = @nombre";
                    var connection = GetConnection();
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@nombre", nombre);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return "Borrado correctamente";
            }
            catch (Exception ex)
            {
                return "Error. \n" + ex;
            }

        }
        public string AnadirEjercicio(string nombre, string tipo, string comentario, byte[] imagen)
        {
            try
            {

                string insertQuery = "INSERT INTO EJERCICIOS (nombre, tipo, comentarios, img_ejercicio) VALUES (@nombre, @tipo, @comentarios, @imagen)";
                var connection = GetConnection();
                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@tipo", tipo);
                command.Parameters.AddWithValue("@comentarios", comentario);
                command.Parameters.AddWithValue("@imagen", imagen);


                command.ExecuteNonQuery();
                connection.Close();
                return "Añadido correctamente.";
            }
            catch (Exception ex)
            {
                return "Error. \n" + ex;
            }

        }

        public MySqlDataReader LeerPlanigDe(string usuario)
        {
            string planQuery = "SELECT p.dia, e.nombre, p.repes, p.Comentarios, e.img_ejercicio FROM EJERCICIOS e INNER JOIN PLANING p ON e.nombre = p.ejercicio WHERE p.usuario = @nombre;";

            var connection = GetConnection();
            connection.Open();           //!!!!OJO¡¡¡ lector abierto hay que cerrarlo
            MySqlCommand command = new MySqlCommand(planQuery, connection);
            command.Parameters.AddWithValue("@nombre", usuario);

            MySqlDataReader rd = command.ExecuteReader();

            return rd;

        }


    }
}
