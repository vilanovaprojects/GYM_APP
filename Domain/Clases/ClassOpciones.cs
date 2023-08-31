using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Clases
{
    public class ClassOpciones
    {

        public string[] TestConnection()
        {
            string conexion;
            XML getconnection = new XML();
            conexion = getconnection.ReadfromXML();
            Querys Query = new Querys(conexion);

            string[] datosconexion = Query.TestConnection();

            return datosconexion;

        }
        public List<string> ListaDeUsuarios()
        {
            string conexion;
            XML getconnection = new XML();
            conexion = getconnection.ReadfromXML();
            Querys Query = new Querys(conexion);

            List<string> lista = new List<string>();
            lista = Query.ListaDeUsuarios();

            return lista;

        }

        public string CreaUsuario(string usuario, string contrasena)
        {
            string conexion;
            XML getconnection = new XML();
            conexion = getconnection.ReadfromXML();
            Querys Query = new Querys(conexion);

            string resultado = Query.CreaUsuario(usuario, contrasena);

            return resultado;
        }

        public string EliminaUsuario(string usuario)
        {
            string conexion;
            XML getconnection = new XML();
            conexion = getconnection.ReadfromXML();
            Querys Query = new Querys(conexion);

            string resultado = Query.EliminaUsuario(usuario);

            return resultado;
        }
    }
}
