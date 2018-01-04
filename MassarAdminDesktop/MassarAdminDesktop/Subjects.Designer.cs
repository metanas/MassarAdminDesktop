namespace MassarAdminDesktop
{
    partial class Subjects
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subjects));
            this.panel1 = new System.Windows.Forms.Panel();
            this.diagrambox = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Infobox = new System.Windows.Forms.GroupBox();
            this.Profpanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.moyenne = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exambox = new System.Windows.Forms.GroupBox();
            this.exampanel = new System.Windows.Forms.Panel();
            this.S2box = new System.Windows.Forms.GroupBox();
            this.Button6 = new Bunifu.Framework.UI.BunifuTileButton();
            this.Button5 = new Bunifu.Framework.UI.BunifuTileButton();
            this.Button4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.S1box = new System.Windows.Forms.GroupBox();
            this.Button3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.Button2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.Button1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1.SuspendLayout();
            this.diagrambox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.Infobox.SuspendLayout();
            this.Profpanel.SuspendLayout();
            this.exambox.SuspendLayout();
            this.exampanel.SuspendLayout();
            this.S2box.SuspendLayout();
            this.S1box.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.diagrambox);
            this.panel1.Controls.Add(this.Infobox);
            this.panel1.Controls.Add(this.exambox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 672);
            this.panel1.TabIndex = 0;
            // 
            // diagrambox
            // 
            this.diagrambox.Controls.Add(this.chart1);
            this.diagrambox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagrambox.Location = new System.Drawing.Point(516, 6);
            this.diagrambox.Name = "diagrambox";
            this.diagrambox.Size = new System.Drawing.Size(542, 618);
            this.diagrambox.TabIndex = 11;
            this.diagrambox.TabStop = false;
            this.diagrambox.Text = "Diagrame Des Notes";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 49);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(530, 522);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Infobox
            // 
            this.Infobox.Controls.Add(this.Profpanel);
            this.Infobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Infobox.Location = new System.Drawing.Point(1, 6);
            this.Infobox.Name = "Infobox";
            this.Infobox.Size = new System.Drawing.Size(508, 233);
            this.Infobox.TabIndex = 10;
            this.Infobox.TabStop = false;
            this.Infobox.Text = "Information Sur Matiere";
            // 
            // Profpanel
            // 
            this.Profpanel.BackColor = System.Drawing.Color.White;
            this.Profpanel.Controls.Add(this.label2);
            this.Profpanel.Controls.Add(this.bunifuTileButton1);
            this.Profpanel.Controls.Add(this.label1);
            this.Profpanel.Controls.Add(this.bunifuCircleProgressbar1);
            this.Profpanel.Controls.Add(this.moyenne);
            this.Profpanel.Controls.Add(this.min);
            this.Profpanel.Controls.Add(this.max);
            this.Profpanel.Controls.Add(this.label4);
            this.Profpanel.Controls.Add(this.label3);
            this.Profpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Profpanel.Location = new System.Drawing.Point(3, 31);
            this.Profpanel.Name = "Profpanel";
            this.Profpanel.Size = new System.Drawing.Size(502, 199);
            this.Profpanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Aziz jaamati";
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = global::MassarAdminDesktop.Properties.Resources.professeur;
            this.bunifuTileButton1.ImagePosition = 21;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 43;
            this.bunifuTileButton1.LabelText = "Professeur";
            this.bunifuTileButton1.Location = new System.Drawing.Point(17, 18);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.bunifuTileButton1.Size = new System.Drawing.Size(141, 147);
            this.bunifuTileButton1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Moyenne Generale";
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.bunifuCircleProgressbar1.LabelVisible = false;
            this.bunifuCircleProgressbar1.LineProgressThickness = 19;
            this.bunifuCircleProgressbar1.LineThickness = 19;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(227, 28);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 20;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(91, 91);
            this.bunifuCircleProgressbar1.TabIndex = 21;
            this.bunifuCircleProgressbar1.Value = 0;
            // 
            // moyenne
            // 
            this.moyenne.AutoSize = true;
            this.moyenne.BackColor = System.Drawing.Color.Transparent;
            this.moyenne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moyenne.ForeColor = System.Drawing.Color.Black;
            this.moyenne.Location = new System.Drawing.Point(242, 152);
            this.moyenne.Name = "moyenne";
            this.moyenne.Size = new System.Drawing.Size(54, 20);
            this.moyenne.TabIndex = 20;
            this.moyenne.Text = "10,38";
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.ForeColor = System.Drawing.Color.Red;
            this.min.Location = new System.Drawing.Point(427, 132);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(0, 29);
            this.min.TabIndex = 19;
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.max.Location = new System.Drawing.Point(412, 68);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(0, 29);
            this.max.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(391, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Note Min ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(391, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Note Max";
            // 
            // exambox
            // 
            this.exambox.Controls.Add(this.exampanel);
            this.exambox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exambox.Location = new System.Drawing.Point(1, 245);
            this.exambox.Name = "exambox";
            this.exambox.Size = new System.Drawing.Size(505, 421);
            this.exambox.TabIndex = 9;
            this.exambox.TabStop = false;
            this.exambox.Text = "Exams";
            // 
            // exampanel
            // 
            this.exampanel.BackColor = System.Drawing.Color.White;
            this.exampanel.Controls.Add(this.S2box);
            this.exampanel.Controls.Add(this.S1box);
            this.exampanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exampanel.ForeColor = System.Drawing.Color.White;
            this.exampanel.Location = new System.Drawing.Point(3, 31);
            this.exampanel.Name = "exampanel";
            this.exampanel.Size = new System.Drawing.Size(499, 387);
            this.exampanel.TabIndex = 0;
            // 
            // S2box
            // 
            this.S2box.Controls.Add(this.Button6);
            this.S2box.Controls.Add(this.Button5);
            this.S2box.Controls.Add(this.Button4);
            this.S2box.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S2box.Location = new System.Drawing.Point(32, 203);
            this.S2box.Name = "S2box";
            this.S2box.Size = new System.Drawing.Size(464, 181);
            this.S2box.TabIndex = 8;
            this.S2box.TabStop = false;
            this.S2box.Text = "Semestre 2";
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button6.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button6.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.Button6.ForeColor = System.Drawing.Color.White;
            this.Button6.Image = ((System.Drawing.Image)(resources.GetObject("Button6.Image")));
            this.Button6.ImagePosition = 21;
            this.Button6.ImageZoom = 50;
            this.Button6.LabelPosition = 43;
            this.Button6.LabelText = "cc3";
            this.Button6.Location = new System.Drawing.Point(308, 37);
            this.Button6.Margin = new System.Windows.Forms.Padding(6);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(128, 129);
            this.Button6.TabIndex = 5;
            this.Button6.Visible = false;
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button5.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button5.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.Button5.ForeColor = System.Drawing.Color.White;
            this.Button5.Image = ((System.Drawing.Image)(resources.GetObject("Button5.Image")));
            this.Button5.ImagePosition = 21;
            this.Button5.ImageZoom = 50;
            this.Button5.LabelPosition = 43;
            this.Button5.LabelText = "cc2";
            this.Button5.Location = new System.Drawing.Point(168, 37);
            this.Button5.Margin = new System.Windows.Forms.Padding(6);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(128, 129);
            this.Button5.TabIndex = 4;
            this.Button5.Visible = false;
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button4.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button4.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.Button4.ForeColor = System.Drawing.Color.White;
            this.Button4.Image = ((System.Drawing.Image)(resources.GetObject("Button4.Image")));
            this.Button4.ImagePosition = 21;
            this.Button4.ImageZoom = 50;
            this.Button4.LabelPosition = 43;
            this.Button4.LabelText = "cc1";
            this.Button4.Location = new System.Drawing.Point(13, 37);
            this.Button4.Margin = new System.Windows.Forms.Padding(6);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(128, 129);
            this.Button4.TabIndex = 3;
            this.Button4.Visible = false;
            // 
            // S1box
            // 
            this.S1box.Controls.Add(this.Button3);
            this.S1box.Controls.Add(this.Button2);
            this.S1box.Controls.Add(this.Button1);
            this.S1box.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S1box.Location = new System.Drawing.Point(32, 3);
            this.S1box.Name = "S1box";
            this.S1box.Size = new System.Drawing.Size(464, 194);
            this.S1box.TabIndex = 7;
            this.S1box.TabStop = false;
            this.S1box.Text = "Semestre 1";
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button3.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button3.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.Image = ((System.Drawing.Image)(resources.GetObject("Button3.Image")));
            this.Button3.ImagePosition = 21;
            this.Button3.ImageZoom = 50;
            this.Button3.LabelPosition = 43;
            this.Button3.LabelText = "cc3";
            this.Button3.Location = new System.Drawing.Point(308, 37);
            this.Button3.Margin = new System.Windows.Forms.Padding(6);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(128, 129);
            this.Button3.TabIndex = 5;
            this.Button3.Visible = false;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button2.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button2.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Image = ((System.Drawing.Image)(resources.GetObject("Button2.Image")));
            this.Button2.ImagePosition = 21;
            this.Button2.ImageZoom = 50;
            this.Button2.LabelPosition = 43;
            this.Button2.LabelText = "cc2";
            this.Button2.Location = new System.Drawing.Point(168, 37);
            this.Button2.Margin = new System.Windows.Forms.Padding(6);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(128, 129);
            this.Button2.TabIndex = 4;
            this.Button2.Visible = false;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.ImagePosition = 21;
            this.Button1.ImageZoom = 50;
            this.Button1.LabelPosition = 43;
            this.Button1.LabelText = "cc1";
            this.Button1.Location = new System.Drawing.Point(13, 37);
            this.Button1.Margin = new System.Windows.Forms.Padding(6);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(128, 129);
            this.Button1.TabIndex = 3;
            this.Button1.Visible = false;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 696);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 0);
            this.Name = "Subjects";
            this.Text = "Subjects";
            this.panel1.ResumeLayout(false);
            this.diagrambox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.Infobox.ResumeLayout(false);
            this.Profpanel.ResumeLayout(false);
            this.Profpanel.PerformLayout();
            this.exambox.ResumeLayout(false);
            this.exampanel.ResumeLayout(false);
            this.S2box.ResumeLayout(false);
            this.S1box.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox diagrambox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox Infobox;
        private System.Windows.Forms.Panel Profpanel;
        public System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private System.Windows.Forms.Label moyenne;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox exambox;
        private System.Windows.Forms.Panel exampanel;
        private System.Windows.Forms.GroupBox S2box;
        private Bunifu.Framework.UI.BunifuTileButton Button6;
        private Bunifu.Framework.UI.BunifuTileButton Button5;
        private Bunifu.Framework.UI.BunifuTileButton Button4;
        private System.Windows.Forms.GroupBox S1box;
        private Bunifu.Framework.UI.BunifuTileButton Button3;
        private Bunifu.Framework.UI.BunifuTileButton Button2;
        private Bunifu.Framework.UI.BunifuTileButton Button1;
    }
}