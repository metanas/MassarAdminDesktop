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
    public partial class Groupe : Form
    {
        string groupe;


        public Groupe(string groupe)
        {
            InitializeComponent();
            this.groupe = groupe;
            this.groupe_l.Text = groupe;
        }
    }
}
