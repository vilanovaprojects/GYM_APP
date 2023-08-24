namespace GYM_APP
{
    partial class frmAdd
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            txtNombre = new TextBox();
            txtTipo = new TextBox();
            label2 = new Label();
            txtComentarios = new TextBox();
            label3 = new Label();
            btnCargarImagen = new Button();
            pbImagen = new PictureBox();
            btnBorrarImagen = new Button();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            btnAnadirEjercicio = new Button();
            panel2 = new Panel();
            btnActualizar = new Button();
            labelError = new Label();
            btnBorrarEjercicio = new Button();
            dgvBorradoDatos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorradoDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 138);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre de ejercicio:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.Window;
            txtNombre.Location = new Point(197, 135);
            txtNombre.MaxLength = 45;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(216, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(197, 179);
            txtTipo.MaxLength = 45;
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(216, 23);
            txtTipo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 182);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "Tipo:";
            // 
            // txtComentarios
            // 
            txtComentarios.Location = new Point(197, 224);
            txtComentarios.MaxLength = 255;
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(216, 23);
            txtComentarios.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 227);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 4;
            label3.Text = "Comentarios:";
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.Location = new Point(197, 443);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(99, 23);
            btnCargarImagen.TabIndex = 6;
            btnCargarImagen.Text = "Cargar Imagen";
            btnCargarImagen.UseVisualStyleBackColor = true;
            btnCargarImagen.Click += btnCargarImagen_Click;
            // 
            // pbImagen
            // 
            pbImagen.BackColor = SystemColors.ButtonHighlight;
            pbImagen.BorderStyle = BorderStyle.FixedSingle;
            pbImagen.Location = new Point(197, 267);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(216, 170);
            pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pbImagen.TabIndex = 7;
            pbImagen.TabStop = false;
            // 
            // btnBorrarImagen
            // 
            btnBorrarImagen.Location = new Point(314, 443);
            btnBorrarImagen.Name = "btnBorrarImagen";
            btnBorrarImagen.Size = new Size(99, 23);
            btnBorrarImagen.TabIndex = 8;
            btnBorrarImagen.Text = "Borrar Imagen";
            btnBorrarImagen.UseVisualStyleBackColor = true;
            btnBorrarImagen.Click += btnBorrarImagen_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 337);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 9;
            label4.Text = "Imagen:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(138, 79);
            label5.Name = "label5";
            label5.Size = new Size(158, 23);
            label5.TabIndex = 10;
            label5.Text = "Añadir ejercicio";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MintCream;
            panel1.Controls.Add(btnAnadirEjercicio);
            panel1.Controls.Add(pbImagen);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(btnBorrarImagen);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTipo);
            panel1.Controls.Add(btnCargarImagen);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtComentarios);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 568);
            panel1.TabIndex = 11;
            // 
            // btnAnadirEjercicio
            // 
            btnAnadirEjercicio.Location = new Point(138, 499);
            btnAnadirEjercicio.Name = "btnAnadirEjercicio";
            btnAnadirEjercicio.Size = new Size(155, 23);
            btnAnadirEjercicio.TabIndex = 11;
            btnAnadirEjercicio.Text = "Añadir ejercicio";
            btnAnadirEjercicio.UseVisualStyleBackColor = true;
            btnAnadirEjercicio.Click += btnAnadirEjercicio_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MintCream;
            panel2.Controls.Add(btnActualizar);
            panel2.Controls.Add(labelError);
            panel2.Controls.Add(btnBorrarEjercicio);
            panel2.Controls.Add(dgvBorradoDatos);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(455, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(452, 568);
            panel2.TabIndex = 12;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(176, 443);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 15;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(43, 117);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 15);
            labelError.TabIndex = 14;
            // 
            // btnBorrarEjercicio
            // 
            btnBorrarEjercicio.Location = new Point(320, 280);
            btnBorrarEjercicio.Name = "btnBorrarEjercicio";
            btnBorrarEjercicio.Size = new Size(75, 23);
            btnBorrarEjercicio.TabIndex = 13;
            btnBorrarEjercicio.Text = "Borrar";
            btnBorrarEjercicio.UseVisualStyleBackColor = true;
            btnBorrarEjercicio.Click += btnBorrarEjercicio_Click;
            // 
            // dgvBorradoDatos
            // 
            dgvBorradoDatos.AllowUserToAddRows = false;
            dgvBorradoDatos.AllowUserToDeleteRows = false;
            dgvBorradoDatos.AllowUserToResizeRows = false;
            dgvBorradoDatos.BackgroundColor = SystemColors.ButtonHighlight;
            dgvBorradoDatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBorradoDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBorradoDatos.ColumnHeadersHeight = 30;
            dgvBorradoDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBorradoDatos.Columns.AddRange(new DataGridViewColumn[] { Nombre });
            dgvBorradoDatos.Location = new Point(130, 157);
            dgvBorradoDatos.Name = "dgvBorradoDatos";
            dgvBorradoDatos.ReadOnly = true;
            dgvBorradoDatos.RowHeadersVisible = false;
            dgvBorradoDatos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvBorradoDatos.RowTemplate.Height = 25;
            dgvBorradoDatos.ScrollBars = ScrollBars.Vertical;
            dgvBorradoDatos.Size = new Size(167, 280);
            dgvBorradoDatos.TabIndex = 12;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Resizable = DataGridViewTriState.False;
            Nombre.Width = 160;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(147, 79);
            label6.Name = "label6";
            label6.Size = new Size(150, 23);
            label6.TabIndex = 11;
            label6.Text = "Borrar ejercicio";
            // 
            // frmAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(907, 568);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdd";
            Text = "frmAdd";
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorradoDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtTipo;
        private Label label2;
        private TextBox txtComentarios;
        private Label label3;
        private Button btnCargarImagen;
        private PictureBox pbImagen;
        private Button btnBorrarImagen;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private Label label6;
        private DataGridView dgvBorradoDatos;
        private Button btnBorrarEjercicio;
        private DataGridViewTextBoxColumn Nombre;
        private Button btnAnadirEjercicio;
        private Label labelError;
        private Button btnActualizar;
    }
}