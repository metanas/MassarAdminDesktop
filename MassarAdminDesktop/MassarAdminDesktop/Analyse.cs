using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MassarAdminDesktop
{
    public partial class Analyse : Form
    {
        Form form;
        public Analyse(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void Analyse_Load(object sender, EventArgs e)
        {
            string countetu = DBConnect.Get("SELECT COUNT(id_Etudiant) from etudiant_groupe WHERE id_groupe in (SELECT id from groupe WHERE id_annee =(SELECT id from annee WHERE annee_scolaire='"+ Home.idann +"'))");
            string countprof = DBConnect.Get("select count(*) from enseignant as e , groupe_matiere_enseignant as gme , groupe as g , annee as a where e.id=gme.id_enseignant and gme.id_groupe=g.id and g.id_annee=a.id and  a.annee_scolaire='"+Home.idann+"'");
            string countclasse = Home.nbrClasse.ToString();
            label1.Text = countetu;
            label2.Text = countprof;
            label3.Text = countclasse;           
        }

        private void Analyse_ResizeBegin(object sender, EventArgs e)
        {
            panel1.Location = new Point((this.Width - panel1.Width)/2, (this.Height - panel1.Height)/2);
        }

        private void Betudiant_Click(object sender, EventArgs e)
        {
            ((Bunifu.Framework.UI.BunifuImageButton)form.Controls.Find("HomeButton", true)[0]).Visible = true;
            ((Bunifu.Framework.UI.BunifuImageButton)form.Controls.Find("Back", true)[0]).Visible = true;
            viewetudiant view = new viewetudiant();
            view.TopLevel = false;
            view.Parent = form;
            view.Location = new Point(this.Location.X, this.Location.Y);
            view.Width = this.Width;
            view.Height = this.Height;
            view.Show();
            Home.PreviewFrom[0].Hide();
            Home.AddForm(view);
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            ((Bunifu.Framework.UI.BunifuImageButton)form.Controls.Find("HomeButton", true)[0]).Visible = true;
            ((Bunifu.Framework.UI.BunifuImageButton)form.Controls.Find("Back", true)[0]).Visible = true;
            viewprofesseur viewp = new viewprofesseur();
            viewp.TopLevel = false;
            viewp.Parent = form;
            viewp.Location = new Point(this.Location.X, this.Location.Y);
            viewp.Width = this.Width;
            viewp.Height = this.Height;
            viewp.Show();
            Home.PreviewFrom[0].Hide();
            Home.AddForm(viewp);

        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            ((Bunifu.Framework.UI.BunifuImageButton)form.Controls.Find("HomeButton", true)[0]).Visible = true;
            ((Bunifu.Framework.UI.BunifuImageButton)form.Controls.Find("Back", true)[0]).Visible = true;
            Evolutionperyear view = new Evolutionperyear();
            view.TopLevel = false;
            view.Parent = form;
            view.Location = new Point(this.Location.X, this.Location.Y);
            view.Width = this.Width;
            view.Height = this.Height;
            view.Show();
            Home.PreviewFrom[0].Hide();
            Home.AddForm(view);
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            classview classe = new classview();
            classe.TopLevel = false;
            classe.Parent = form;
            classe.Location = new Point(this.Location.X, this.Location.Y);
            classe.Width = this.Width;
            classe.Height = this.Height;
            classe.Show();
            Home.PreviewFrom[0].Hide();
            Home.AddForm(classe);

        }
    }
}
