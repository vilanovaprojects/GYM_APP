namespace GYM_APP
{
    partial class Form1
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
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcLogo).BeginInit();
            panelApp.SuspendLayout();
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
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(173, 450);
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
            btnContacto.Location = new Point(0, 398);
            btnContacto.Name = "btnContacto";
            btnContacto.Size = new Size(173, 52);
            btnContacto.TabIndex = 4;
            btnContacto.Text = "Contacto";
            btnContacto.UseVisualStyleBackColor = true;
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
            panelApp.BackColor = SystemColors.ControlLight;
            panelApp.Controls.Add(label2);
            panelApp.Dock = DockStyle.Fill;
            panelApp.Location = new Point(173, 0);
            panelApp.Name = "panelApp";
            panelApp.Size = new Size(627, 450);
            panelApp.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkTurquoise;
            label2.Location = new Point(198, 157);
            label2.Name = "label2";
            label2.Size = new Size(195, 47);
            label2.TabIndex = 0;
            label2.Text = "Bienbenido";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelApp);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VILANOVAPROJECTS";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcLogo).EndInit();
            panelApp.ResumeLayout(false);
            panelApp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Panel panelApp;
        private PictureBox pcLogo;
        private Label label1;
        private Button btnPlaning;
        private Button btnContacto;
        private Button btnAnadir;
        private Button btnEjercicios;
        private Button btnOpciones;
        private Label label2;
    }
}