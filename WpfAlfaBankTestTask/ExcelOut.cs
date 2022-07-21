
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Excel = Microsoft.Office.Interop.Excel;

namespace WpfAlfaBankTestTask
{
    class ExcelOut
    {
        public void Writer(List<Article> articles)
        {
            SpreadsheetDocument spreadsheetDocument =
            SpreadsheetDocument.Create("Article.xlsx", SpreadsheetDocumentType.Workbook);
            WorkbookPart workbookpart = spreadsheetDocument.AddWorkbookPart();
            workbookpart.Workbook = new Workbook();

            WorksheetPart worksheetPart = workbookpart.AddNewPart<WorksheetPart>();
            worksheetPart.Worksheet = new Worksheet(new SheetData());

            Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild<Sheets>(new Sheets());

            Sheet sheet = new Sheet()
            {
                Id = spreadsheetDocument.WorkbookPart.
                GetIdOfPart(worksheetPart),
                SheetId = 1,
                Name = "news"
            };
            sheets.Append(sheet);


            Worksheet worksheet = new Worksheet();
            worksheetPart.Worksheet = worksheet;

            SheetData sheetData = new SheetData();


            Row row = new Row();
            Cell[,] cells = new Cell[5, 6];
            for (uint rowID = 1; rowID < articles.Count + 1; rowID++)
            {
                row = new Row() { RowIndex = rowID };

                cells[0, rowID] = new Cell()
                {
                    CellReference = "A" + rowID,
                    DataType = CellValues.String,
                    CellValue = new CellValue(articles[Convert.ToInt32(rowID) - 1].Title())
                };
                cells[1, rowID] = new Cell()
                {
                    CellReference = "B" + rowID,
                    DataType = CellValues.String,
                    CellValue = new CellValue(articles[Convert.ToInt32(rowID) - 1].Link())
                };
                cells[2, rowID] = new Cell()
                {
                    CellReference = "C" + rowID,
                    DataType = CellValues.String,
                    CellValue = new CellValue(articles[Convert.ToInt32(rowID) - 1].Description())
                };
                cells[3, rowID] = new Cell()
                {
                    CellReference = "D" + rowID,
                    DataType = CellValues.String,
                    CellValue = new CellValue(articles[Convert.ToInt32(rowID) - 1].Category())
                };
                cells[4, rowID] = new Cell()
                {
                    CellReference = "E" + rowID,
                    DataType = CellValues.String,
                    CellValue = new CellValue(articles[Convert.ToInt32(rowID) - 1].PubDate().DayOfWeek.ToString() + ", " +
                        articles[Convert.ToInt32(rowID) - 1].PubDate().ToString())
                };
                for (int i = 0; i < 5; i++)
                    row.Append(cells[i, rowID]);
                sheetData.Append(row);

            }

            worksheet.Append(sheetData);


            spreadsheetDocument.WorkbookPart.Workbook.Save();
            workbookpart.Workbook.Save();

            spreadsheetDocument.Close();






        }



    }
}
