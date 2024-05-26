using ClosedXML.Excel;
using ClosedXML.Excel.Drawings;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Drawing;
using System.Net;
using System.Security.Cryptography.X509Certificates;
namespace ReadDataFromExcel
{
    public class ExcelReader
    {
        //string cs = Parameters.WriteToLog(Parameters.excelFilePath);
        public ExcelReader()
        {
            // excelFilePath = Parameters.excelFilePath;
        }

        public List<MemberDto> Members = new();
        public void ReadData()
        {
            //please
            using (var workbook = new XLWorkbook(Parameters.excelFilePath))
            {
                string ID;
                string Name;
                string Address;
                string TotalCost;
                string Date;
                string Payment;
                bool IsPaid;


                IXLWorksheet sheet = workbook.Worksheet(Parameters.city);

                foreach (var row in sheet.RowsUsed())
                {
                    if (row.Cell(11).Value.ToString() == "TRUE")
                    {
                        ID = row.Cell(1).Value.ToString();
                        Name = row.Cell(2).Value.ToString();
                        Address = $"{row.Cell(3).Value}-{row.Cell(4).Value}";
                        TotalCost = row.Cell(10).Value.ToString();
                        Date = row.Cell(8).Value.ToString();
                        Payment = row.Cell(9).Value.ToString();

                        Members.Add(new MemberDto(ID, Name, Address, TotalCost, Date, Payment));
                    }
                }

            }
        }



        public MemberDto GetMemberFromName(string name)
        {
            foreach (MemberDto member in Members)
            {
                if (member.Name == name) return member;
            }
            return new MemberDto();
        }

        public MemberDto GetMemberFromId(string id)
        {
            foreach (MemberDto member in Members)
            {
                if (member.Id == id) return member;
            }
            return null;
        }
    }
}
