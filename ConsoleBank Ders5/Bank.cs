using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBank_Ders5
{
    public class Bank
    {
        private readonly BankService _service;
        public Bank(BankService service)
        {
            _service = service;
        }
        const string userName = "admin";
        const string password = "admin";
        public void UserProtection(string name, string surname)
        {
            if (name == userName && surname == password)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"      Bankimiza xos geldin Admin      ");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Secimler:");
                Console.WriteLine("[0] Cixis");
                Console.WriteLine("[1] Kredit Goturmek");
                Console.WriteLine("[2] Kredit Odemek");
                Console.WriteLine("[3] Hesabat");
                Console.ResetColor();
                Console.Write("Secim edin:");
                int secimOne = int.Parse(Console.ReadLine());
                _service.Service(secimOne);
                
               

            }
            else
            {
                Console.WriteLine("Invalid Login");

            }
        }
    }
}
