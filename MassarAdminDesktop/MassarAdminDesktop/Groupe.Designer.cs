namespace MassarAdminDesktop
{
    partial class Groupe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Groupe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupe_l = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Progressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.countetudiant = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupe_l);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 464);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupe_l
            // 
            this.groupe_l.AutoSize = true;
            this.groupe_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupe_l.Location = new System.Drawing.Point(113, 15);
            this.groupe_l.Name = "groupe_l";
            this.groupe_l.Size = new System.Drawing.Size(36, 26);
            this.groupe_l.TabIndex = 9;
            this.groupe_l.Text = "ss";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Classe :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.bunifuTileButton1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.countetudiant);
            this.panel2.Controls.Add(this.Progressbar1);
            this.panel2.Location = new System.Drawing.Point(12, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 148);
            this.panel2.TabIndex = 6;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.bunifuTileButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = global::MassarAdminDesktop.Properties.Resources.etudiant;
            this.bunifuTileButton1.ImagePosition = 21;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 43;
            this.bunifuTileButton1.LabelText = "Etudiants";
            this.bunifuTileButton1.Location = new System.Drawing.Point(7, 6);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(148, 131);
            this.bunifuTileButton1.TabIndex = 30;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "Filles                    :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(525, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 31);
            this.label6.TabIndex = 28;
            this.label6.Text = "10,38";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Garçons                :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(525, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 31);
            this.label4.TabIndex = 26;
            this.label4.Text = "10,38";
            // 
            // Progressbar1
            // 
            this.Progressbar1.animated = false;
            this.Progressbar1.animationIterval = 5;
            this.Progressbar1.animationSpeed = 300;
            this.Progressbar1.BackColor = System.Drawing.Color.Transparent;
            this.Progressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Progressbar1.BackgroundImage")));
            this.Progressbar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Progressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.Progressbar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Progressbar1.LabelVisible = false;
            this.Progressbar1.LineProgressThickness = 16;
            this.Progressbar1.LineThickness = 16;
            this.Progressbar1.Location = new System.Drawing.Point(167, 13);
            this.Progressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Progressbar1.MaxValue = 30;
            this.Progressbar1.Name = "Progressbar1";
            this.Progressbar1.ProgressBackColor = System.Drawing.Color.LightPink;
            this.Progressbar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Progressbar1.Size = new System.Drawing.Size(111, 111);
            this.Progressbar1.TabIndex = 24;
            this.Progressbar1.Value = 0;
            // 
            // countetudiant
            // 
            this.countetudiant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countetudiant.BackColor = System.Drawing.Color.Transparent;
            this.countetudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countetudiant.ForeColor = System.Drawing.Color.Black;
            this.countetudiant.Location = new System.Drawing.Point(197, 53);
            this.countetudiant.Name = "countetudiant";
            this.countetudiant.Size = new System.Drawing.Size(54, 33);
            this.countetudiant.TabIndex = 23;
            this.countetudiant.Text = "30";
            this.countetudiant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Groupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 467);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 0);
            this.Name = "Groupe";
            this.Text = "Groupe";
            this.Resize += new System.EventHandler(this.Groupe_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label groupe_l;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCircleProgressbar Progressbar1;
        private System.Windows.Forms.Label countetudiant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
    }
}