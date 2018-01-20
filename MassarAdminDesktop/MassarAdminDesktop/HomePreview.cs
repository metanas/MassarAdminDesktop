using MassarAdminDesktop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace MassarAdminDesktop
{
    public partial class HomePreview : Form
    {
        public static PrivateFontCollection latoReg;
        public static PrivateFontCollection latoBold;
        public static PrivateFontCollection latoBlack;
        public static Form HomeForm;
        public static int XP;
        public static int YP;
        public static Form ActifForm;
        public static List<BunifuFlatButton> ClassButton = new List<BunifuFlatButton>();
        public static List<string> id_classes = new List<string>();
        public static string id;
        public static string nomgr;
        public static string idann;
        public static int nbrClasse;
        public static List<Form> PreviewFrom = new List<Form>();
        BunifuFlatButton lastClick;
        int tog, mvalX, mvalY;
        List<string> listYear = new List<string>();
        int yearSelected = 0;
        BunifuImageButton forward;
        BunifuImageButton backward;

        public HomePreview()
        {
            InitializeComponent();
            HomeForm = this;
            loadFont();
            XP = panel3.Width;
            YP = panel2.Location.Y + panel2.Height;
        }

        private void HomePreview_Load(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Font = new Font(latoReg.Families[0], 16, FontStyle.Bold);
            label1.Font = new Font(latoReg.Families[0], 16, FontStyle.Regular);
            label2.Font = new Font(latoBold.Families[0], 22, FontStyle.Bold);
            label3.Font = new Font(latoReg.Families[0], 12, FontStyle.Bold);
            label4.Font = new Font(latoReg.Families[0], 12, FontStyle.Bold);
            Login login = new Login();
            resizeLocationForm(login);
            loadYears();
        }

        void loadFont()
        {
            latoReg = new PrivateFontCollection();
            latoBold = new PrivateFontCollection();
            latoBlack = new PrivateFontCollection();
            latoReg.AddFontFile("C:\\Fonts\\LATO-REGULAR.TTF");
            latoBold.AddFontFile("C:\\Fonts\\LATO-BOLD.TTF");
            latoBlack.AddFontFile("C:\\Fonts\\LATO-BLACK.TTF");
        }

        void loadYears()
        {
            Login.read = DBConnect.Gets("select annee_scolaire from annee order by annee_scolaire desc ; ");
            while (Login.read.Read())
                listYear.Add(Login.read["annee_scolaire"].ToString());
            Login.read.Close();
        }

        void loadClasse()
        {
            int i = 0;
            foreach (var b in ClassButton)
            {
                if (b.GetType() == typeof(BunifuFlatButton))
                {
                    panel3.Controls.Remove((BunifuFlatButton)b);
                }
            }
            ClassButton.Clear();
            id_classes.Clear();
            Login.read = DBConnect.Gets("select groupe.nom , groupe.id from groupe , annee where annee.annee_scolaire='" + listYear[yearSelected] + "' and  annee.id=groupe.id_annee ; ");
            while (Login.read.Read())
            {
                ClassButton.Add(new BunifuFlatButton());
                ClassButton[i].Size = new Size(panel3.Width, 48);
                ClassButton[i].TextFont = new Font(latoReg.Families[0], 12, FontStyle.Bold);
                ClassButton[i].Textcolor = Color.FromArgb(54, 78, 102);
                ClassButton[i].BackColor = Color.FromArgb(233, 233, 233);
                ClassButton[i].Activecolor = Color.FromArgb(107, 124, 140);
                ClassButton[i].Normalcolor = Color.FromArgb(233, 233, 233);
                ClassButton[i].OnHovercolor = Color.FromArgb(200, 200, 200);
                ClassButton[i].Click += new EventHandler(this.Classe_Click);
                ClassButton[i].Text = Login.read["nom"].ToString();
                ClassButton[i].IsTab = true;
                if (i == 0)
                {
                    ClassButton[i].Location = new Point(panel3.Location.X, search.Location.Y + search.Height);
                }
                else { ClassButton[i].Location = new Point(panel3.Location.X, ClassButton[i - 1].Location.Y + ClassButton[i - 1].Height); }
                id_classes.Add(Login.read["id"].ToString());
                panel3.Controls.Add(ClassButton[i++]);
            }
            Login.read.Close();
            nbrClasse = ClassButton.Count;
    }

        public void Classe_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ClassButton.Count; i++)
            {
                if (ClassButton[i] == ((BunifuFlatButton)sender))
                {
                    id = id_classes[i];
                    break;
                }
            }
            if (lastClick != null) lastClick.selected = false;
            ((BunifuFlatButton)sender).selected = true;
            lastClick = ((BunifuFlatButton)sender);
            nomgr = ((BunifuFlatButton)sender).Text;
            Groupe Groupe_Form = new Groupe(id, nomgr);
            resizeLocationForm(Groupe_Form);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(panel2.ClientRectangle,
                                                             Color.FromArgb(251, 210, 92),
                                                             Color.FromArgb(228, 179, 112),
                                                             90F)) 
            {
                e.Graphics.FillRectangle(brush, panel2.ClientRectangle);
            }
        }

        public static void resizeLocationForm(Form form)
        {

            form.TopLevel = false;
            form.Parent = HomePreview.HomeForm;
            form.Location = new Point(HomePreview.XP, HomePreview.YP);
            form.Size = new Size(HomePreview.HomeForm.Width - HomePreview.XP, HomePreview.HomeForm.Height - HomePreview.YP);
            form.Show();
            if (HomePreview.ActifForm != null && HomePreview.ActifForm.Name != "Login")
            {
                HomePreview.PreviewFrom.Add(HomePreview.ActifForm);
                HomePreview.ActifForm.Hide();  
                ((BunifuImageButton)HomeForm.Controls.Find("HomeButton", true)[0]).Visible = true;
                ((BunifuImageButton)HomeForm.Controls.Find("BackButton", true)[0]).Visible = true;
            }
            HomePreview.ActifForm = form;

        }

        public void LeftRight()
        {
            forward = new BunifuImageButton();
            forward.Image = Resources.ForwardB;
            forward.Size = new Size(40, 29);
            forward.BackColor = Color.Transparent;
            forward.Enabled = false;
            forward.Location = new Point(XP - forward.Width , 135);
            forward.Click += new EventHandler(right_click);
            panel4.Controls.Add(forward);

            backward = new BunifuImageButton();
            backward.Location = new Point(0, 135);
            backward.Size = new Size(40, 29);
            backward.BackColor = Color.Transparent;
            backward.Image = Resources.Backward;
            backward.Click += new EventHandler(left_click);
            panel4.Controls.Add(backward);
        }

        private void left_click(object sender, EventArgs e)
        {
            label2.Text = listYear[++yearSelected].Replace('/', '-');
            if (yearSelected + 1 >= listYear.Count) backward.Enabled = false;
            forward.Enabled = true;
            loadClasse();

        }

        private void right_click(object sender, EventArgs e)
        {
            label2.Text = listYear[--yearSelected].Replace('/', '-');
            if (yearSelected == 0) forward.Enabled = false;
            backward.Enabled = true;
            loadClasse();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e )
        {
            tog = 1;
            mvalX = e.Location.X;
            mvalY = e.Location.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            tog = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tog == 1) {
                this.SetDesktopLocation(MousePosition.X - mvalX, MousePosition.Y - mvalY);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (this.MaximizeBox) { 
                this.WindowState = FormWindowState.Maximized;
                this.MaximizeBox = false;
                bunifuImageButton2.Image = Resources.minimize;
            }
            else {
                this.WindowState = FormWindowState.Normal;
                this.MaximizeBox = true;
                bunifuImageButton2.Image = Resources.maximize;
            }
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            foreach (Form f in PreviewFrom) f.Close();

            foreach (BunifuFlatButton b in ClassButton) panel4.Controls.Remove(b);
            ClassButton.Clear();
            PreviewFrom.Clear();
            Login login = new Login();
            resizeLocationForm(login);
            label1.Visible = false;
            label2.Visible = false;
            panel5.Visible = false;
            panel4.Controls.Remove(forward);
            panel4.Controls.Remove(backward);
            BackButton.Visible = false;
            HomeButton.Visible = false;
        }

        private void HomePreview_Click(object sender, EventArgs e)
        {
            Previw previw = new Previw();
            resizeLocationForm(previw);
        }

        private void HomePreview_TextChanged(object sender, EventArgs e)
        {
            LeftRight();
            label1.Visible = true;
            label2.Visible = true;
            panel5.Visible = true;
            if (listYear.Count >= 2)
            {
                backward.Enabled = true;
            }
            else if (listYear.Count == 0)
                return;
            idann = listYear[yearSelected];
            label2.Text = idann.Replace('/', '-');
            loadClasse();
            Analyse analyse = new Analyse();
            resizeLocationForm(analyse);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ActifForm.Close();
            ActifForm = PreviewFrom[PreviewFrom.Count - 1];
            ActifForm.Show();
            PreviewFrom.RemoveAt(PreviewFrom.Count - 1);
            if(PreviewFrom.Count == 0)
            {
                BackButton.Visible = false;
                HomeButton.Visible = false;
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            if (lastClick != null) lastClick.selected = false;
            foreach (Form f in PreviewFrom)
            {
                f.Close();
            }
            PreviewFrom.Clear();
            Analyse analyse = new Analyse();
            resizeLocationForm(analyse);
            BackButton.Visible = false;
            HomeButton.Visible = false;
        }

        private void Home_ResizeBegin(object sender, EventArgs e)
        {
            bunifuImageButton1.Location = new Point(this.Width - bunifuImageButton1.Width - 9, bunifuImageButton1.Location.Y);
            bunifuImageButton2.Location = new Point(bunifuImageButton1.Location.X - bunifuImageButton2.Width - 9, bunifuImageButton2.Location.Y);
            bunifuImageButton3.Location = new Point(bunifuImageButton2.Location.X - bunifuImageButton2.Width - 9, bunifuImageButton3.Location.Y);
            if (HomePreview.ActifForm != null)
            {
                ActifForm.Width = this.Width - XP;
                ActifForm.Height = this.Height - YP;
            }
        }

        private void search_OnTextChange(object sender, EventArgs e)
        {
            int c = 0;
            for (int i = 0; i < ClassButton.Count; i++)
            {
                if (ClassButton[i].Text.ToUpper().Contains(search.text.ToUpper()))
                {
                    if (c == 0)
                    {
                        ClassButton[i].Location = new Point(panel3.Location.X, search.Location.Y + search.Height);
                        c++;
                    }
                    else
                    {
                        ClassButton[i].Location = new Point(panel3.Location.X, ClassButton[i - 1].Height + ClassButton[i - 1].Location.Y);
                    }
                    panel3.Controls.Add(ClassButton[i]);

                }
                else
                {
                    panel3.Controls.Remove(ClassButton[i]);
                }
            }
        }
    }
}
