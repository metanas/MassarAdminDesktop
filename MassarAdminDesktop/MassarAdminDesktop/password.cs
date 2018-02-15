using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.IO;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace MassarAdminDesktop
{
    class password
    {
        public Document document;
        string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "C:\\Fonts\\ARIALUNI.TTF");
        BaseFont bf;
        Font myfont;
        public password(string nom, string prenom, string pass,string directory) {

            bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            document = new Document();
            myfont = new Font(bf, 12, Font.NORMAL);

            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(directory, FileMode.Create));
            document.Open();
            PdfPTable table = new PdfPTable(2);
            PdfPCell cell = new PdfPCell(new Phrase(nom+"  "+prenom, myfont));
            cell.HorizontalAlignment = 1;
            cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            table.AddCell(cell);
            cell=new PdfPCell(new Phrase(pass, myfont));
            cell.HorizontalAlignment = 1;
            cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            table.AddCell(cell);
            document.Add(table);
            document.Close();

        }
    }
}
