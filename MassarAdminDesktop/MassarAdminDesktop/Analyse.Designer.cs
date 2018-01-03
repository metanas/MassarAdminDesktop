namespace MassarAdminDesktop
{
    partial class Analyse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analyse));
            this.Betudiant = new Bunifu.Framework.UI.BunifuTileButton();
            this.Bprofesseur = new Bunifu.Framework.UI.BunifuTileButton();
            this.Bclasse = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // Betudiant
            // 
            this.Betudiant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Betudiant.color = System.Drawing.Color.SeaGreen;
            this.Betudiant.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.Betudiant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Betudiant.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Betudiant.ForeColor = System.Drawing.Color.White;
            this.Betudiant.Image = ((System.Drawing.Image)(resources.GetObject("Betudiant.Image")));
            this.Betudiant.ImagePosition = 20;
            this.Betudiant.ImageZoom = 50;
            this.Betudiant.LabelPosition = 41;
            this.Betudiant.LabelText = "Tile 1";
            this.Betudiant.Location = new System.Drawing.Point(67, 247);
            this.Betudiant.Margin = new System.Windows.Forms.Padding(6);
            this.Betudiant.Name = "Betudiant";
            this.Betudiant.Size = new System.Drawing.Size(128, 129);
            this.Betudiant.TabIndex = 5;
            // 
            // Bprofesseur
            // 
            this.Bprofesseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Bprofesseur.color = System.Drawing.Color.SeaGreen;
            this.Bprofesseur.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.Bprofesseur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bprofesseur.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Bprofesseur.ForeColor = System.Drawing.Color.White;
            this.Bprofesseur.Image = ((System.Drawing.Image)(resources.GetObject("Bprofesseur.Image")));
            this.Bprofesseur.ImagePosition = 20;
            this.Bprofesseur.ImageZoom = 50;
            this.Bprofesseur.LabelPosition = 41;
            this.Bprofesseur.LabelText = "Tile 1";
            this.Bprofesseur.Location = new System.Drawing.Point(233, 247);
            this.Bprofesseur.Margin = new System.Windows.Forms.Padding(6);
            this.Bprofesseur.Name = "Bprofesseur";
            this.Bprofesseur.Size = new System.Drawing.Size(128, 129);
            this.Bprofesseur.TabIndex = 6;
            // 
            // Bclasse
            // 
            this.Bclasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Bclasse.color = System.Drawing.Color.SeaGreen;
            this.Bclasse.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.Bclasse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bclasse.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Bclasse.ForeColor = System.Drawing.Color.White;
            this.Bclasse.Image = ((System.Drawing.Image)(resources.GetObject("Bclasse.Image")));
            this.Bclasse.ImagePosition = 20;
            this.Bclasse.ImageZoom = 50;
            this.Bclasse.LabelPosition = 41;
            this.Bclasse.LabelText = "Tile 1";
            this.Bclasse.Location = new System.Drawing.Point(391, 247);
            this.Bclasse.Margin = new System.Windows.Forms.Padding(6);
            this.Bclasse.Name = "Bclasse";
            this.Bclasse.Size = new System.Drawing.Size(128, 129);
            this.Bclasse.TabIndex = 7;
            // 
            // Analyse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 391);
            this.Controls.Add(this.Bclasse);
            this.Controls.Add(this.Bprofesseur);
            this.Controls.Add(this.Betudiant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Analyse";
            this.Text = "Analyse";
            this.Load += new System.EventHandler(this.Analyse_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton Betudiant;
        private Bunifu.Framework.UI.BunifuTileButton Bprofesseur;
        private Bunifu.Framework.UI.BunifuTileButton Bclasse;
    }
}