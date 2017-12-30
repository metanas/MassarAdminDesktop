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

   
    public partial class Home : Form
    {
        List<ToolStripButton> cl_buttons = new List<ToolStripButton>();
        List<string> id_classes = new List<string>();
        
        public Home()
        {
            InitializeComponent();
            
                utilisateurs.Visible = Login.admin.isSuper;
            annees.Font = new Font("Arial", 14);
            Login.read = DBConnect.Gets("select annee_scolaire from annee order by annee_scolaire desc ; ");
            while (Login.read.Read())
             annees.Items.Add(Login.read["annee_scolaire"]);
            Login.read.Close();
            if (annees.Items.Count > 0)
                annees.SelectedIndex = 0;
                
            
        }

        private void importerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Previw previw = new Previw();
            previw.TopLevel = false;
            previw.Parent = this;
            previw.Show();
            previw.browse();
        }

        private void utilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerer_Admin gerer = new Gerer_Admin();
            gerer.Show();
        }
        private void loadgroupes(string annee) {
            int i = 0;
            foreach (ToolStripButton b in cl_buttons)
                Class_Sel.Items.Remove(b);
            cl_buttons.Clear();
            id_classes.Clear();
            Login.read = DBConnect.Gets("select groupe.nom , groupe.id from groupe , annee where annee.annee_scolaire='"+annee+"' and  annee.id=groupe.id_annee ; ");
            while (Login.read.Read())
            {
                cl_buttons.Add(new ToolStripButton());
                cl_buttons[i].Click += new System.EventHandler(this.groupe);
                cl_buttons[i].Text = Login.read["nom"].ToString();
                cl_buttons[i].Font = new Font("Arial",14);
                id_classes.Add(Login.read["id"].ToString());
                Class_Sel.Items.Add(cl_buttons[i++]);
                
            }
            Login.read.Close();
        }
        
        private void groupe(object sender, EventArgs e) {
           int index =  cl_buttons.IndexOf((ToolStripButton)sender);
            string id = id_classes[index];
            MessageBox.Show("replace messageBox by opening classes details \n id de groupe : " + id+" , le nom de groupe : "+ ((ToolStripButton)sender).Text);
            
            //replace messageBox by opening classes details

        }

        private void annees_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            loadgroupes(annees.SelectedItem.ToString());
        }
    }
}
