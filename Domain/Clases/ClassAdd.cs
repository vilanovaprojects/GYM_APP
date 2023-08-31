using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Clases
{
    public class ClassAdd
    {
        public List<string> ListaDeEjercicios()
        {
            string conexion;
            XML getconnection = new XML();
            conexion = getconnection.ReadfromXML();
            Querys Query = new Querys(conexion);

            List<string> lista = new List<string>();
            lista = Query.ListaDeEjercicios();

            return lista;

        }

        public string BorradoDeEjercicios(List<string> listado)
        {
            string conexion;
            XML getconnection = new XML();
            conexion = getconnection.ReadfromXML();
            Querys Query = new Querys(conexion);

            return Query.BorradoDeEjercicios(listado);

        }

        public string AnadirEjercicio(string nombre, string tipo, string comentario, byte[] imagen)
        {
            string conexion;
            XML getconnection = new XML();
            conexion = getconnection.ReadfromXML();
            Querys Query = new Querys(conexion);

            return Query.AnadirEjercicio(nombre, tipo, comentario, imagen);

        }
    }
}
