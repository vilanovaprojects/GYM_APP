using DataAccess;
using Domain.Clases;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class MainModel
    {
        private List<Planing> listaLunes = new List<Planing>();
        private List<Planing> listaMartes = new List<Planing>();
        private List<Planing> listaMiercoles = new List<Planing>();
        private List<Planing> listaJueves = new List<Planing>();
        private List<Planing> listaViernes = new List<Planing>();
        private List<Planing> listaTotal = new List<Planing>();


        private List<Registros> registros = new List<Registros>();
        private List<string> columnas = new List<string>();

        public MainModel()
        {
            string conexion;
            XML getconnection = new XML();
            conexion = getconnection.ReadfromXML();

            Querys Query = new Querys(conexion);

            using (var lector = Query.leerTodosLosEjercicios())
            {
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        registros.Add(new Registros
                        {
                            Nombre = lector.GetString(0),
                            Tipo = lector.GetString(1),
                            Comentarios = lector.IsDBNull(2) ? "" : lector.GetString(2),
                            Imagen = lector.IsDBNull(3) ? null : (byte[])lector.GetValue(3),
                        });

                        // Agrega el tipo a la lista 'columnas' si aún no existe
                        string tipo = lector.GetString(1);
                        if (!columnas.Contains(tipo))
                        {
                            columnas.Add(tipo);
                        }
                    }
                }
                lector.Close();
            }

        }

        public List<Registros> ObtenerRegistros()
        {
            return registros;
        }
        public List<string> ObtenerColumnas()
        {
            return columnas;
        }

        public List<Planing> planLunes()
        {
            return listaLunes;
        }
        public void BorrarPlanLunes()
        {
            listaLunes.Clear();
        }
        public int LunesCount()
        {
            return listaLunes.Count;
        }
        public void LunesAdd(Planing dato)
        {
            listaLunes.Add(dato);
        }

        public List<Planing> planMartes()
        {
            return listaMartes;
        }
        public void BorrarPlanMartes()
        {
            listaMartes.Clear();
        }
        public int MartesCount()
        {
            return listaMartes.Count;
        }
        public void MartesAdd(Planing dato)
        {
            listaMartes.Add(dato);
        }

        public List<Planing> planMiercoles()
        {
            return listaMiercoles;
        }
        public void BorrarPlanMiercoles()
        {
            listaMiercoles.Clear();
        }
        public int MiercolesCount()
        {
            return listaMiercoles.Count;
        }
        public void MiercolesAdd(Planing dato)
        {
            listaMiercoles.Add(dato);
        }

        public List<Planing> planJueves()
        {
            return listaJueves;
        }
        public void BorrarPlanJueves()
        {
            listaJueves.Clear();
        }
        public int JuevesCount()
        {
            return listaJueves.Count;
        }
        public void JuevesAdd(Planing dato)
        {
            listaJueves.Add(dato);
        }

        public List<Planing> planViernes()
        {
            return listaViernes;
        }
        public void BorrarPlanViernes()
        {
            listaViernes.Clear();
        }
        public int ViernesCount()
        {
            return listaViernes.Count;
        }
        public void ViernesAdd(Planing dato)
        {
            listaViernes.Add(dato);
        }

        public void GenerarRutina(string nombre)
        {
            listaTotal.Clear();

            listaTotal.AddRange(listaLunes);
            listaTotal.AddRange(listaMartes);
            listaTotal.AddRange(listaMiercoles);
            listaTotal.AddRange(listaJueves);
            listaTotal.AddRange(listaViernes);

            foreach (var item in listaTotal)
            {
                item.Usuario = nombre;
            }

            string conexion;
            XML getconnection = new XML();
            conexion = getconnection.ReadfromXML();

            Querys Query = new Querys(conexion);
            Query.BorrarPlanUsuario(nombre);

            MySqlCommand command = Query.CreaPlanUsuario();

            foreach (Planing dato in listaTotal)
            {
                command.Parameters["@usuario"].Value = nombre;
                command.Parameters["@dia"].Value = dato.Dia;
                command.Parameters["@ejercicio"].Value = dato.Ejercicio;
                command.Parameters["@repes"].Value = dato.Repes;
                command.ExecuteNonQuery();
            }
            command.Dispose();
            



        }

        public List<string> ListaDeUsuarios()
        {
            string conexion;
            XML getconnection = new XML();
            conexion = getconnection.ReadfromXML();
            Querys Query = new Querys(conexion);

            List<string> lista = Query.ListaDeUsuarios();

            return lista;

        }

        
    }



}
