using Presentation.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Forms
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLunes = new System.Windows.Forms.Button();
            this.btnMartes = new System.Windows.Forms.Button();
            this.btnMiercoles = new System.Windows.Forms.Button();
            this.btnJueves = new System.Windows.Forms.Button();
            this.btnViernes = new System.Windows.Forms.Button();
            this.btnCrarPrograma = new System.Windows.Forms.Button();
            this.informacion = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSinConexion = new System.Windows.Forms.Label();
            this.timerParpadeo = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbNombres = new System.Windows.Forms.ComboBox();
            this.pbSinConexion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSinConexion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLunes
            // 
            this.btnLunes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnLunes.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnLunes.Location = new System.Drawing.Point(99, 56);
            this.btnLunes.Name = "btnLunes";
            this.btnLunes.Size = new System.Drawing.Size(138, 30);
            this.btnLunes.TabIndex = 3;
            this.btnLunes.Text = "Lunes";
            this.btnLunes.UseVisualStyleBackColor = true;
            this.btnLunes.Click += new System.EventHandler(this.btnLunes_Click);
            // 
            // btnMartes
            // 
            this.btnMartes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnMartes.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnMartes.Location = new System.Drawing.Point(243, 56);
            this.btnMartes.Name = "btnMartes";
            this.btnMartes.Size = new System.Drawing.Size(138, 30);
            this.btnMartes.TabIndex = 4;
            this.btnMartes.Text = "Martes";
            this.btnMartes.UseVisualStyleBackColor = true;
            this.btnMartes.Click += new System.EventHandler(this.btnMartes_Click);
            // 
            // btnMiercoles
            // 
            this.btnMiercoles.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnMiercoles.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnMiercoles.Location = new System.Drawing.Point(387, 56);
            this.btnMiercoles.Name = "btnMiercoles";
            this.btnMiercoles.Size = new System.Drawing.Size(138, 30);
            this.btnMiercoles.TabIndex = 5;
            this.btnMiercoles.Text = "Miercoles";
            this.btnMiercoles.UseVisualStyleBackColor = true;
            this.btnMiercoles.Click += new System.EventHandler(this.btnMiercoles_Click);
            // 
            // btnJueves
            // 
            this.btnJueves.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnJueves.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnJueves.Location = new System.Drawing.Point(531, 56);
            this.btnJueves.Name = "btnJueves";
            this.btnJueves.Size = new System.Drawing.Size(138, 30);
            this.btnJueves.TabIndex = 6;
            this.btnJueves.Text = "Jueves";
            this.btnJueves.UseVisualStyleBackColor = true;
            this.btnJueves.Click += new System.EventHandler(this.btnJueves_Click);
            // 
            // btnViernes
            // 
            this.btnViernes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnViernes.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnViernes.Location = new System.Drawing.Point(675, 56);
            this.btnViernes.Name = "btnViernes";
            this.btnViernes.Size = new System.Drawing.Size(138, 30);
            this.btnViernes.TabIndex = 7;
            this.btnViernes.Text = "Viernes";
            this.btnViernes.UseVisualStyleBackColor = true;
            this.btnViernes.Click += new System.EventHandler(this.btnViernes_Click);
            // 
            // btnCrarPrograma
            // 
            this.btnCrarPrograma.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCrarPrograma.Location = new System.Drawing.Point(310, 506);
            this.btnCrarPrograma.Name = "btnCrarPrograma";
            this.btnCrarPrograma.Size = new System.Drawing.Size(112, 30);
            this.btnCrarPrograma.TabIndex = 8;
            this.btnCrarPrograma.Text = "Crear Programa";
            this.btnCrarPrograma.UseVisualStyleBackColor = true;
            this.btnCrarPrograma.Click += new System.EventHandler(this.btnCrarPrograma_Click);
            // 
            // informacion
            // 
            this.informacion.AutoSize = true;
            this.informacion.Location = new System.Drawing.Point(110, 99);
            this.informacion.Name = "informacion";
            this.informacion.Size = new System.Drawing.Size(0, 13);
            this.informacion.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(99, 125);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(718, 358);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblSinConexion
            // 
            this.lblSinConexion.AutoSize = true;
            this.lblSinConexion.Enabled = false;
            this.lblSinConexion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblSinConexion.Location = new System.Drawing.Point(734, 518);
            this.lblSinConexion.Name = "lblSinConexion";
            this.lblSinConexion.Size = new System.Drawing.Size(103, 18);
            this.lblSinConexion.TabIndex = 17;
            this.lblSinConexion.Text = "Sin conexión";
            // 
            // timerParpadeo
            // 
            this.timerParpadeo.Interval = 500;
            this.timerParpadeo.Tick += new System.EventHandler(this.timerParpadeo_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(447, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "para";
            // 
            // cbNombres
            // 
            this.cbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNombres.FormattingEnabled = true;
            this.cbNombres.Location = new System.Drawing.Point(499, 511);
            this.cbNombres.Name = "cbNombres";
            this.cbNombres.Size = new System.Drawing.Size(121, 21);
            this.cbNombres.TabIndex = 19;
            // 
            // pbSinConexion
            // 
            this.pbSinConexion.Enabled = false;
            this.pbSinConexion.Image = global::Presentation.Properties.Resources.SinConexion2;
            this.pbSinConexion.Location = new System.Drawing.Point(707, 514);
            this.pbSinConexion.Name = "pbSinConexion";
            this.pbSinConexion.Size = new System.Drawing.Size(31, 27);
            this.pbSinConexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSinConexion.TabIndex = 16;
            this.pbSinConexion.TabStop = false;
            // 
            // frmEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(907, 568);
            this.Controls.Add(this.cbNombres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSinConexion);
            this.Controls.Add(this.pbSinConexion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.informacion);
            this.Controls.Add(this.btnCrarPrograma);
            this.Controls.Add(this.btnViernes);
            this.Controls.Add(this.btnJueves);
            this.Controls.Add(this.btnMiercoles);
            this.Controls.Add(this.btnMartes);
            this.Controls.Add(this.btnLunes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEjercicios";
            this.Text = "Ejercicios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSinConexion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label label1;
        private ComboBox cbNombres;
    }
}