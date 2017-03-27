namespace BiblioLecteur
{
    partial class Form2
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
            this.gridData2 = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxLivreNom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridData2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridData2
            // 
            this.gridData2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData2.Location = new System.Drawing.Point(28, 12);
            this.gridData2.Name = "gridData2";
            this.gridData2.Size = new System.Drawing.Size(374, 192);
            this.gridData2.TabIndex = 0;
            this.gridData2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridData2_CellContentClick);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(306, 211);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(87, 38);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxLivreNom
            // 
            this.textBoxLivreNom.Location = new System.Drawing.Point(122, 48);
            this.textBoxLivreNom.Name = "textBoxLivreNom";
            this.textBoxLivreNom.Size = new System.Drawing.Size(180, 20);
            this.textBoxLivreNom.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 261);
            this.Controls.Add(this.textBoxLivreNom);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.gridData2);
            this.IsMdiContainer = true;
            this.Name = "Form2";
            this.Text = "reservation";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridData2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridData2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxLivreNom;
    }
}