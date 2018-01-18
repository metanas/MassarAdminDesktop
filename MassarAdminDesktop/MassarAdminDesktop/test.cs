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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
            Application.DoEvents();
            RoundedButton myButton = new RoundedButton();
            myButton.Text = "OK";
            myButton.Location = new Point(20,20);
            myButton.Size = new Size(20, 20);
            this.Controls.Add(myButton);
        }
    }
}
