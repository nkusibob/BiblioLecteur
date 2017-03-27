namespace BiblioLecteur
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.panelLog = new System.Windows.Forms.Panel();
            this.comboBoxBiblio = new System.Windows.Forms.ComboBox();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.MajorPanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reserverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emprunterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxImageLivre = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonRetard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.buttonExemplaireBibliotheque = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.MajorPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageLivre)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(48, 82);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(121, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "password";
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(48, 38);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(121, 20);
            this.userTextBox.TabIndex = 2;
            this.userTextBox.Text = "User name";
            // 
            // panelLog
            // 
            this.panelLog.BackColor = System.Drawing.SystemColors.Control;
            this.panelLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLog.Controls.Add(this.comboBoxBiblio);
            this.panelLog.Controls.Add(this.button1);
            this.panelLog.Controls.Add(this.userTextBox);
            this.panelLog.Controls.Add(this.textBoxPassword);
            this.panelLog.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLog.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panelLog.Location = new System.Drawing.Point(272, 12);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(219, 255);
            this.panelLog.TabIndex = 3;
            // 
            // comboBoxBiblio
            // 
            this.comboBoxBiblio.FormattingEnabled = true;
            this.comboBoxBiblio.Location = new System.Drawing.Point(48, 134);
            this.comboBoxBiblio.Name = "comboBoxBiblio";
            this.comboBoxBiblio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBiblio.TabIndex = 3;
            // 
            // gridData
            // 
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridData.Location = new System.Drawing.Point(119, 39);
            this.gridData.Name = "gridData";
            this.gridData.Size = new System.Drawing.Size(500, 252);
            this.gridData.TabIndex = 4;
            this.gridData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridData_CellContentClick);
            // 
            // MajorPanel
            // 
            this.MajorPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MajorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MajorPanel.ContextMenuStrip = this.contextMenuStrip1;
            this.MajorPanel.Controls.Add(this.label1);
            this.MajorPanel.Controls.Add(this.pictureBoxImageLivre);
            this.MajorPanel.Controls.Add(this.panel2);
            this.MajorPanel.Controls.Add(this.panel1);
            this.MajorPanel.Controls.Add(this.button2);
            this.MajorPanel.Controls.Add(this.gridData);
            this.MajorPanel.Location = new System.Drawing.Point(13, 3);
            this.MajorPanel.Name = "MajorPanel";
            this.MajorPanel.Size = new System.Drawing.Size(748, 404);
            this.MajorPanel.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reserverToolStripMenuItem,
            this.emprunterToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // reserverToolStripMenuItem
            // 
            this.reserverToolStripMenuItem.Name = "reserverToolStripMenuItem";
            this.reserverToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reserverToolStripMenuItem.Text = "reserver";
            this.reserverToolStripMenuItem.Click += new System.EventHandler(this.reserverToolStripMenuItem_Click);
            // 
            // emprunterToolStripMenuItem
            // 
            this.emprunterToolStripMenuItem.Name = "emprunterToolStripMenuItem";
            this.emprunterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.emprunterToolStripMenuItem.Text = "emprunter";
            this.emprunterToolStripMenuItem.Click += new System.EventHandler(this.emprunterToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "labelIdentification";
            // 
            // pictureBoxImageLivre
            // 
            this.pictureBoxImageLivre.Location = new System.Drawing.Point(625, 42);
            this.pictureBoxImageLivre.Name = "pictureBoxImageLivre";
            this.pictureBoxImageLivre.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxImageLivre.TabIndex = 15;
            this.pictureBoxImageLivre.TabStop = false;
            this.pictureBoxImageLivre.Click += new System.EventHandler(this.pictureBoxImageLivre_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.buttonReservation);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.buttonRetard);
            this.panel2.Location = new System.Drawing.Point(119, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 86);
            this.panel2.TabIndex = 14;
            // 
            // buttonReservation
            // 
            this.buttonReservation.Location = new System.Drawing.Point(3, 4);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(135, 76);
            this.buttonReservation.TabIndex = 7;
            this.buttonReservation.Text = " mes Reservations içi";
            this.buttonReservation.UseVisualStyleBackColor = true;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(237, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 76);
            this.button3.TabIndex = 8;
            this.button3.Text = "reservation complete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonRetard
            // 
            this.buttonRetard.Location = new System.Drawing.Point(503, 7);
            this.buttonRetard.Name = "buttonRetard";
            this.buttonRetard.Size = new System.Drawing.Size(103, 76);
            this.buttonRetard.TabIndex = 6;
            this.buttonRetard.Text = "buttonRetard";
            this.buttonRetard.UseVisualStyleBackColor = true;
            this.buttonRetard.Click += new System.EventHandler(this.buttonRetard_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.textBoxCode);
            this.panel1.Controls.Add(this.buttonExemplaireBibliotheque);
            this.panel1.Location = new System.Drawing.Point(3, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 252);
            this.panel1.TabIndex = 13;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(7, 50);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 50);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(7, 14);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxCode.TabIndex = 10;
            // 
            // buttonExemplaireBibliotheque
            // 
            this.buttonExemplaireBibliotheque.Location = new System.Drawing.Point(0, 164);
            this.buttonExemplaireBibliotheque.Name = "buttonExemplaireBibliotheque";
            this.buttonExemplaireBibliotheque.Size = new System.Drawing.Size(107, 85);
            this.buttonExemplaireBibliotheque.TabIndex = 12;
            this.buttonExemplaireBibliotheque.Text = "Load";
            this.buttonExemplaireBibliotheque.UseVisualStyleBackColor = true;
            this.buttonExemplaireBibliotheque.Click += new System.EventHandler(this.buttonExemplaireBibliotheque_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(622, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "logout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(772, 410);
            this.Controls.Add(this.MajorPanel);
            this.Controls.Add(this.panelLog);
            this.Name = "Form1";
            this.Text = "espace lecteur";
            this.panelLog.ResumeLayout(false);
            this.panelLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.MajorPanel.ResumeLayout(false);
            this.MajorPanel.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageLivre)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Panel panelLog;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.Panel MajorPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxBiblio;
        private System.Windows.Forms.Button buttonRetard;
        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reserverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emprunterToolStripMenuItem;
        private System.Windows.Forms.Button buttonExemplaireBibliotheque;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxImageLivre;
        private System.Windows.Forms.Label label1;
    }
}

