namespace GYM_APP
{
    partial class frmEjercicios
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEjercicios));
            btnLunes = new Button();
            btnMartes = new Button();
            btnMiercoles = new Button();
            btnJueves = new Button();
            btnViernes = new Button();
            btnCrarPrograma = new Button();
            informacion = new Label();
            dataGridView1 = new DataGridView();
            lblSinConexion = new Label();
            pbSinConexion = new PictureBox();
            timerParpadeo = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSinConexion).BeginInit();
            SuspendLayout();
            // 
            // btnLunes
            // 
            btnLunes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLunes.ForeColor = Color.DodgerBlue;
            btnLunes.Location = new Point(94, 34);
            btnLunes.Name = "btnLunes";
            btnLunes.Size = new Size(138, 30);
            btnLunes.TabIndex = 3;
            btnLunes.Text = "Lunes";
            btnLunes.UseVisualStyleBackColor = true;
            btnLunes.Click += btnLunes_Click;
            // 
            // btnMartes
            // 
            btnMartes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMartes.ForeColor = Color.DodgerBlue;
            btnMartes.Location = new Point(238, 34);
            btnMartes.Name = "btnMartes";
            btnMartes.Size = new Size(138, 30);
            btnMartes.TabIndex = 4;
            btnMartes.Text = "Martes";
            btnMartes.UseVisualStyleBackColor = true;
            btnMartes.Click += btnMartes_Click;
            // 
            // btnMiercoles
            // 
            btnMiercoles.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMiercoles.ForeColor = Color.DodgerBlue;
            btnMiercoles.Location = new Point(382, 34);
            btnMiercoles.Name = "btnMiercoles";
            btnMiercoles.Size = new Size(138, 30);
            btnMiercoles.TabIndex = 5;
            btnMiercoles.Text = "Miercoles";
            btnMiercoles.UseVisualStyleBackColor = true;
            btnMiercoles.Click += btnMiercoles_Click;
            // 
            // btnJueves
            // 
            btnJueves.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnJueves.ForeColor = Color.DodgerBlue;
            btnJueves.Location = new Point(526, 34);
            btnJueves.Name = "btnJueves";
            btnJueves.Size = new Size(138, 30);
            btnJueves.TabIndex = 6;
            btnJueves.Text = "Jueves";
            btnJueves.UseVisualStyleBackColor = true;
            btnJueves.Click += btnJueves_Click;
            // 
            // btnViernes
            // 
            btnViernes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnViernes.ForeColor = Color.DodgerBlue;
            btnViernes.Location = new Point(670, 34);
            btnViernes.Name = "btnViernes";
            btnViernes.Size = new Size(138, 30);
            btnViernes.TabIndex = 7;
            btnViernes.Text = "Viernes";
            btnViernes.UseVisualStyleBackColor = true;
            btnViernes.Click += btnViernes_Click;
            // 
            // btnCrarPrograma
            // 
            btnCrarPrograma.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrarPrograma.Location = new Point(382, 486);
            btnCrarPrograma.Name = "btnCrarPrograma";
            btnCrarPrograma.Size = new Size(153, 30);
            btnCrarPrograma.TabIndex = 8;
            btnCrarPrograma.Text = "Crear Programa";
            btnCrarPrograma.UseVisualStyleBackColor = true;
            btnCrarPrograma.Click += button5_Click;
            // 
            // informacion
            // 
            informacion.AutoSize = true;
            informacion.Location = new Point(105, 77);
            informacion.Name = "informacion";
            informacion.Size = new Size(0, 15);
            informacion.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(94, 105);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(718, 358);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // lblSinConexion
            // 
            lblSinConexion.AutoSize = true;
            lblSinConexion.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSinConexion.Location = new Point(729, 498);
            lblSinConexion.Name = "lblSinConexion";
            lblSinConexion.Size = new Size(103, 18);
            lblSinConexion.TabIndex = 17;
            lblSinConexion.Text = "Sin conexión";
            // 
            // pbSinConexion
            // 
            pbSinConexion.Image = (Image)resources.GetObject("pbSinConexion.Image");
            pbSinConexion.Location = new Point(702, 494);
            pbSinConexion.Name = "pbSinConexion";
            pbSinConexion.Size = new Size(31, 27);
            pbSinConexion.SizeMode = PictureBoxSizeMode.Zoom;
            pbSinConexion.TabIndex = 16;
            pbSinConexion.TabStop = false;
            // 
            // timerParpadeo
            // 
            timerParpadeo.Interval = 500;
            timerParpadeo.Tick += timerSinConexion_Tick;
            // 
            // frmEjercicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(907, 568);
            Controls.Add(lblSinConexion);
            Controls.Add(pbSinConexion);
            Controls.Add(dataGridView1);
            Controls.Add(informacion);
            Controls.Add(btnCrarPrograma);
            Controls.Add(btnViernes);
            Controls.Add(btnJueves);
            Controls.Add(btnMiercoles);
            Controls.Add(btnMartes);
            Controls.Add(btnLunes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEjercicios";
            Text = "Ejercicios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSinConexion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLunes;
        private Button btnMartes;
        private Button btnMiercoles;
        private Button btnJueves;
        private Button btnViernes;
        private Button btnCrarPrograma;
        private Label informacion;
        private DataGridView dataGridView1;
        private Label lblSinConexion;
        private PictureBox pbSinConexion;
        private System.Windows.Forms.Timer timerParpadeo;
    }
}