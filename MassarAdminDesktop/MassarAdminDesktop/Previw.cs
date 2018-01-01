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
    public partial class Previw : Form
    {
        string path,fileName;
        public Previw()
        {
            InitializeComponent();
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                path = open.FileName;
                fileName = open.SafeFileName;
            }
        }


        private void Previw_Load(object sender, EventArgs e)
        {
            Excel excel = new Excel(path, "r");
            excel.setCheet(excel.getSheets());
            int w = 0;
            Label[] label = new Label[] { label10, label11, label12, label13, label14,label15, label16, label17, label18, label19 };
            string q = Controller.checkFile(fileName)[1].ToUpper();
            string[] s = new string[] { "أكاديمية :", "الإقليمية", "مؤسسة", "المستوى  :", "القسم  :", "الاستاذ", "الدورة  :", "نقط :", "المادة", "السنة الدراسية :" };
            if (q == "NOTESCC")
            {
                for (int i = 0; i < excel.find("ID")[0]; i++)
                {
                    try
                    {
                        for (int j = 0; j < excel.sheet.GetRow(i).LastCellNum; j++)
                        {
                            string f = excel.getContent(i, j);
                            if (f.Contains(s[w]))
                            {
                                bool t = true;
                                for (int k = j + 1; k < excel.sheet.GetRow(i).LastCellNum; k++)
                                {
                                    string b = excel.getContent(i, k);
                                    if (b != "" && !s.Contains(b))
                                    {
                                        label[w].Text = excel.getContent(i, k);
                                        w++;
                                        t = false;
                                        break;
                                    }
                                   
                                }
                                if (t) { label[w].Text = ""; w++; }
                            }

                        }
                    }
                    catch { }
                }
                int x = excel.find("ID")[0];
                int y = excel.find("ID")[1];
                for (int i = x; i< excel.GetLastRow(); i++)
                {
                    if(i == x)
                    {
                        int f = 0;
                        dataGridView1.ColumnCount = excel.sheet.GetRow(i).LastCellNum-1;
                        for (int j = y; j < excel.sheet.GetRow(i).LastCellNum; j++) {
                            dataGridView1.Columns[f++].HeaderText = excel.getContent(i,j) +" " + excel.getContent(i+1,j);
                        }

                    }
                    else
                    {
                        dataGridView1.Rows.Add();
                        for(int j = y;j< excel.sheet.GetRow(i+1).LastCellNum; j++)
                        {
                            dataGridView1.Rows[i-x-1].Cells[j - y].Value = excel.getContent(i + 1, j);   
                        }
                    }


                }
            }
        }

    }
}
