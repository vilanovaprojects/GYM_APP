namespace GYM_APP
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label2 = new Label();
            label1 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            label3 = new Label();
            txtHost = new TextBox();
            label4 = new Label();
            txtDB = new TextBox();
            label5 = new Label();
            btnGuardar = new Button();
            panel1 = new Panel();
            lblConexion = new Label();
            lblDB = new Label();
            label11 = new Label();
            lblHost = new Label();
            label13 = new Label();
            lblUser = new Label();
            label6 = new Label();
            btnComprobarConexion = new Button();
            panel2 = new Panel();
            labelErrorConexion = new Label();
            btnBorrar = new Button();
            dgvNombres = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            btnCrear = new Button();
            label9 = new Label();
            label10 = new Label();
            txtContrasena = new TextBox();
            txtNombre = new TextBox();
            label7 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNombres).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(131, 67);
            label2.Name = "label2";
            label2.Size = new Size(231, 19);
            label2.TabIndex = 2;
            label2.Text = "Conexión con base de datos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 117);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 3;
            label1.Text = "User Id:";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(122, 114);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(257, 26);
            txtUser.TabIndex = 4;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(122, 151);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(257, 26);
            txtPass.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 154);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // txtHost
            // 
            txtHost.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtHost.Location = new Point(122, 191);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(257, 26);
            txtHost.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(70, 194);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 7;
            label4.Text = "Host:";
            // 
            // txtDB
            // 
            txtDB.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDB.Location = new Point(122, 233);
            txtDB.Name = "txtDB";
            txtDB.Size = new Size(257, 26);
            txtDB.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(29, 236);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 9;
            label5.Text = "Database:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(174, 287);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(143, 27);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblConexion);
            panel1.Controls.Add(lblDB);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(lblHost);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(32, 398);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 145);
            panel1.TabIndex = 12;
            // 
            // lblConexion
            // 
            lblConexion.AutoSize = true;
            lblConexion.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblConexion.Location = new Point(109, 98);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(0, 19);
            lblConexion.TabIndex = 8;
            // 
            // lblDB
            // 
            lblDB.AutoSize = true;
            lblDB.Location = new Point(142, 42);
            lblDB.Name = "lblDB";
            lblDB.Size = new Size(0, 15);
            lblDB.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(85, 42);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 6;
            label11.Text = "Database:";
            // 
            // lblHost
            // 
            lblHost.AutoSize = true;
            lblHost.Location = new Point(140, 69);
            lblHost.Name = "lblHost";
            lblHost.Size = new Size(0, 15);
            lblHost.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(106, 69);
            label13.Name = "label13";
            label13.Size = new Size(36, 15);
            label13.TabIndex = 4;
            label13.Text = "Host:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(142, 18);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(0, 15);
            lblUser.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(97, 18);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 0;
            label6.Text = "User id:";
            // 
            // btnComprobarConexion
            // 
            btnComprobarConexion.Location = new Point(155, 357);
            btnComprobarConexion.Name = "btnComprobarConexion";
            btnComprobarConexion.Size = new Size(176, 23);
            btnComprobarConexion.TabIndex = 13;
            btnComprobarConexion.Text = "Comprobar conexión";
            btnComprobarConexion.UseVisualStyleBackColor = true;
            btnComprobarConexion.Click += btnComprobarConexion_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MintCream;
            panel2.Controls.Add(labelErrorConexion);
            panel2.Controls.Add(btnBorrar);
            panel2.Controls.Add(dgvNombres);
            panel2.Controls.Add(btnCrear);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtContrasena);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(455, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(452, 568);
            panel2.TabIndex = 14;
            // 
            // labelErrorConexion
            // 
            labelErrorConexion.AutoSize = true;
            labelErrorConexion.Location = new Point(104, 293);
            labelErrorConexion.Name = "labelErrorConexion";
            labelErrorConexion.Size = new Size(0, 15);
            labelErrorConexion.TabIndex = 19;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(193, 504);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 17;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // dgvNombres
            // 
            dgvNombres.AllowUserToAddRows = false;
            dgvNombres.AllowUserToDeleteRows = false;
            dgvNombres.AllowUserToResizeRows = false;
            dgvNombres.BackgroundColor = SystemColors.ButtonHighlight;
            dgvNombres.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNombres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNombres.ColumnHeadersHeight = 30;
            dgvNombres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNombres.Columns.AddRange(new DataGridViewColumn[] { Nombre });
            dgvNombres.Location = new Point(148, 326);
            dgvNombres.MultiSelect = false;
            dgvNombres.Name = "dgvNombres";
            dgvNombres.ReadOnly = true;
            dgvNombres.RowHeadersVisible = false;
            dgvNombres.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvNombres.RowTemplate.Height = 25;
            dgvNombres.ScrollBars = ScrollBars.Vertical;
            dgvNombres.Size = new Size(167, 172);
            dgvNombres.TabIndex = 16;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Resizable = DataGridViewTriState.False;
            Nombre.Width = 160;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(157, 233);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(143, 27);
            btnCrear.TabIndex = 15;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(113, 136);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 11;
            label9.Text = "Nombre:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(86, 176);
            label10.Name = "label10";
            label10.Size = new Size(99, 20);
            label10.TabIndex = 13;
            label10.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasena.Location = new Point(191, 173);
            txtContrasena.MaxLength = 45;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(173, 26);
            txtContrasena.TabIndex = 14;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(191, 133);
            txtNombre.MaxLength = 45;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(173, 26);
            txtNombre.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(157, 67);
            label7.Name = "label7";
            label7.Size = new Size(120, 19);
            label7.TabIndex = 0;
            label7.Text = "Nuevo Usuario";
            // 
            // panel3
            // 
            panel3.BackColor = Color.MintCream;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(btnComprobarConexion);
            panel3.Controls.Add(txtHost);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtPass);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtDB);
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(txtUser);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(453, 568);
            panel3.TabIndex = 15;
            // 
            // frmOpciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(907, 568);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmOpciones";
            Text = "frmOpciones";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNombres).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
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