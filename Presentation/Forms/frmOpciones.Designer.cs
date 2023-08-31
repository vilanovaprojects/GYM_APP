using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Forms
{
    partial class frmOpciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblConexion = new System.Windows.Forms.Label();
            this.lblDB = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnComprobarConexion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelErrorConexion = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dgvNombres = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNombres)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(131, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Conexión con base de datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.Location = new System.Drawing.Point(50, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Id:";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtUser.Location = new System.Drawing.Point(122, 114);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(257, 26);
            this.txtUser.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtPass.Location = new System.Drawing.Point(122, 151);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(257, 26);
            this.txtPass.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.Location = new System.Drawing.Point(33, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // txtHost
            // 
            this.txtHost.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtHost.Location = new System.Drawing.Point(122, 191);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(257, 26);
            this.txtHost.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label4.Location = new System.Drawing.Point(70, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Host:";
            // 
            // txtDB
            // 
            this.txtDB.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtDB.Location = new System.Drawing.Point(122, 233);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(257, 26);
            this.txtDB.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label5.Location = new System.Drawing.Point(29, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Database:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuardar.Location = new System.Drawing.Point(174, 287);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(143, 27);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblConexion);
            this.panel1.Controls.Add(this.lblDB);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblHost);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(32, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 145);
            this.panel1.TabIndex = 12;
            // 
            // lblConexion
            // 
            this.lblConexion.AutoSize = true;
            this.lblConexion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblConexion.Location = new System.Drawing.Point(109, 98);
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(0, 19);
            this.lblConexion.TabIndex = 8;
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Location = new System.Drawing.Point(142, 42);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(0, 13);
            this.lblDB.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(85, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Database:";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(140, 69);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(0, 13);
            this.lblHost.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(106, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 15);
            this.label13.TabIndex = 4;
            this.label13.Text = "Host:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(142, 18);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 13);
            this.lblUser.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(97, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "User id:";
            // 
            // btnComprobarConexion
            // 
            this.btnComprobarConexion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnComprobarConexion.Location = new System.Drawing.Point(155, 357);
            this.btnComprobarConexion.Name = "btnComprobarConexion";
            this.btnComprobarConexion.Size = new System.Drawing.Size(176, 23);
            this.btnComprobarConexion.TabIndex = 13;
            this.btnComprobarConexion.Text = "Comprobar conexión";
            this.btnComprobarConexion.UseVisualStyleBackColor = true;
            this.btnComprobarConexion.Click += new System.EventHandler(this.btnComprobarConexion_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.labelErrorConexion);
            this.panel2.Controls.Add(this.btnBorrar);
            this.panel2.Controls.Add(this.dgvNombres);
            this.panel2.Controls.Add(this.btnCrear);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtContrasena);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(455, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 568);
            this.panel2.TabIndex = 14;
            // 
            // labelErrorConexion
            // 
            this.labelErrorConexion.AutoSize = true;
            this.labelErrorConexion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelErrorConexion.Location = new System.Drawing.Point(104, 293);
            this.labelErrorConexion.Name = "labelErrorConexion";
            this.labelErrorConexion.Size = new System.Drawing.Size(0, 15);
            this.labelErrorConexion.TabIndex = 19;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBorrar.Location = new System.Drawing.Point(193, 504);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 17;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // dgvNombres
            // 
            this.dgvNombres.AllowUserToAddRows = false;
            this.dgvNombres.AllowUserToDeleteRows = false;
            this.dgvNombres.AllowUserToResizeRows = false;
            this.dgvNombres.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNombres.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNombres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNombres.ColumnHeadersHeight = 30;
            this.dgvNombres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNombres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.dgvNombres.Location = new System.Drawing.Point(148, 326);
            this.dgvNombres.MultiSelect = false;
            this.dgvNombres.Name = "dgvNombres";
            this.dgvNombres.ReadOnly = true;
            this.dgvNombres.RowHeadersVisible = false;
            this.dgvNombres.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvNombres.RowTemplate.Height = 25;
            this.dgvNombres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvNombres.Size = new System.Drawing.Size(167, 172);
            this.dgvNombres.TabIndex = 16;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 160;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCrear.Location = new System.Drawing.Point(157, 233);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(143, 27);
            this.btnCrear.TabIndex = 15;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label9.Location = new System.Drawing.Point(113, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label10.Location = new System.Drawing.Point(86, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtContrasena.Location = new System.Drawing.Point(191, 173);
            this.txtContrasena.MaxLength = 45;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(173, 26);
            this.txtContrasena.TabIndex = 14;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtNombre.Location = new System.Drawing.Point(191, 133);
            this.txtNombre.MaxLength = 45;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(173, 26);
            this.txtNombre.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(157, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nuevo Usuario";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MintCream;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnComprobarConexion);
            this.panel3.Controls.Add(this.txtHost);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtPass);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtDB);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.txtUser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(453, 568);
            this.panel3.TabIndex = 15;
            // 
            // frmOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(907, 568);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOpciones";
            this.Text = "frmOpciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNombres)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label label3;
        private TextBox txtHost;
        private Label label4;
        private TextBox txtDB;
        private Label label5;
        private Button btnGuardar;
        private Panel panel1;
        private Label lblDB;
        private Label label11;
        private Label lblHost;
        private Label label13;
        private Label lblUser;
        private Label label6;
        private Label lblConexion;
        private Button btnComprobarConexion;
        private Panel panel2;
        private Panel panel3;
        private Label label9;
        private Label label10;
        private TextBox txtContrasena;
        private TextBox txtNombre;
        private Label label7;
        private Button btnCrear;
        private DataGridView dgvNombres;
        private DataGridViewTextBoxColumn Nombre;
        private Label labelErrorConexion;
        private Button btnBorrar;
    }
}