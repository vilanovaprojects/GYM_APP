namespace GYM_APP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmPrincipal());
        }

    }

    public class Registros
    {
        string nombre;
        string tipo;
        string? comentarios;
        byte[]? imagen;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Comentarios
        {
            get { return comentarios; }
            set { comentarios = value; }
        }

        public byte[] Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

    }

    public class Planing
    {
        string ejercicio;
        string repes;
        string? comentarios;

        public string Ejercicio { get; set; }
        public string Repes { get; set; }
        public string Comentarios { get; set; }


    }

    public class Planing2
    {
        string dia;
        string ejercicio;
        string repes;
        string? comentarios;
        byte[]? imagen;

        public string Dia { get; set; }
        public string Ejercicio { get; set; }
        public string Repes { get; set; }
        public string Comentarios { get; set; }
        public byte[] Imagen { get; set; }


    }
}