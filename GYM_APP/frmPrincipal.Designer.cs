namespace GYM_APP
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            panelMenu = new Panel();
            btnOpciones = new Button();
            btnContacto = new Button();
            btnAnadir = new Button();
            btnEjercicios = new Button();
            btnPlaning = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            pcLogo = new PictureBox();
            panelApp = new Panel();
            label2 = new Label();
            panelSuperior = new Panel();
            label3 = new Label();
            btnMin = new Button();
            btnMax = new Button();
            btnCerrar = new Button();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcLogo).BeginInit();
            panelApp.SuspendLayout();
            panelSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.PaleTurquoise;
            panelMenu.Controls.Add(btnOpciones);
            panelMenu.Controls.Add(btnContacto);
            panelMenu.Controls.Add(btnAnadir);
            panelMenu.Controls.Add(btnEjercicios);
            panelMenu.Controls.Add(btnPlaning);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 32);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(173, 568);
            panelMenu.TabIndex = 0;
            // 
            // btnOpciones
            // 
            btnOpciones.Dock = DockStyle.Top;
            btnOpciones.FlatAppearance.BorderSize = 0;
            btnOpciones.FlatStyle = FlatStyle.Flat;
            btnOpciones.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpciones.ForeColor = SystemColors.GrayText;
            btnOpciones.Image = Properties.Resources.opciones_30;
            btnOpciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpciones.Location = new Point(0, 276);
            btnOpciones.Name = "btnOpciones";
            btnOpciones.Size = new Size(173, 52);
            btnOpciones.TabIndex = 5;
            btnOpciones.Text = "Opciones";
            btnOpciones.UseVisualStyleBackColor = true;
            btnOpciones.Click += btnOpciones_Click;
            // 
            // btnContacto
            // 
            btnContacto.Dock = DockStyle.Bottom;
            btnContacto.FlatAppearance.BorderSize = 0;
            btnContacto.FlatStyle = FlatStyle.Flat;
            btnContacto.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnContacto.ForeColor = SystemColors.GrayText;
            btnContacto.Image = Properties.Resources.email_30;
            btnContacto.ImageAlign = ContentAlignment.MiddleLeft;
            btnContacto.Location = new Point(0, 516);
            btnContacto.Name = "btnContacto";
            btnContacto.Size = new Size(173, 52);
            btnContacto.TabIndex = 4;
            btnContacto.Text = "Contacto";
            btnContacto.UseVisualStyleBackColor = true;
            btnContacto.Click += btnContacto_Click;
            // 
            // btnAnadir
            // 
            btnAnadir.Dock = DockStyle.Top;
            btnAnadir.FlatAppearance.BorderSize = 0;
            btnAnadir.FlatStyle = FlatStyle.Flat;
            btnAnadir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnadir.ForeColor = SystemColors.GrayText;
            btnAnadir.Image = Properties.Resources.añadir_30;
            btnAnadir.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnadir.Location = new Point(0, 224);
            btnAnadir.Name = "btnAnadir";
            btnAnadir.Size = new Size(173, 52);
            btnAnadir.TabIndex = 3;
            btnAnadir.Text = "Añadir";
            btnAnadir.UseVisualStyleBackColor = true;
            btnAnadir.Click += btnAnadir_Click;
            // 
            // btnEjercicios
            // 
            btnEjercicios.Dock = DockStyle.Top;
            btnEjercicios.FlatAppearance.BorderSize = 0;
            btnEjercicios.FlatStyle = FlatStyle.Flat;
            btnEjercicios.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEjercicios.ForeColor = SystemColors.GrayText;
            btnEjercicios.Image = Properties.Resources.barra_con_pesas_30;
            btnEjercicios.ImageAlign = ContentAlignment.MiddleLeft;
            btnEjercicios.Location = new Point(0, 172);
            btnEjercicios.Name = "btnEjercicios";
            btnEjercicios.Size = new Size(173, 52);
            btnEjercicios.TabIndex = 2;
            btnEjercicios.Text = "Ejercicios";
            btnEjercicios.UseVisualStyleBackColor = true;
            btnEjercicios.Click += btnEjercicios_Click;
            // 
            // btnPlaning
            // 
            btnPlaning.Dock = DockStyle.Top;
            btnPlaning.FlatAppearance.BorderSize = 0;
            btnPlaning.FlatStyle = FlatStyle.Flat;
            btnPlaning.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlaning.ForeColor = SystemColors.GrayText;
            btnPlaning.Image = Properties.Resources.plan_32;
            btnPlaning.ImageAlign = ContentAlignment.MiddleLeft;
            btnPlaning.Location = new Point(0, 120);
            btnPlaning.Name = "btnPlaning";
            btnPlaning.Size = new Size(173, 52);
            btnPlaning.TabIndex = 1;
            btnPlaning.Text = "Planing";
            btnPlaning.UseVisualStyleBackColor = true;
            btnPlaning.Click += btnPlaning_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(label1);
            panelLogo.Controls.Add(pcLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(173, 120);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 105);
            label1.Name = "label1";
            label1.Size = new Size(172, 15);
            label1.TabIndex = 1;
            label1.Text = "_________________________________";
            // 
            // pcLogo
            // 
            pcLogo.BackColor = Color.Transparent;
            pcLogo.Image = Properties.Resources.logo_GYM_removebg;
            pcLogo.Location = new Point(0, 0);
            pcLogo.Name = "pcLogo";
            pcLogo.Size = new Size(173, 131);
            pcLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pcLogo.TabIndex = 0;
            pcLogo.TabStop = false;
            // 
            // panelApp
            // 
            panelApp.BackColor = Color.MintCream;
            panelApp.Controls.Add(label2);
            panelApp.Dock = DockStyle.Fill;
            panelApp.Location = new Point(173, 32);
            panelApp.Name = "panelApp";
            panelApp.Size = new Size(907, 568);
            panelApp.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkTurquoise;
            label2.Location = new Point(314, 206);
            label2.Name = "label2";
            label2.Size = new Size(195, 47);
            label2.TabIndex = 0;
            label2.Text = "Bienbenido";
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.Teal;
            panelSuperior.Controls.Add(label3);
            panelSuperior.Controls.Add(btnMin);
            panelSuperior.Controls.Add(btnMax);
            panelSuperior.Controls.Add(btnCerrar);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1080, 32);
            panelSuperior.TabIndex = 0;
            panelSuperior.MouseDown += panelSuperior_MouseDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(477, 4);
            label3.Name = "label3";
            label3.Size = new Size(175, 21);
            label3.TabIndex = 3;
            label3.Text = "VILANOVAPROJECTS";
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.Teal;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Image = (Image)resources.GetObject("btnMin.Image");
            btnMin.Location = new Point(975, 1);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(31, 31);
            btnMin.TabIndex = 2;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnMax
            // 
            btnMax.BackColor = Color.Teal;
            btnMax.Enabled = false;
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.Image = (Image)resources.GetObject("btnMax.Image");
            btnMax.Location = new Point(1012, 1);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(31, 31);
            btnMax.TabIndex = 1;
            btnMax.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Teal;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1049, 1);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(31, 31);
            btnCerrar.TabIndex = 0;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 600);
            Controls.Add(panelApp);
            Controls.Add(panelMenu);
            Controls.Add(panelSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VILANOVAPROJECTS";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcLogo).EndInit();
            panelApp.ResumeLayout(false);
            panelApp.PerformLayout();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private PictureBox pcLogo;
        private Label label1;
        private Button btnPlaning;
        private Button btnContacto;
        private Button btnAnadir;
        private Button btnEjercicios;
        private Button btnOpciones;
        private Panel panelApp;
        private Label label2;
        private Panel panelSuperior;
        private Button btnCerrar;
        private Button btnMax;
        private Button btnMin;
        private Label label3;
    }
}