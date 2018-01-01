namespace MassarAdminDesktop
{
    partial class Home
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateurs = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Class_Sel = new System.Windows.Forms.ToolStrip();
            this.annees = new System.Windows.Forms.ToolStripComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Matiers = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.Class_Sel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.utilisateurs});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1154, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importerToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fileToolStripMenuItem.Text = "Fichier";
            // 
            // importerToolStripMenuItem
            // 
            this.importerToolStripMenuItem.Name = "importerToolStripMenuItem";
            this.importerToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.importerToolStripMenuItem.Text = "Importer";
            this.importerToolStripMenuItem.Click += new System.EventHandler(this.importerToolStripMenuItem_Click);
            // 
            // utilisateurs
            // 
            this.utilisateurs.Name = "utilisateurs";
            this.utilisateurs.Size = new System.Drawing.Size(77, 20);
            this.utilisateurs.Text = "Utilisateurs";
            this.utilisateurs.Click += new System.EventHandler(this.utilisateursToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1154, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Class_Sel
            // 
            this.Class_Sel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Class_Sel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annees});
            this.Class_Sel.Location = new System.Drawing.Point(0, 24);
            this.Class_Sel.Name = "Class_Sel";
            this.Class_Sel.Size = new System.Drawing.Size(116, 516);
            this.Class_Sel.TabIndex = 2;
            this.Class_Sel.Text = "toolStrip1";
            // 
            // annees
            // 
            this.annees.Name = "annees";
            this.annees.Size = new System.Drawing.Size(111, 23);
            this.annees.SelectedIndexChanged += new System.EventHandler(this.annees_SelectedIndexChanged);
            // 
            // Matiers
            // 
            this.Matiers.Location = new System.Drawing.Point(624, 123);
            this.Matiers.Name = "Matiers";
            this.Matiers.Size = new System.Drawing.Size(227, 103);
            this.Matiers.TabIndex = 3;
            this.Matiers.Text = "Arabe";
            this.Matiers.UseVisualStyleBackColor = true;
            this.Matiers.Visible = false;
            this.Matiers.Click += new System.EventHandler(this.Matiers_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 562);
            this.Controls.Add(this.Matiers);
            this.Controls.Add(this.Class_Sel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Class_Sel.ResumeLayout(false);
            this.Class_Sel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateurs;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip Class_Sel;
        private System.Windows.Forms.ToolStripComboBox annees;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Matiers;
    }
}