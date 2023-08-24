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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(342, 100);
            label2.Name = "label2";
            label2.Size = new Size(231, 19);
            label2.TabIndex = 2;
            label2.Text = "Conexión con base de datos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(261, 150);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 3;
            label1.Text = "User Id:";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(333, 147);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(257, 26);
            txtUser.TabIndex = 4;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(333, 184);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(257, 26);
            txtPass.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(244, 187);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // txtHost
            // 
            txtHost.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtHost.Location = new Point(333, 224);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(257, 26);
            txtHost.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(281, 227);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 7;
            label4.Text = "Host:";
            // 
            // txtDB
            // 
            txtDB.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDB.Location = new Point(333, 266);
            txtDB.Name = "txtDB";
            txtDB.Size = new Size(257, 26);
            txtDB.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(240, 269);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 9;
            label5.Text = "Database:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(385, 320);
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
            panel1.Location = new Point(122, 406);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 109);
            panel1.TabIndex = 12;
            // 
            // lblConexion
            // 
            lblConexion.AutoSize = true;
            lblConexion.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblConexion.Location = new Point(237, 78);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(0, 19);
            lblConexion.TabIndex = 8;
            // 
            // lblDB
            // 
            lblDB.AutoSize = true;
            lblDB.Location = new Point(351, 35);
            lblDB.Name = "lblDB";
            lblDB.Size = new Size(0, 15);
            lblDB.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(294, 35);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 6;
            label11.Text = "Database:";
            // 
            // lblHost
            // 
            lblHost.AutoSize = true;
            lblHost.Location = new Point(483, 35);
            lblHost.Name = "lblHost";
            lblHost.Size = new Size(0, 15);
            lblHost.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(449, 35);
            label13.Name = "label13";
            label13.Size = new Size(36, 15);
            label13.TabIndex = 4;
            label13.Text = "Host:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(201, 35);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(0, 15);
            lblUser.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(156, 35);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 0;
            label6.Text = "User id:";
            // 
            // btnComprobarConexion
            // 
            btnComprobarConexion.Location = new Point(367, 377);
            btnComprobarConexion.Name = "btnComprobarConexion";
            btnComprobarConexion.Size = new Size(176, 23);
            btnComprobarConexion.TabIndex = 13;
            btnComprobarConexion.Text = "Comprobar conexión";
            btnComprobarConexion.UseVisualStyleBackColor = true;
            btnComprobarConexion.Click += btnComprobarConexion_Click;
            // 
            // frmOpciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(907, 568);
            Controls.Add(btnComprobarConexion);
            Controls.Add(panel1);
            Controls.Add(btnGuardar);
            Controls.Add(txtDB);
            Controls.Add(label5);
            Controls.Add(txtHost);
            Controls.Add(label4);
            Controls.Add(txtPass);
            Controls.Add(label3);
            Controls.Add(txtUser);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmOpciones";
            Text = "frmOpciones";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}