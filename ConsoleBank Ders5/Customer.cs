using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBank_Ders5
{
    public class Customer
    {
        public  string Name { get; set; } = "Customer1";
        public  string Surname { get; set; } = "Customer1";
        public decimal CardBalance { get; set; } = 100;
        public decimal MonthlyDebt { get; set; } = 0;
        public decimal TotalDebt { get; set; } = 0;
    }
}
