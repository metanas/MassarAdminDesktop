using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassarAdminDesktop
{
    static class Controller
    {
        public static string checkFile(string path)
        {
            Excel e = new Excel(path, "r");
            int[] isNotes = e.find("نقط المراقبة المستمرة");
            int[] isInfo = e.find("معلومات التلاميذ");

            //string[] d = path.Split('_');
            if (isNotes[0] != -1) return "notes";
            else if (isInfo[0] != -1) return "info";
            return "";
        }
    }
}
