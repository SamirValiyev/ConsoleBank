using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBank_Ders5
{
    public  class BankService
    {
        public int Month { get; set; } = 12;
        public int LoanAmount { get; set; } = 100;

        public int Service(int choice)
        {


            return choice;
        }

        public int NumberofMonthsForPayment(int month)
        {
            return month;
        }
    }
}
