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
            this.newN = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.NewP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Super = new MaterialSkin.Controls.MaterialCheckBox();
            this.ajouter = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.Admins.Location = new System.Drawing.Point(13, 136);
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
            this.newN.Depth = 0;
            this.newN.Hint = "Username";
            this.newN.Location = new System.Drawing.Point(51, 93);
            this.newN.MouseState = MaterialSkin.MouseState.HOVER;
            this.newN.Name = "newN";
            this.newN.PasswordChar = '\0';
            this.newN.SelectedText = "";
            this.newN.SelectionLength = 0;
            this.newN.SelectionStart = 0;
            this.newN.Size = new System.Drawing.Size(125, 23);
            this.newN.TabIndex = 7;
            this.newN.UseSystemPasswordChar = false;
            // 
            // NewP
            // 
            this.NewP.Depth = 0;
            this.NewP.Hint = "Password";
            this.NewP.Location = new System.Drawing.Point(182, 93);
            this.NewP.MouseState = MaterialSkin.MouseState.HOVER;
            this.NewP.Name = "NewP";
            this.NewP.PasswordChar = '\0';
            this.NewP.SelectedText = "";
            this.NewP.SelectionLength = 0;
            this.NewP.SelectionStart = 0;
            this.NewP.Size = new System.Drawing.Size(125, 23);
            this.NewP.TabIndex = 8;
            this.NewP.UseSystemPasswordChar = true;
            // 
            // Super
            // 
            this.Super.AutoSize = true;
            this.Super.Depth = 0;
            this.Super.Font = new System.Drawing.Font("Roboto", 10F);
            this.Super.Location = new System.Drawing.Point(320, 89);
            this.Super.Margin = new System.Windows.Forms.Padding(0);
            this.Super.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Super.MouseState = MaterialSkin.MouseState.HOVER;
            this.Super.Name = "Super";
            this.Super.Ripple = true;
            this.Super.Size = new System.Drawing.Size(109, 30);
            this.Super.TabIndex = 9;
            this.Super.Text = "Super Admin";
            this.Super.UseVisualStyleBackColor = true;
            // 
            // ajouter
            // 
            this.ajouter.Depth = 0;
            this.ajouter.Location = new System.Drawing.Point(449, 92);
            this.ajouter.MouseState = MaterialSkin.MouseState.HOVER;
            this.ajouter.Name = "ajouter";
            this.ajouter.Primary = true;
            this.ajouter.Size = new System.Drawing.Size(75, 23);
            this.ajouter.TabIndex = 10;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // Gerer_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 343);
            this.Controls.Add(this.ajouter);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Super_Admin;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.DataGridViewButtonColumn modifierr;
        private MaterialSkin.Controls.MaterialSingleLineTextField newN;
        private MaterialSkin.Controls.MaterialSingleLineTextField NewP;
        private MaterialSkin.Controls.MaterialCheckBox Super;
        private MaterialSkin.Controls.MaterialRaisedButton ajouter;
    }
}