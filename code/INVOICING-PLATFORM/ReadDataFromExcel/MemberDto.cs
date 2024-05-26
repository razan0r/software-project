/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadDataFromExcel
{
    internal class MemberDto
    {
    }
}*/
using System.Drawing;

namespace ReadDataFromExcel
{
    public class MemberDto

    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string TotalCost { get; set; }
        public string Address { get; set; }
        public string Date { get; set; }
        public string Payment { get; set; }

        public MemberDto() { }
        public MemberDto(string id, string name, string address, string totalcost, string date, string payment)
        {
            Id = id;
            Name = name;
            TotalCost = totalcost;
            Address = address;
            Date = date;
            Payment = payment;
        }
    }
}
