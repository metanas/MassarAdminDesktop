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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subjects));
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.Button10 = new Bunifu.Framework.UI.BunifuTileButton();
            this.Button9 = new Bunifu.Framework.UI.BunifuTileButton();
            this.Button8 = new Bunifu.Framework.UI.BunifuTileButton();
            this.Button7 = new Bunifu.Framework.UI.BunifuTileButton();
            this.Button6 = new Bunifu.Framework.UI.BunifuTileButton();
            this.S1box = new System.Windows.Forms.GroupBox();
            this.Button5 = new Bunifu.Framework.UI.BunifuTileButton();
            this.Button4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.Button3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.Button2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.Button1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exam_i = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nonv_i = new System.Windows.Forms.Label();
            this.ecart_i = new System.Windows.Forms.Label();
            this.taux_i = new System.Windows.Forms.Label();
            this.moy_i = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.Infobox.SuspendLayout();
            this.Profpanel.SuspendLayout();
            this.exambox.SuspendLayout();
            this.exampanel.SuspendLayout();
            this.S2box.SuspendLayout();
            this.S1box.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.Infobox);
            this.panel1.Controls.Add(this.exambox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 620);
            this.panel1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(515, 20);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(529, 370);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.DoubleClick += new System.EventHandler(this.chart1_DoubleClick);
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
            this.label2.Location = new System.Drawing.Point(41, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Aziz jaamati";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.bunifuTileButton1.LabelText = "Enseignant";
            this.bunifuTileButton1.Location = new System.Drawing.Point(17, 18);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.bunifuTileButton1.Size = new System.Drawing.Size(127, 158);
            this.bunifuTileButton1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 22);
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
            this.bunifuCircleProgressbar1.MaxValue = 10;
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
            this.moyenne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moyenne.ForeColor = System.Drawing.Color.Black;
            this.moyenne.Location = new System.Drawing.Point(242, 152);
            this.moyenne.Name = "moyenne";
            this.moyenne.Size = new System.Drawing.Size(55, 24);
            this.moyenne.TabIndex = 20;
            this.moyenne.Text = "10,38";
            // 
            // min
            // 
            this.min.CausesValidation = false;
            this.min.ForeColor = System.Drawing.Color.Red;
            this.min.Location = new System.Drawing.Point(401, 120);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(64, 29);
            this.min.TabIndex = 19;
            this.min.Text = "min";
            this.min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // max
            // 
            this.max.CausesValidation = false;
            this.max.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.max.Location = new System.Drawing.Point(401, 51);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(64, 29);
            this.max.TabIndex = 18;
            this.max.Text = "max";
            this.max.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Note Min ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Note Max";
            // 
            // exambox
            // 
            this.exambox.BackColor = System.Drawing.Color.Gainsboro;
            this.exambox.Controls.Add(this.exampanel);
            this.exambox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exambox.Location = new System.Drawing.Point(0, 260);
            this.exambox.Name = "exambox";
            this.exambox.Size = new System.Drawing.Size(509, 357);
            this.exambox.TabIndex = 9;
            this.exambox.TabStop = false;
            this.exambox.Text = "Examens";
            // 
            // exampanel
            // 
            this.exampanel.BackColor = System.Drawing.Color.White;
            this.exampanel.Controls.Add(this.S2box);
            this.exampanel.Controls.Add(this.S1box);
            this.exampanel.ForeColor = System.Drawing.Color.White;
            this.exampanel.Location = new System.Drawing.Point(3, 39);
            this.exampanel.Name = "exampanel";
            this.exampanel.Size = new System.Drawing.Size(503, 316);
            this.exampanel.TabIndex = 0;
            // 
            // S2box
            // 
            this.S2box.Controls.Add(this.Button10);
            this.S2box.Controls.Add(this.Button9);
            this.S2box.Controls.Add(this.Button8);
            this.S2box.Controls.Add(this.Button7);
            this.S2box.Controls.Add(this.Button6);
            this.S2box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.S2box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.S2box.Location = new System.Drawing.Point(11, 161);
            this.S2box.Name = "S2box";
            this.S2box.Size = new System.Drawing.Size(478, 147);
            this.S2box.TabIndex = 8;
            this.S2box.TabStop = false;
            this.S2box.Text = "Semestre 2";
            this.S2box.Visible = false;
            // 
            // Button10
            // 
            this.Button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button10.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button10.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.Button10.ForeColor = System.Drawing.Color.White;
            this.Button10.Image = global::MassarAdminDesktop.Properties.Resources.exam;
            this.Button10.ImagePosition = 21;
            this.Button10.ImageZoom = 50;
            this.Button10.LabelPosition = 43;
            this.Button10.LabelText = "cc5";
            this.Button10.Location = new System.Drawing.Point(405, 39);
            this.Button10.Margin = new System.Windows.Forms.Padding(6);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(63, 96);
            this.Button10.TabIndex = 7;
            this.Button10.Visible = false;
            // 
            // Button9
            // 
            this.Button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button9.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button9.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.Button9.ForeColor = System.Drawing.Color.White;
            this.Button9.Image = global::MassarAdminDesktop.Properties.Resources.exam;
            this.Button9.ImagePosition = 21;
            this.Button9.ImageZoom = 50;
            this.Button9.LabelPosition = 43;
            this.Button9.LabelText = "cc4";
            this.Button9.Location = new System.Drawing.Point(306, 39);
            this.Button9.Margin = new System.Windows.Forms.Padding(6);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(63, 96);
            this.Button9.TabIndex = 6;
            this.Button9.Visible = false;
            // 
            // Button8
            // 
            this.Button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button8.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button8.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.Button8.ForeColor = System.Drawing.Color.White;
            this.Button8.Image = global::MassarAdminDesktop.Properties.Resources.exam;
            this.Button8.ImagePosition = 21;
            this.Button8.ImageZoom = 50;
            this.Button8.LabelPosition = 43;
            this.Button8.LabelText = "cc3";
            this.Button8.Location = new System.Drawing.Point(207, 39);
            this.Button8.Margin = new System.Windows.Forms.Padding(6);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(63, 96);
            this.Button8.TabIndex = 5;
            this.Button8.Visible = false;
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button7.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button7.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.Button7.ForeColor = System.Drawing.Color.White;
            this.Button7.Image = global::MassarAdminDesktop.Properties.Resources.exam;
            this.Button7.ImagePosition = 21;
            this.Button7.ImageZoom = 50;
            this.Button7.LabelPosition = 43;
            this.Button7.LabelText = "cc2";
            this.Button7.Location = new System.Drawing.Point(108, 39);
            this.Button7.Margin = new System.Windows.Forms.Padding(6);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(63, 96);
            this.Button7.TabIndex = 4;
            this.Button7.Visible = false;
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button6.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button6.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Button6.ForeColor = System.Drawing.Color.White;
            this.Button6.Image = global::MassarAdminDesktop.Properties.Resources.exam;
            this.Button6.ImagePosition = 21;
            this.Button6.ImageZoom = 50;
            this.Button6.LabelPosition = 43;
            this.Button6.LabelText = "cc1";
            this.Button6.Location = new System.Drawing.Point(9, 39);
            this.Button6.Margin = new System.Windows.Forms.Padding(6);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(63, 96);
            this.Button6.TabIndex = 3;
            this.Button6.Visible = false;
            // 
            // S1box
            // 
            this.S1box.Controls.Add(this.Button5);
            this.S1box.Controls.Add(this.Button4);
            this.S1box.Controls.Add(this.Button3);
            this.S1box.Controls.Add(this.Button2);
            this.S1box.Controls.Add(this.Button1);
            this.S1box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.S1box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.S1box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.S1box.Location = new System.Drawing.Point(10, 13);
            this.S1box.Name = "S1box";
            this.S1box.Size = new System.Drawing.Size(478, 142);
            this.S1box.TabIndex = 7;
            this.S1box.TabStop = false;
            this.S1box.Text = "Semestre 1";
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button5.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button5.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.Button5.ForeColor = System.Drawing.Color.White;
            this.Button5.Image = global::MassarAdminDesktop.Properties.Resources.exam;
            this.Button5.ImagePosition = 21;
            this.Button5.ImageZoom = 50;
            this.Button5.LabelPosition = 43;
            this.Button5.LabelText = "cc5";
            this.Button5.Location = new System.Drawing.Point(405, 37);
            this.Button5.Margin = new System.Windows.Forms.Padding(6);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(63, 96);
            this.Button5.TabIndex = 7;
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
            this.Button4.Image = global::MassarAdminDesktop.Properties.Resources.exam;
            this.Button4.ImagePosition = 21;
            this.Button4.ImageZoom = 50;
            this.Button4.LabelPosition = 43;
            this.Button4.LabelText = "cc4";
            this.Button4.Location = new System.Drawing.Point(306, 37);
            this.Button4.Margin = new System.Windows.Forms.Padding(6);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(63, 96);
            this.Button4.TabIndex = 6;
            this.Button4.Visible = false;
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button3.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button3.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.Image = global::MassarAdminDesktop.Properties.Resources.exam;
            this.Button3.ImagePosition = 21;
            this.Button3.ImageZoom = 50;
            this.Button3.LabelPosition = 43;
            this.Button3.LabelText = "cc3";
            this.Button3.Location = new System.Drawing.Point(207, 37);
            this.Button3.Margin = new System.Windows.Forms.Padding(6);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(63, 96);
            this.Button3.TabIndex = 5;
            this.Button3.Visible = false;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button2.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button2.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Image = global::MassarAdminDesktop.Properties.Resources.exam;
            this.Button2.ImagePosition = 21;
            this.Button2.ImageZoom = 50;
            this.Button2.LabelPosition = 43;
            this.Button2.LabelText = "cc2";
            this.Button2.Location = new System.Drawing.Point(108, 37);
            this.Button2.Margin = new System.Windows.Forms.Padding(6);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(63, 96);
            this.Button2.TabIndex = 4;
            this.Button2.Visible = false;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Image = global::MassarAdminDesktop.Properties.Resources.exam;
            this.Button1.ImagePosition = 21;
            this.Button1.ImageZoom = 50;
            this.Button1.LabelPosition = 43;
            this.Button1.LabelText = "cc1";
            this.Button1.Location = new System.Drawing.Point(9, 37);
            this.Button1.Margin = new System.Windows.Forms.Padding(6);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(63, 96);
            this.Button1.TabIndex = 3;
            this.Button1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.exam_i);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.nonv_i);
            this.panel2.Controls.Add(this.ecart_i);
            this.panel2.Controls.Add(this.taux_i);
            this.panel2.Controls.Add(this.moy_i);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(515, 396);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 219);
            this.panel2.TabIndex = 11;
            // 
            // exam_i
            // 
            this.exam_i.AutoSize = true;
            this.exam_i.BackColor = System.Drawing.Color.White;
            this.exam_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exam_i.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.exam_i.Location = new System.Drawing.Point(144, 9);
            this.exam_i.Name = "exam_i";
            this.exam_i.Size = new System.Drawing.Size(71, 24);
            this.exam_i.TabIndex = 9;
            this.exam_i.Text = "exam_i";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Détails de l\'examen :";
            // 
            // nonv_i
            // 
            this.nonv_i.AutoSize = true;
            this.nonv_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonv_i.ForeColor = System.Drawing.Color.Red;
            this.nonv_i.Location = new System.Drawing.Point(297, 168);
            this.nonv_i.Name = "nonv_i";
            this.nonv_i.Size = new System.Drawing.Size(24, 26);
            this.nonv_i.TabIndex = 7;
            this.nonv_i.Text = "4";
            this.nonv_i.Visible = false;
            // 
            // ecart_i
            // 
            this.ecart_i.AutoSize = true;
            this.ecart_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecart_i.Location = new System.Drawing.Point(297, 86);
            this.ecart_i.Name = "ecart_i";
            this.ecart_i.Size = new System.Drawing.Size(42, 26);
            this.ecart_i.TabIndex = 6;
            this.ecart_i.Text = "1,5";
            this.ecart_i.Visible = false;
            // 
            // taux_i
            // 
            this.taux_i.AutoSize = true;
            this.taux_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taux_i.Location = new System.Drawing.Point(51, 168);
            this.taux_i.Name = "taux_i";
            this.taux_i.Size = new System.Drawing.Size(74, 26);
            this.taux_i.TabIndex = 5;
            this.taux_i.Text = "100 %";
            this.taux_i.Visible = false;
            // 
            // moy_i
            // 
            this.moy_i.AutoSize = true;
            this.moy_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moy_i.Location = new System.Drawing.Point(51, 86);
            this.moy_i.Name = "moy_i";
            this.moy_i.Size = new System.Drawing.Size(36, 26);
            this.moy_i.TabIndex = 4;
            this.moy_i.Text = "10";
            this.moy_i.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(260, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ecart type :";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(260, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Elèves non validés :";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Taux de réussite :";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Moyenne :";
            this.label5.Visible = false;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 638);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 0);
            this.Name = "Subjects";
            this.Text = "Subjects";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.Infobox.ResumeLayout(false);
            this.Profpanel.ResumeLayout(false);
            this.Profpanel.PerformLayout();
            this.exambox.ResumeLayout(false);
            this.exampanel.ResumeLayout(false);
            this.S2box.ResumeLayout(false);
            this.S1box.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox exambox;
        private System.Windows.Forms.Panel exampanel;
        private System.Windows.Forms.GroupBox S2box;
        private Bunifu.Framework.UI.BunifuTileButton Button10;
        private Bunifu.Framework.UI.BunifuTileButton Button9;
        private Bunifu.Framework.UI.BunifuTileButton Button8;
        private Bunifu.Framework.UI.BunifuTileButton Button7;
        private Bunifu.Framework.UI.BunifuTileButton Button6;
        private System.Windows.Forms.GroupBox S1box;
        private Bunifu.Framework.UI.BunifuTileButton Button5;
        private Bunifu.Framework.UI.BunifuTileButton Button4;
        private Bunifu.Framework.UI.BunifuTileButton Button3;
        private Bunifu.Framework.UI.BunifuTileButton Button2;
        private Bunifu.Framework.UI.BunifuTileButton Button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label nonv_i;
        private System.Windows.Forms.Label ecart_i;
        private System.Windows.Forms.Label taux_i;
        private System.Windows.Forms.Label moy_i;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label exam_i;
        private System.Windows.Forms.Label label9;
    }
}