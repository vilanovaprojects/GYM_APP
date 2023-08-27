namespace GYM_APP
{
    partial class frmPlaning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlaning));
            label1 = new Label();
            btnPDF = new Button();
            dataGridView1 = new DataGridView();
            Lunes = new DataGridViewTextBoxColumn();
            Martes = new DataGridViewTextBoxColumn();
            Miercoles = new DataGridViewTextBoxColumn();
            Jueves = new DataGridViewTextBoxColumn();
            Viernes = new DataGridViewTextBoxColumn();
            pbSinConexion = new PictureBox();
            lblSinConexion = new Label();
            timerParpadeo = new System.Windows.Forms.Timer(components);
            cbNombres = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSinConexion).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(300, 25);
            label1.Name = "label1";
            label1.Size = new Size(283, 22);
            label1.TabIndex = 0;
            label1.Text = "     Entrenamiento semanal     ";
            // 
            // btnPDF
            // 
            btnPDF.AccessibleRole = AccessibleRole.None;
            btnPDF.Location = new Point(387, 506);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(153, 30);
            btnPDF.TabIndex = 2;
            btnPDF.Text = "Guardar en PDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Lunes, Martes, Miercoles, Jueves, Viernes });
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
            dataGridView1.Location = new Point(99, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(718, 358);
            dataGridView1.TabIndex = 12;
            // 
            // Lunes
            // 
            Lunes.HeaderText = "Lunes";
            Lunes.Name = "Lunes";
            Lunes.ReadOnly = true;
            Lunes.Width = 140;
            // 
            // Martes
            // 
            Martes.HeaderText = "Martes";
            Martes.Name = "Martes";
            Martes.ReadOnly = true;
            Martes.Width = 140;
            // 
            // Miercoles
            // 
            Miercoles.HeaderText = "Miercoles";
            Miercoles.Name = "Miercoles";
            Miercoles.ReadOnly = true;
            Miercoles.Width = 140;
            // 
            // Jueves
            // 
            Jueves.HeaderText = "Jueves";
            Jueves.Name = "Jueves";
            Jueves.ReadOnly = true;
            Jueves.Width = 140;
            // 
            // Viernes
            // 
            Viernes.HeaderText = "Viernes";
            Viernes.Name = "Viernes";
            Viernes.ReadOnly = true;
            Viernes.Width = 140;
            // 
            // pbSinConexion
            // 
            pbSinConexion.Image = (Image)resources.GetObject("pbSinConexion.Image");
            pbSinConexion.Location = new Point(707, 514);
            pbSinConexion.Name = "pbSinConexion";
            pbSinConexion.Size = new Size(31, 27);
            pbSinConexion.SizeMode = PictureBoxSizeMode.Zoom;
            pbSinConexion.TabIndex = 14;
            pbSinConexion.TabStop = false;
            // 
            // lblSinConexion
            // 
            lblSinConexion.AutoSize = true;
            lblSinConexion.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSinConexion.Location = new Point(734, 518);
            lblSinConexion.Name = "lblSinConexion";
            lblSinConexion.Size = new Size(103, 18);
            lblSinConexion.TabIndex = 15;
            lblSinConexion.Text = "Sin conexión";
            // 
            // timerParpadeo
            // 
            timerParpadeo.Interval = 500;
            timerParpadeo.Tick += timerParpadeo_Tick;
            // 
            // cbNombres
            // 
            cbNombres.FormattingEnabled = true;
            cbNombres.Location = new Point(376, 93);
            cbNombres.Name = "cbNombres";
            cbNombres.Size = new Size(121, 23);
            cbNombres.TabIndex = 16;
            cbNombres.SelectedIndexChanged += cbNombres_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(347, 96);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 17;
            label2.Text = "de:";
            // 
            // frmPlaning
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(907, 568);
            Controls.Add(label2);
            Controls.Add(cbNombres);
            Controls.Add(lblSinConexion);
            Controls.Add(pbSinConexion);
            Controls.Add(dataGridView1);
            Controls.Add(btnPDF);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPlaning";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSinConexion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPDF;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Lunes;
        private DataGridViewTextBoxColumn Martes;
        private DataGridViewTextBoxColumn Miercoles;
        private DataGridViewTextBoxColumn Jueves;
        private DataGridViewTextBoxColumn Viernes;
        private PictureBox pbSinConexion;
        private Label lblSinConexion;
        private System.Windows.Forms.Timer timerParpadeo;
        private ComboBox cbNombres;
        private Label label2;
    }
}