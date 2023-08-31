using DataAccess;
using Microsoft.Win32;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Clases
{
    public class ClassPlaning
    {
        private List<Planing2> rutina = new List<Planing2>();


        public List<Planing2> DescargarPlan(string nombre)
        {
            string conexion;
            XML getconnection = new XML();
            conexion = getconnection.ReadfromXML();

            Querys Query = new Querys(conexion);

            using (var lector = Query.LeerPlanigDe(nombre))
            {
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        rutina.Add(new Planing2
                        {
                            Dia = lector.GetString(0),
                            Ejercicio = lector.GetString(1),
                            Repes = lector.GetString(2),
                            Comentarios = lector.IsDBNull(3) ? "" : lector.GetString(3),
                            Imagen = lector.IsDBNull(4) ? null : (byte[])lector.GetValue(4),
                        });
                    }
                }
                lector.Close();

            }
            return rutina;
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

    }
}
