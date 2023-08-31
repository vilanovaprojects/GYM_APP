using Domain.Clases;
using System;
using System.Windows.Forms;

namespace GYM_APP
{
    public partial class frmContacto : Form
    {
        public frmContacto()
        {
            InitializeComponent();

        }
        private void Prueba1()
        {
            string conexion = "Server=83.34.135.50;Database=gym_app;Uid=GYM-Admin;Pwd=aksfhf7h4;";

            try
            {
                XML objeto = new XML();

                objeto.SavetoXML(conexion);

                lblPrueba1.Text = "En principio se ha guardado";
            }
            catch (Exception ex)
            {
                lblPrueba1.Text = "Ha ocurrido un error.";
            }

        }
        private void Prueba2()
        {
            try
            {
                XML objeto = new XML();
                string conexion = objeto.ReadfromXML();

                lblPrueba1.Text = conexion;
            }
            catch (Exception ex)
            {
                lblPrueba1.Text = "Ha ocurrido un error.";
            }

        }

        private void btnPrueba1_Click(object sender, EventArgs e)
        {
            Prueba1();
        }

        private void btnPrueba2_Click(object sender, EventArgs e)
        {
            Prueba2();
        }
    }
}
