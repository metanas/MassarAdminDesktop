using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace MassarAdminDesktop
{


    public partial class Home : MaterialSkin.Controls.MaterialForm
    {
        List<Bunifu.Framework.UI.BunifuFlatButton> cl_buttons = new List<Bunifu.Framework.UI.BunifuFlatButton>();
        List<string> id_classes = new List<string>();
        Analyse analyse;
        public static string id;
        public static string nomgr;
        public static string idann;
        Login login;
        Bunifu.Framework.UI.BunifuFlatButton lastClick;
        public static Form ActifForm;
        public static List<Form> PreviewFrom = new List<Form>();
        public Home(Login login)
        {
            InitializeComponent();
            this.login = login;
            loadHome();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue800, MaterialSkin.Primary.Blue700, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            SuperUser.Visible = Login.admin.isSuper;
            annees.Font = new Font("Arial", 14);
            annees.Items.Clear();
            Login.read = DBConnect.Gets("select annee_scolaire from annee order by annee_scolaire desc ; ");
            while (Login.read.Read())
                annees.Items.Add(Login.read["annee_scolaire"].ToString());
            Login.read.Close();
            if (annees.Items.Count > 0)
                annees.SelectedIndex = 0;
            loadgroupes(annees.SelectedItem.ToString());
        }
        public void loadHome()
        {
            analyse = new Analyse();
            analyse.TopLevel = false;
            analyse.Parent = this;
            analyse.Location = new Point(panel1.Width, bunifuSeparator1.Location.Y);
            analyse.Width = this.Width - panel1.Width;
            analyse.Height = this.Height - bunifuSeparator1.Location.Y;
            analyse.Show();
            PreviewFrom.Add(analyse);
        }
        public void loadgroupes(string annee)
        {
            int i = 0;
            foreach (var b in cl_buttons)
            {
                if (b.GetType() == typeof(Bunifu.Framework.UI.BunifuFlatButton))
                {
                    panel1.Controls.Remove((Bunifu.Framework.UI.BunifuFlatButton)b);
                }
            }
            cl_buttons.Clear();
            id_classes.Clear();
            Login.read = DBConnect.Gets("select groupe.nom , groupe.id from groupe , annee where annee.annee_scolaire='" + annee + "' and  annee.id=groupe.id_annee ; ");
            while (Login.read.Read())
            {
                cl_buttons.Add(new Bunifu.Framework.UI.BunifuFlatButton());
                cl_buttons[i].Size = new Size(panel1.Width, 48);
                cl_buttons[i].BackColor = Color.FromArgb(65, 105, 225);
                cl_buttons[i].Activecolor = Color.FromArgb(45, 85, 205);
                cl_buttons[i].Normalcolor = Color.FromArgb(65, 105, 225);
                cl_buttons[i].OnHovercolor = Color.FromArgb(60, 100, 220);
                cl_buttons[i].Click += new System.EventHandler(this.groupe);
                cl_buttons[i].Text = Login.read["nom"].ToString();
                cl_buttons[i].IsTab = true;
                if (i == 0)
                {
                    cl_buttons[i].Location = new Point(panel1.Location.X, search.Location.Y + search.Height);
                }
                else { cl_buttons[i].Location = new Point(panel1.Location.X, cl_buttons[i - 1].Location.Y + cl_buttons[i - 1].Height); }
                id_classes.Add(Login.read["id"].ToString());
                panel1.Controls.Add(cl_buttons[i++]);

            }

            Login.read.Close();
        }

        private void groupe(object sender, EventArgs e)
        {
            for (int i = 0; i < cl_buttons.Count; i++)
            {
                if (cl_buttons[i] == ((Bunifu.Framework.UI.BunifuFlatButton)sender))
                {
                    id = id_classes[i];
                    break;
                }
            }

            nomgr = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text;
            if (lastClick != null) lastClick.selected = false;
            lastClick = (Bunifu.Framework.UI.BunifuFlatButton)sender;
            lastClick.selected = true;
            analyse.Hide();
            //MessageBox.Show("replace messageBox by opening classes details \n id de groupe : " + id+" , le nom de groupe : "+ ((ToolStripButton)sender).Text);
            Groupe Groupe_Form = new Groupe(id, Home.nomgr);
            Groupe_Form.TopLevel = false;
            Groupe_Form.Parent = this;
            Groupe_Form.Location = new Point(panel1.Width, bunifuSeparator1.Location.Y);
            Groupe_Form.Show();
            if (ActifForm != null)
            {
                Home.PreviewFrom.Add(ActifForm);
                Home.ActifForm.Hide();
            }
            Home.ActifForm = Groupe_Form;
            Home_ResizeBegin(sender, e);
            Back.Visible = true;
            HomeButton.Visible = true;
            //replace messageBox by opening classes details

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            analyse.Hide();
            Previw previw = new Previw();
            previw.TopLevel = false;
            previw.Parent = this;
            previw.Location = new Point(panel1.Width, bunifuSeparator1.Location.Y);
            previw.Show();
            if (ActifForm != null)
            {
                Home.PreviewFrom.Add(ActifForm);
                Home.ActifForm.Hide();
            }
            Home.ActifForm = previw;
            Home_ResizeBegin(sender,e);
        }

        private void SuperUser_Click(object sender, EventArgs e)
        {
            Gerer_Admin gerer = new Gerer_Admin();
            gerer.Show();
            if (ActifForm != null)
            {
                Home.PreviewFrom.Add(ActifForm);
                Home.ActifForm.Hide();
            }
            Home.ActifForm = gerer;

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        public void annees_SelectedIndexChanged_1(object sender, EventArgs e)
        {
             idann = annees.SelectedItem.ToString();
            loadgroupes(idann);
        }

        private void Home_ResizeBegin(object sender, EventArgs e)
        {
            bunifuImageButton1.Location = new Point(this.Width - bunifuImageButton1.Width - 5, bunifuImageButton1.Location.Y);
            bunifuImageButton2.Location = new Point(bunifuImageButton1.Location.X - bunifuImageButton2.Width - 5, bunifuImageButton2.Location.Y);
            SuperUser.Location = new Point(bunifuImageButton2.Location.X - SuperUser.Width - 5, SuperUser.Location.Y);
            analyse.Width = this.Width - panel1.Width;
            analyse.Height = this.Height - bunifuSeparator1.Location.Y;
            if(ActifForm != null)
            {
                ActifForm.Width = this.Width - panel1.Width;
                ActifForm.Height = this.Height - bunifuSeparator1.Location.Y;
            }
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (Home.PreviewFrom.Count >= 1)
            {
                Home.PreviewFrom[PreviewFrom.Count - 1].Show();
                Home.ActifForm.Close();
                Home.ActifForm = PreviewFrom[PreviewFrom.Count - 1];
                Home.PreviewFrom.Remove(ActifForm);
            }
            if (Home.PreviewFrom.Count == 1)
            {
                Home_Click(sender, e);
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            if(Home.ActifForm != null)
                Home.ActifForm.Close();
            Back.Visible = false;
            HomeButton.Visible = false;
            foreach (Form from in PreviewFrom)
            {
                from.Close();
            }
            PreviewFrom.Clear();
            loadHome();

        }

        private void search_OnTextChange(object sender, EventArgs e)
        {
            int c = 0;
            for(int i=0; i< cl_buttons.Count;i++)
            {
                if (cl_buttons[i].Text.ToUpper().Contains(search.text.ToUpper()))
                {
                    if (c == 0)
                    {
                        cl_buttons[i].Location = new Point(panel1.Location.X, search.Location.Y + search.Height);
                        c++;
                    }
                    else
                    {
                        cl_buttons[i].Location = new Point(panel1.Location.X, cl_buttons[i-1].Height + cl_buttons[i-1].Location.Y);
                    }
                    panel1.Controls.Add(cl_buttons[i]);

                }
                else {
                    panel1.Controls.Remove(cl_buttons[i]);
                }
            }
            if(search.text == "")
            {
                //loadgroupes(annees.SelectedItem.ToString());
            }
        }
    }
}
