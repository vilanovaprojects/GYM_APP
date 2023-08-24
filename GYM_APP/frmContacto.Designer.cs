namespace GYM_APP
{
    partial class frmContacto
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(318, 228);
            label1.Name = "label1";
            label1.Size = new Size(67, 19);
            label1.TabIndex = 0;
            label1.Text = "GITHUB:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(318, 260);
            label2.Name = "label2";
            label2.Size = new Size(77, 19);
            label2.TabIndex = 1;
            label2.Text = "CORREO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 264);
            label4.Name = "label4";
            label4.Size = new Size(135, 15);
            label4.TabIndex = 3;
            label4.Text = "mcvmoises@gmail.com";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(391, 232);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(200, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/vilanovaprojects";
            // 
            // frmContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(907, 567);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmContacto";
            Text = "Contacto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private LinkLabel linkLabel1;
    }
}