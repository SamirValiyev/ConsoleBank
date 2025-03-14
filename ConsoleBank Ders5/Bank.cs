using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBank_Ders5
{
    public class Bank:BankService
    {
        const string userName = "admin";
        const string password = "admin";
        public void UserProtection(string name, string surname)
        {
            if (name == userName && surname == password)
            {
                Console.WriteLine("Bankimiza xos geldin Admin");
                Console.WriteLine("Secimler:");
                Console.WriteLine("[0] Cixis");
                Console.WriteLine("[1] Kredit Goturmek");
                Console.WriteLine("[2] Kredit Odemek");
                Console.WriteLine("[3] Hesabat");
                int secimOne = int.Parse(Console.ReadLine());
                BankService service = new();
                service.Service(secimOne);

            }
            else
            {
                Console.WriteLine("Invalid Login");

            }
        }
    }
}
