namespace MassarAdminDesktop
{
    partial class Login
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
            this.nom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.log_in = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // nom
            // 
            this.nom.Depth = 0;
            this.nom.Hint = "Username";
            this.nom.Location = new System.Drawing.Point(12, 153);
            this.nom.MouseState = MaterialSkin.MouseState.HOVER;
            this.nom.Name = "nom";
            this.nom.PasswordChar = '\0';
            this.nom.SelectedText = "";
            this.nom.SelectionLength = 0;
            this.nom.SelectionStart = 0;
            this.nom.Size = new System.Drawing.Size(239, 23);
            this.nom.TabIndex = 5;
            this.nom.UseSystemPasswordChar = false;
            // 
            // password
            // 
            this.password.Depth = 0;
            this.password.Hint = "Password";
            this.password.Location = new System.Drawing.Point(12, 191);
            this.password.MouseState = MaterialSkin.MouseState.HOVER;
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.Size = new System.Drawing.Size(239, 23);
            this.password.TabIndex = 6;
            this.password.UseSystemPasswordChar = true;
            // 
            // log_in
            // 
            this.log_in.Depth = 0;
            this.log_in.Location = new System.Drawing.Point(176, 240);
            this.log_in.MouseState = MaterialSkin.MouseState.HOVER;
            this.log_in.Name = "log_in";
            this.log_in.Primary = true;
            this.log_in.Size = new System.Drawing.Size(75, 23);
            this.log_in.TabIndex = 7;
            this.log_in.Text = "LOGIN";
            this.log_in.UseVisualStyleBackColor = true;
            this.log_in.Click += new System.EventHandler(this.log_in_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(266, 284);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.password);
            this.Controls.Add(this.nom);
            this.MaximumSize = new System.Drawing.Size(266, 284);
            this.MinimumSize = new System.Drawing.Size(266, 284);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField nom;
        private MaterialSkin.Controls.MaterialSingleLineTextField password;
        private MaterialSkin.Controls.MaterialRaisedButton log_in;
    }
}