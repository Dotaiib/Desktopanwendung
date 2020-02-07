namespace Gestion_Excel
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderFichierExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculeDesHeuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesDonnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechExcelSauvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechHeuresSauvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(506, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sauvegarderFichierExcelToolStripMenuItem,
            this.calculeDesHeuresToolStripMenuItem,
            this.gérerLesDonnéesToolStripMenuItem,
            this.iMPToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // sauvegarderFichierExcelToolStripMenuItem
            // 
            this.sauvegarderFichierExcelToolStripMenuItem.Name = "sauvegarderFichierExcelToolStripMenuItem";
            this.sauvegarderFichierExcelToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.sauvegarderFichierExcelToolStripMenuItem.Text = "Save Excel DataBase";
            this.sauvegarderFichierExcelToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderFichierExcelToolStripMenuItem_Click);
            // 
            // calculeDesHeuresToolStripMenuItem
            // 
            this.calculeDesHeuresToolStripMenuItem.Name = "calculeDesHeuresToolStripMenuItem";
            this.calculeDesHeuresToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.calculeDesHeuresToolStripMenuItem.Text = "Calcule des Heures";
            this.calculeDesHeuresToolStripMenuItem.Click += new System.EventHandler(this.calculeDesHeuresToolStripMenuItem_Click);
            // 
            // gérerLesDonnéesToolStripMenuItem
            // 
            this.gérerLesDonnéesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechExcelSauvToolStripMenuItem,
            this.rechHeuresSauvToolStripMenuItem});
            this.gérerLesDonnéesToolStripMenuItem.Name = "gérerLesDonnéesToolStripMenuItem";
            this.gérerLesDonnéesToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.gérerLesDonnéesToolStripMenuItem.Text = "Gérer Les Données ";
            // 
            // rechExcelSauvToolStripMenuItem
            // 
            this.rechExcelSauvToolStripMenuItem.Name = "rechExcelSauvToolStripMenuItem";
            this.rechExcelSauvToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.rechExcelSauvToolStripMenuItem.Text = "Rech. Excel Sauv.";
            this.rechExcelSauvToolStripMenuItem.Click += new System.EventHandler(this.rechExcelSauvToolStripMenuItem_Click);
            // 
            // rechHeuresSauvToolStripMenuItem
            // 
            this.rechHeuresSauvToolStripMenuItem.Name = "rechHeuresSauvToolStripMenuItem";
            this.rechHeuresSauvToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.rechHeuresSauvToolStripMenuItem.Text = "Rech. Heures Sauv.";
            this.rechHeuresSauvToolStripMenuItem.Click += new System.EventHandler(this.rechHeuresSauvToolStripMenuItem_Click);
            // 
            // iMPToolStripMenuItem
            // 
            this.iMPToolStripMenuItem.Name = "iMPToolStripMenuItem";
            this.iMPToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.iMPToolStripMenuItem.Text = "Imprimer Excel";
            this.iMPToolStripMenuItem.Click += new System.EventHandler(this.iMPToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(78, 23);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(506, 365);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderFichierExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculeDesHeuresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesDonnéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechExcelSauvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechHeuresSauvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iMPToolStripMenuItem;

    }
}

