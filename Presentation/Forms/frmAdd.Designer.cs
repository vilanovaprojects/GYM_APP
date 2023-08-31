using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnBorrarImagen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnadirEjercicio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.btnBorrarEjercicio = new System.Windows.Forms.Button();
            this.dgvBorradoDatos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorradoDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(74, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de ejercicio:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.Location = new System.Drawing.Point(197, 135);
            this.txtNombre.MaxLength = 45;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(216, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTipo.Location = new System.Drawing.Point(197, 179);
            this.txtTipo.MaxLength = 45;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(216, 23);
            this.txtTipo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(148, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo:";
            // 
            // txtComentarios
            // 
            this.txtComentarios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtComentarios.Location = new System.Drawing.Point(197, 224);
            this.txtComentarios.MaxLength = 255;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(216, 23);
            this.txtComentarios.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(113, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Comentarios:";
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCargarImagen.Location = new System.Drawing.Point(197, 443);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(99, 23);
            this.btnCargarImagen.TabIndex = 6;
            this.btnCargarImagen.Text = "Cargar Imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.Location = new System.Drawing.Point(197, 267);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(216, 170);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 7;
            this.pbImagen.TabStop = false;
            // 
            // btnBorrarImagen
            // 
            this.btnBorrarImagen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBorrarImagen.Location = new System.Drawing.Point(314, 443);
            this.btnBorrarImagen.Name = "btnBorrarImagen";
            this.btnBorrarImagen.Size = new System.Drawing.Size(99, 23);
            this.btnBorrarImagen.TabIndex = 8;
            this.btnBorrarImagen.Text = "Borrar Imagen";
            this.btnBorrarImagen.UseVisualStyleBackColor = true;
            this.btnBorrarImagen.Click += new System.EventHandler(this.btnBorrarImagen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(141, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Imagen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(138, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Añadir ejercicio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.btnAnadirEjercicio);
            this.panel1.Controls.Add(this.pbImagen);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.btnBorrarImagen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTipo);
            this.panel1.Controls.Add(this.btnCargarImagen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtComentarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 568);
            this.panel1.TabIndex = 11;
            // 
            // btnAnadirEjercicio
            // 
            this.btnAnadirEjercicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAnadirEjercicio.Location = new System.Drawing.Point(138, 499);
            this.btnAnadirEjercicio.Name = "btnAnadirEjercicio";
            this.btnAnadirEjercicio.Size = new System.Drawing.Size(155, 23);
            this.btnAnadirEjercicio.TabIndex = 11;
            this.btnAnadirEjercicio.Text = "Añadir ejercicio";
            this.btnAnadirEjercicio.UseVisualStyleBackColor = true;
            this.btnAnadirEjercicio.Click += new System.EventHandler(this.btnAnadirEjercicio_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Controls.Add(this.labelError);
            this.panel2.Controls.Add(this.btnBorrarEjercicio);
            this.panel2.Controls.Add(this.dgvBorradoDatos);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(455, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 568);
            this.panel2.TabIndex = 12;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnActualizar.Location = new System.Drawing.Point(176, 443);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelError.Location = new System.Drawing.Point(43, 117);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 15);
            this.labelError.TabIndex = 14;
            // 
            // btnBorrarEjercicio
            // 
            this.btnBorrarEjercicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBorrarEjercicio.Location = new System.Drawing.Point(320, 280);
            this.btnBorrarEjercicio.Name = "btnBorrarEjercicio";
            this.btnBorrarEjercicio.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarEjercicio.TabIndex = 13;
            this.btnBorrarEjercicio.Text = "Borrar";
            this.btnBorrarEjercicio.UseVisualStyleBackColor = true;
            this.btnBorrarEjercicio.Click += new System.EventHandler(this.btnBorrarEjercicio_Click);
            // 
            // dgvBorradoDatos
            // 
            this.dgvBorradoDatos.AllowUserToAddRows = false;
            this.dgvBorradoDatos.AllowUserToDeleteRows = false;
            this.dgvBorradoDatos.AllowUserToResizeRows = false;
            this.dgvBorradoDatos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBorradoDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorradoDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBorradoDatos.ColumnHeadersHeight = 30;
            this.dgvBorradoDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBorradoDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.dgvBorradoDatos.Location = new System.Drawing.Point(130, 157);
            this.dgvBorradoDatos.Name = "dgvBorradoDatos";
            this.dgvBorradoDatos.ReadOnly = true;
            this.dgvBorradoDatos.RowHeadersVisible = false;
            this.dgvBorradoDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBorradoDatos.RowTemplate.Height = 25;
            this.dgvBorradoDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBorradoDatos.Size = new System.Drawing.Size(167, 280);
            this.dgvBorradoDatos.TabIndex = 12;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 160;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(147, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Borrar ejercicio";
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(907, 568);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdd";
            this.Text = "frmAdd";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorradoDatos)).EndInit();
            this.ResumeLayout(false);

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