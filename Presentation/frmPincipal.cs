using GYM_APP;
using Presentation.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{

    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Importamos librería para la función de arrastrar
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private Form formActivo = null;

        private void abrirformhijo(Form formHijo)
        {
            if (formActivo != null)
                formActivo.Close();
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelApp.Controls.Add(formHijo);
            panelApp.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();

        }


        private void btnPlaning_Click(object sender, EventArgs e)
        {
            abrirformhijo(new frmPlaning());

        }

        private void btnEjercicios_Click(object sender, EventArgs e)
        {
            abrirformhijo(new frmEjercicios());

        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            abrirformhijo(new frmOpciones());
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            abrirformhijo(new frmContacto());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            abrirformhijo(new frmAdd());
        }


        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }

}
