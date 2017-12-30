namespace MassarAdminDesktop
{
    partial class Gerer_Admin
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
            this.Admins = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Super_Admin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.modifierr = new System.Windows.Forms.DataGridViewButtonColumn();
            this.newN = new System.Windows.Forms.TextBox();
            this.NewP = new System.Windows.Forms.TextBox();
            this.Super = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ajouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Admins)).BeginInit();
            this.SuspendLayout();
            // 
            // Admins
            // 
            this.Admins.AllowUserToAddRows = false;
            this.Admins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Admins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.password,
            this.Super_Admin,
            this.Supprimer,
            this.modifierr});
            this.Admins.Location = new System.Drawing.Point(211, 152);
            this.Admins.Name = "Admins";
            this.Admins.Size = new System.Drawing.Size(594, 198);
            this.Admins.TabIndex = 0;
            this.Admins.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Admins_CellContentClick);
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // password
            // 
            this.password.HeaderText = "Nouveau Mot de passe";
            this.password.Name = "password";
            this.password.Width = 150;
            // 
            // Super_Admin
            // 
            this.Super_Admin.HeaderText = "Super Admin";
            this.Super_Admin.Name = "Super_Admin";
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Suppression";
            this.Supprimer.Name = "Supprimer";
            // 
            // modifierr
            // 
            this.modifierr.HeaderText = "Modification";
            this.modifierr.Name = "modifierr";
            this.modifierr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modifierr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // newN
            // 
            this.newN.Location = new System.Drawing.Point(211, 71);
            this.newN.Name = "newN";
            this.newN.Size = new System.Drawing.Size(100, 20);
            this.newN.TabIndex = 1;
            // 
            // NewP
            // 
            this.NewP.Location = new System.Drawing.Point(421, 71);
            this.NewP.Name = "NewP";
            this.NewP.Size = new System.Drawing.Size(100, 20);
            this.NewP.TabIndex = 2;
            // 
            // Super
            // 
            this.Super.AutoSize = true;
            this.Super.Location = new System.Drawing.Point(554, 74);
            this.Super.Name = "Super";
            this.Super.Size = new System.Drawing.Size(86, 17);
            this.Super.TabIndex = 3;
            this.Super.Text = "Super Admin";
            this.Super.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mot de passe";
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(664, 72);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(125, 23);
            this.ajouter.TabIndex = 6;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // Gerer_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 400);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Super);
            this.Controls.Add(this.NewP);
            this.Controls.Add(this.newN);
            this.Controls.Add(this.Admins);
            this.Name = "Gerer_Admin";
            this.Text = "Gerer_Admin";
            ((System.ComponentModel.ISupportInitialize)(this.Admins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Admins;
        private System.Windows.Forms.TextBox newN;
        private System.Windows.Forms.TextBox NewP;
        private System.Windows.Forms.CheckBox Super;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Super_Admin;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.DataGridViewButtonColumn modifierr;
    }
}