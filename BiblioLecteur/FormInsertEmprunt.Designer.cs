namespace BiblioLecteur
{
    partial class FormInsertEmprunt
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
            this.buttonInsEmp = new System.Windows.Forms.Button();
            this.textBoxTitre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonInsEmp
            // 
            this.buttonInsEmp.Location = new System.Drawing.Point(197, 127);
            this.buttonInsEmp.Name = "buttonInsEmp";
            this.buttonInsEmp.Size = new System.Drawing.Size(89, 53);
            this.buttonInsEmp.TabIndex = 11;
            this.buttonInsEmp.Text = "submit";
            this.buttonInsEmp.UseVisualStyleBackColor = true;
            this.buttonInsEmp.Click += new System.EventHandler(this.buttonInsEmp_Click);
            // 
            // textBoxTitre
            // 
            this.textBoxTitre.Location = new System.Drawing.Point(164, 21);
            this.textBoxTitre.Name = "textBoxTitre";
            this.textBoxTitre.Size = new System.Drawing.Size(158, 20);
            this.textBoxTitre.TabIndex = 7;
            this.textBoxTitre.Text = "titre";
            this.textBoxTitre.TextChanged += new System.EventHandler(this.textBoxTitre_TextChanged);
            // 
            // FormInsertEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 261);
            this.Controls.Add(this.buttonInsEmp);
            this.Controls.Add(this.textBoxTitre);
            this.IsMdiContainer = true;
            this.Name = "FormInsertEmprunt";
            this.Text = "louer un livre";
            this.Load += new System.EventHandler(this.FormInsertEmprunt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInsEmp;
        private System.Windows.Forms.TextBox textBoxTitre;
    }
}