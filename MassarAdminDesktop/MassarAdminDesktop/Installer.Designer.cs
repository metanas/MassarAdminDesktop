namespace MassarAdminDesktop
{
    partial class Installer
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBox2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBox3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBox4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBox8 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBox7 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBox6 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.checkBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 377);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(802, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Suivant";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(441, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 141);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mysql information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(13, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Les Information Mysql sont incorrect";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "mot de passe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "User :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Host :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(699, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Installer Mysql";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 141);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information Admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "confirmation mot de passe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "mot de passe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Administrateur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ecole :";
            // 
            // textBox1
            // 
            this.textBox1.Depth = 0;
            this.textBox1.Hint = "Ecole";
            this.textBox1.Location = new System.Drawing.Point(171, 23);
            this.textBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionLength = 0;
            this.textBox1.SelectionStart = 0;
            this.textBox1.Size = new System.Drawing.Size(204, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.UseSystemPasswordChar = false;
            // 
            // textBox2
            // 
            this.textBox2.Depth = 0;
            this.textBox2.Hint = "Admin";
            this.textBox2.Location = new System.Drawing.Point(171, 49);
            this.textBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '\0';
            this.textBox2.SelectedText = "";
            this.textBox2.SelectionLength = 0;
            this.textBox2.SelectionStart = 0;
            this.textBox2.Size = new System.Drawing.Size(204, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.UseSystemPasswordChar = false;
            // 
            // textBox3
            // 
            this.textBox3.Depth = 0;
            this.textBox3.Hint = "Mot de passe";
            this.textBox3.Location = new System.Drawing.Point(171, 78);
            this.textBox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.SelectedText = "";
            this.textBox3.SelectionLength = 0;
            this.textBox3.SelectionStart = 0;
            this.textBox3.Size = new System.Drawing.Size(204, 23);
            this.textBox3.TabIndex = 3;
            this.textBox3.UseSystemPasswordChar = false;
            // 
            // textBox4
            // 
            this.textBox4.Depth = 0;
            this.textBox4.Hint = "Confirmation mot de passe";
            this.textBox4.Location = new System.Drawing.Point(171, 107);
            this.textBox4.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '*';
            this.textBox4.SelectedText = "";
            this.textBox4.SelectionLength = 0;
            this.textBox4.SelectionStart = 0;
            this.textBox4.Size = new System.Drawing.Size(204, 23);
            this.textBox4.TabIndex = 4;
            this.textBox4.UseSystemPasswordChar = false;
            // 
            // textBox8
            // 
            this.textBox8.Depth = 0;
            this.textBox8.Hint = "localhost";
            this.textBox8.Location = new System.Drawing.Point(95, 24);
            this.textBox8.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox8.Name = "textBox8";
            this.textBox8.PasswordChar = '\0';
            this.textBox8.SelectedText = "";
            this.textBox8.SelectionLength = 0;
            this.textBox8.SelectionStart = 0;
            this.textBox8.Size = new System.Drawing.Size(204, 23);
            this.textBox8.TabIndex = 5;
            this.textBox8.UseSystemPasswordChar = false;
            // 
            // textBox7
            // 
            this.textBox7.Depth = 0;
            this.textBox7.Hint = "root";
            this.textBox7.Location = new System.Drawing.Point(95, 53);
            this.textBox7.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox7.Name = "textBox7";
            this.textBox7.PasswordChar = '\0';
            this.textBox7.SelectedText = "";
            this.textBox7.SelectionLength = 0;
            this.textBox7.SelectionStart = 0;
            this.textBox7.Size = new System.Drawing.Size(204, 23);
            this.textBox7.TabIndex = 6;
            this.textBox7.UseSystemPasswordChar = false;
            // 
            // textBox6
            // 
            this.textBox6.Depth = 0;
            this.textBox6.Hint = "Mot de passe";
            this.textBox6.Location = new System.Drawing.Point(93, 82);
            this.textBox6.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox6.Name = "textBox6";
            this.textBox6.PasswordChar = '*';
            this.textBox6.SelectedText = "";
            this.textBox6.SelectionLength = 0;
            this.textBox6.SelectionStart = 0;
            this.textBox6.Size = new System.Drawing.Size(204, 23);
            this.textBox6.TabIndex = 7;
            this.textBox6.UseSystemPasswordChar = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Depth = 0;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox1.Location = new System.Drawing.Point(30, 322);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Ripple = true;
            this.checkBox1.Size = new System.Drawing.Size(215, 30);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Je suis administrateur system";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 42);
            this.panel1.TabIndex = 24;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MassarAdminDesktop.Properties.Resources.sss;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(55, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(233, 24);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = " Massar Administration";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = global::MassarAdminDesktop.Properties.Resources.close;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(773, 9);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(22, 21);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 25;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Installer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Installer";
            this.Text = "Installer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox6;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox7;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox8;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox4;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox3;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox1;
        private MaterialSkin.Controls.MaterialCheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}