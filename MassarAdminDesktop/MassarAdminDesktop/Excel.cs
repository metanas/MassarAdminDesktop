using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;

namespace WindowsFormsApplication3
{
    class Excel
    {
        XSSFWorkbook workbook;
        ISheet sheet;
        FileStream file;

        public Excel(string Path, string mode = "w")
        {
            switch (mode)
            {
                case "r":
                    {
                        file = new FileStream(string.Format(@"{0}", Path), FileMode.Open, FileAccess.Read);
                        workbook = new XSSFWorkbook(file);
                        break;
                    }
                case "a":
                    {
                        file = new FileStream(string.Format(@"{0}", Path), FileMode.Open, FileAccess.ReadWrite);
                        break;
                    }
                case "w":
                    {
                        file = new FileStream(string.Format(@"{0}", Path), FileMode.Create, FileAccess.Write);
                        workbook = new XSSFWorkbook();
                        break;
                    }
            }
        }

        public void setData(int rowNum, int colNum, string text)
        {
            IRow row = sheet.CreateRow(rowNum);
            ICell cell = row.CreateCell(colNum);
            cell.SetCellValue(text);
        }

        public void setDataList(int rowNum, int colBegin, params String[] list)
        {
            IRow row = sheet.CreateRow(rowNum);
            for (int i = 0; i < list.Length; i++)
            {
                row.CreateCell(i + colBegin).SetCellValue(list[i]);
            }
        }
        public void createSheet(string name)
        {
            sheet = workbook.CreateSheet(name);
        }

        public void save()
        {
            workbook.Write(file);
        }
        public string getSheets()
        {
            return workbook.GetSheetName(0);
        }

        public void setCheet(string sheetName)
        {
            sheet = workbook.GetSheet(sheetName);
        }

        public string getContent(int row, int column)
        {
            if (sheet.GetRow(row) != null)
                return string.Format("{0}", sheet.GetRow(row).GetCell(column));
            return "";
        }

        public void close()
        {
            file.Close();
        }

        public int[] find(string key)
        {
            int row = sheet.LastRowNum;
            for (int i = 0; i <= row; i++)
            {
                if (sheet.GetRow(i) != null)
                {
                    int col = sheet.GetRow(i).LastCellNum;
                    Console.WriteLine(col);
                    for (int j = 0; j <= col; j++)
                    {
                        MessageBox.Show(getContent(i, j));
                        if (getContent(i, j) == key)
                        {
                            return new int[] { i, j };
                        }
                    }
                }
                else { Console.WriteLine(i); }
            }

            return new int[2] { -1, -1 };
        }
    }
}