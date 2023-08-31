using System.Runtime.InteropServices;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Xml.Linq;
using Presentation.Properties;
using System.Resources;

namespace Presentation
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnOpciones = new System.Windows.Forms.Button();
            this.btnContacto = new System.Windows.Forms.Button();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnEjercicios = new System.Windows.Forms.Button();
            this.btnPlaning = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pcLogo = new System.Windows.Forms.PictureBox();
            this.panelApp = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).BeginInit();
            this.panelApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelMenu.Controls.Add(this.btnOpciones);
            this.panelMenu.Controls.Add(this.btnContacto);
            this.panelMenu.Controls.Add(this.btnAnadir);
            this.panelMenu.Controls.Add(this.btnEjercicios);
            this.panelMenu.Controls.Add(this.btnPlaning);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 32);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(173, 568);
            this.panelMenu.TabIndex = 0;
            // 
            // btnOpciones
            // 
            this.btnOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpciones.FlatAppearance.BorderSize = 0;
            this.btnOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpciones.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.btnOpciones.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnOpciones.Image = global::Presentation.Properties.Resources.opciones_30;
            this.btnOpciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpciones.Location = new System.Drawing.Point(0, 276);
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.Size = new System.Drawing.Size(173, 52);
            this.btnOpciones.TabIndex = 5;
            this.btnOpciones.Text = " Opciones";
            this.btnOpciones.UseVisualStyleBackColor = true;
            this.btnOpciones.Click += new System.EventHandler(this.btnOpciones_Click);
            // 
            // btnContacto
            // 
            this.btnContacto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnContacto.FlatAppearance.BorderSize = 0;
            this.btnContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContacto.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.btnContacto.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnContacto.Image = global::Presentation.Properties.Resources.email_30;
            this.btnContacto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContacto.Location = new System.Drawing.Point(0, 516);
            this.btnContacto.Name = "btnContacto";
            this.btnContacto.Size = new System.Drawing.Size(173, 52);
            this.btnContacto.TabIndex = 4;
            this.btnContacto.Text = " Contacto";
            this.btnContacto.UseVisualStyleBackColor = true;
            this.btnContacto.Click += new System.EventHandler(this.btnContacto_Click);
            // 
            // btnAnadir
            // 
            this.btnAnadir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnadir.FlatAppearance.BorderSize = 0;
            this.btnAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadir.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.btnAnadir.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnAnadir.Image = global::Presentation.Properties.Resources.añadir_30;
            this.btnAnadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnadir.Location = new System.Drawing.Point(0, 224);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(173, 52);
            this.btnAnadir.TabIndex = 3;
            this.btnAnadir.Text = "Añadir   ";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnEjercicios
            // 
            this.btnEjercicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEjercicios.FlatAppearance.BorderSize = 0;
            this.btnEjercicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjercicios.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.btnEjercicios.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnEjercicios.Image = global::Presentation.Properties.Resources.barra_con_pesas_30;
            this.btnEjercicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEjercicios.Location = new System.Drawing.Point(0, 172);
            this.btnEjercicios.Name = "btnEjercicios";
            this.btnEjercicios.Size = new System.Drawing.Size(173, 52);
            this.btnEjercicios.TabIndex = 2;
            this.btnEjercicios.Text = " Ejercicios";
            this.btnEjercicios.UseVisualStyleBackColor = true;
            this.btnEjercicios.Click += new System.EventHandler(this.btnEjercicios_Click);
            // 
            // btnPlaning
            // 
            this.btnPlaning.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaning.FlatAppearance.BorderSize = 0;
            this.btnPlaning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaning.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.btnPlaning.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnPlaning.Image = global::Presentation.Properties.Resources.plan_32;
            this.btnPlaning.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaning.Location = new System.Drawing.Point(0, 120);
            this.btnPlaning.Name = "btnPlaning";
            this.btnPlaning.Size = new System.Drawing.Size(173, 52);
            this.btnPlaning.TabIndex = 1;
            this.btnPlaning.Text = "Planing  ";
            this.btnPlaning.UseVisualStyleBackColor = true;
            this.btnPlaning.Click += new System.EventHandler(this.btnPlaning_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.pcLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(173, 120);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "_________________________________";
            // 
            // pcLogo
            // 
            this.pcLogo.BackColor = System.Drawing.Color.Transparent;
            this.pcLogo.Image = global::Presentation.Properties.Resources.logo_GYM_removebg;
            this.pcLogo.Location = new System.Drawing.Point(0, 0);
            this.pcLogo.Name = "pcLogo";
            this.pcLogo.Size = new System.Drawing.Size(173, 131);
            this.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcLogo.TabIndex = 0;
            this.pcLogo.TabStop = false;
            // 
            // panelApp
            // 
            this.panelApp.BackColor = System.Drawing.Color.MintCream;
            this.panelApp.Controls.Add(this.pictureBox7);
            this.panelApp.Controls.Add(this.label9);
            this.panelApp.Controls.Add(this.pictureBox6);
            this.panelApp.Controls.Add(this.label8);
            this.panelApp.Controls.Add(this.pictureBox5);
            this.panelApp.Controls.Add(this.label7);
            this.panelApp.Controls.Add(this.pictureBox4);
            this.panelApp.Controls.Add(this.label6);
            this.panelApp.Controls.Add(this.pictureBox3);
            this.panelApp.Controls.Add(this.label5);
            this.panelApp.Controls.Add(this.pictureBox2);
            this.panelApp.Controls.Add(this.label4);
            this.panelApp.Controls.Add(this.pictureBox1);
            this.panelApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelApp.Location = new System.Drawing.Point(173, 32);
            this.panelApp.Name = "panelApp";
            this.panelApp.Size = new System.Drawing.Size(907, 568);
            this.panelApp.TabIndex = 1;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Presentation.Properties.Resources.vilanovaprojectslogo_sin_fondo;
            this.pictureBox7.Location = new System.Drawing.Point(88, 69);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(651, 207);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(144, 473);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "Base de datos MySQL";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Presentation.Properties.Resources.mysql_100;
            this.pictureBox6.Location = new System.Drawing.Point(88, 459);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(517, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(313, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Seguridad AES en la conexión";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Presentation.Properties.Resources.aes_100;
            this.pictureBox5.Location = new System.Drawing.Point(461, 397);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(517, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(316, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Guardado de archivos en pdf";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Presentation.Properties.Resources.pdf_100;
            this.pictureBox4.Location = new System.Drawing.Point(461, 341);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(144, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Arquitectura en capas";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Presentation.Properties.Resources.esquema_100;
            this.pictureBox3.Location = new System.Drawing.Point(88, 397);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(517, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "XML para datos en local";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentation.Properties.Resources.xml_100;
            this.pictureBox2.Location = new System.Drawing.Point(461, 459);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Crea diferentes usuarios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation.Properties.Resources.usuarios_100;
            this.pictureBox1.Location = new System.Drawing.Point(88, 341);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.Teal;
            this.panelSuperior.Controls.Add(this.label3);
            this.panelSuperior.Controls.Add(this.btnMin);
            this.panelSuperior.Controls.Add(this.btnMax);
            this.panelSuperior.Controls.Add(this.btnCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1080, 32);
            this.panelSuperior.TabIndex = 0;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline);
            this.label3.Location = new System.Drawing.Point(477, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "VILANOVAPROJECTS";
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Teal;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::Presentation.Properties.Resources.min;
            this.btnMin.Location = new System.Drawing.Point(975, 1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(31, 31);
            this.btnMin.TabIndex = 2;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.Teal;
            this.btnMax.Enabled = false;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Image = global::Presentation.Properties.Resources.max;
            this.btnMax.Location = new System.Drawing.Point(1012, 1);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(31, 31);
            this.btnMax.TabIndex = 1;
            this.btnMax.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Teal;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::Presentation.Properties.Resources.close;
            this.btnCerrar.Location = new System.Drawing.Point(1049, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(31, 31);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 600);
            this.Controls.Add(this.panelApp);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VILANOVAPROJECTS";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).EndInit();
            this.panelApp.ResumeLayout(false);
            this.panelApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);

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
        private Panel panelSuperior;
        private Button btnCerrar;
        private Button btnMax;
        private Button btnMin;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label9;
        private PictureBox pictureBox6;
        private Label label8;
        private PictureBox pictureBox5;
        private Label label7;
        private PictureBox pictureBox4;
        private Label label6;
        private PictureBox pictureBox3;
        private Label label5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox7;
    }

}

