using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBank_Ders5
{
    public  class BankService
    {
        private readonly Customer _customer;
        
        public BankService(Customer customer)
        {
            _customer = customer;
            _customer.CardBalance = 140;
           
        }
        public int Month { get; set; } = 12;
        public decimal LoanAmount { get; set; } = 100;
        public int Interest  { get; set; }

        public decimal PublicDebt { get; set; }

        public int Service(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine(@"           Kredit goturmek          
Nece ayliq goturmek isdediyinizi daxil edin:
");
                    Month=int.Parse(Console.ReadLine());
                    Console.WriteLine("Goturmek isdediyiniz meblegi zehmet olmasa qeyd edin:");
                    LoanAmount=int.Parse(Console.ReadLine());
                    if (Month > 0 && LoanAmount > 0)
                    {
                        Interest = Month;  //Faizi Aylarin sayi qeder dinamik etdim.
                        Console.WriteLine($"Faiz derecesi:{Interest}");
                        PublicDebt = LoanAmount + ((LoanAmount * Interest) / 100);
                        Console.WriteLine($"Umumi odenilecek mebleg:{PublicDebt}");
                        Console.WriteLine(@"    Razisiniz?   ");
                        Console.WriteLine(@"[1]Beli      [2]Xeyr");
                        int choice2 = int.Parse(Console.ReadLine());
                        switch (choice2)
                        {
                            case 1:
                                Console.WriteLine("Tebrikler.Emeliyyatiniz ugurla neticelendi.");
                                Console.WriteLine("Kredit Balansiniza elave edildi.");
                                Console.WriteLine($"Yekun borcunuz:{PublicDebt}");
                                _customer.CardBalance = _customer.CardBalance+LoanAmount;
                                Console.WriteLine($"Balansiniz:{_customer.CardBalance}");
                                Console.WriteLine($"Odenis etmek isteyirsinizmi?");
                                Console.WriteLine(@"[1]Beli      [2]Xeyr");
                                int choice3 = int.Parse(Console.ReadLine());
                                if (choice3 == 1)
                                {
                                    Console.WriteLine($"Ayliq odemeli oldugunuz mebleg:{PublicDebt/Month}");
                                    Console.Write("Ay sayi:");
                                    int monthNumber=int.Parse(Console.ReadLine());
                                    Console.Write("Ayliq odenilecek mebleg:");
                                    decimal montlhyDebt = decimal.Parse(Console.ReadLine());
                                    Console.WriteLine(NumberofMonthsForPayment(monthNumber,montlhyDebt));
                                    break;
 
                                }
                                else
                                {
                                    Console.WriteLine("Bizi secdiyiniz ucun tesekkurler!");
                                }
                              
                             break;
                            default:
                                Console.WriteLine("Bizi secdiyiniz ucun tesekkurler!");
                            break;

                        }

                    }
                    else
                    {
                        Console.WriteLine("Ay sayi ve goturmek isdediyiniz mebleg 0-dan boyuk olmalidir.");
                        bool information = true; //
                        while (information)
                        {
                            Month = int.Parse(Console.ReadLine());
                            Console.WriteLine("Goturmek isdediyiniz meblegi zehmet olmasa qeyd edin:");
                            LoanAmount = int.Parse(Console.ReadLine());
                            if (Month > 0 && LoanAmount > 0)
                            {
                                Interest = Month;  //Faizi Aylarin sayi qeder dinamik etdim.
                                Console.WriteLine($"Faiz derecesi:{Interest}");
                                PublicDebt = LoanAmount + ((LoanAmount * Interest) / 100);
                                Console.WriteLine($"Umumi odenilecek mebleg:{PublicDebt}");
                                Console.WriteLine(@"    Razisiniz?   ");
                                Console.WriteLine(@"[1]Beli      [2]Xeyr");
                                int choice2 = int.Parse(Console.ReadLine());
                                switch (choice2)
                                {
                                    case 1:
                                        Console.WriteLine("Tebrikler.Emeliyyatiniz ugurla neticelendi.");
                                        Console.WriteLine("Kredit Balansiniza elave edildi.");
                                        Console.WriteLine($"Yekun borcunuz:{PublicDebt}");
                                        _customer.CardBalance = LoanAmount;
                                        Console.WriteLine($"Balansiniz:{_customer.CardBalance}");
                                        Console.WriteLine($"Odenis etmek isteyirsinizmi?");
                                        Console.WriteLine(@"[1]Beli      [2]Xeyr");
                                        int choice3 = int.Parse(Console.ReadLine());
                                        if (choice3 == 1)
                                        {
                                            Console.Write("Ay sayi:");
                                            int monthNumber = int.Parse(Console.ReadLine());
                                            Console.Write("Ayliq odenilecek mebleg:");
                                            int montlhyDebt = int.Parse(Console.ReadLine());
                                            Console.WriteLine(NumberofMonthsForPayment(monthNumber, montlhyDebt));
                                            break;


                                        }

                                        break;
                                    default:
                                        Console.WriteLine("Bizi secdiyiniz ucun tesekkurler!");
                                        break;

                                }
                                information = false;
                            }
                        }
                    }



                break;

                case 2:
                    Console.Write("Ay sayi:");
                    int monthNumber2 = int.Parse(Console.ReadLine());
                    Console.Write("Ayliq odenilecek mebleg:");
                    decimal montlhyDebt2 = decimal.Parse(Console.ReadLine());
                    Console.WriteLine(NumberofMonthsForPayment(monthNumber2, montlhyDebt2));
                break;
                case 3:
                    Console.WriteLine($"Eziz {_customer.FullName} hesabatiniz asagidaki kimidir.");
                    Console.WriteLine("Hesabat:");
                    Console.WriteLine($"Yekun borcunuz:{PublicDebt}");
                    Console.WriteLine($"Kreditin ay sayi:{Month}");
                    Console.WriteLine($"Faiz:{Interest}");
                break;


            }


            return choice;
        }

        public int NumberofMonthsForPayment(int month,decimal monthlyDebt)
        {
            if (monthlyDebt > 0 && month > 0)
            {
                Console.WriteLine("Odenisiniz ugurla edildi!!");

                PublicDebt = PublicDebt - (monthlyDebt * month);
                Console.Write($"Qalan borcunuz:{PublicDebt}");
                _customer.CardBalance = _customer.CardBalance - (monthlyDebt * month);
                Console.Write($"Qalan balansiniz:{_customer.CardBalance}");
            }
            else
            {
                bool information = true;
                while (information)
                {
                    Console.Write("Ay sayi:");
                    month = int.Parse(Console.ReadLine());
                    Console.Write("Ayliq odenilecek mebleg:");
                    monthlyDebt = int.Parse(Console.ReadLine());
                    if (monthlyDebt > 0 && month > 0)
                    {
                        Console.WriteLine("Odenisiniz ugurla edildi!!");
                        PublicDebt=PublicDebt - (monthlyDebt * month);
                        Console.Write($"Qalan borcunuz:{PublicDebt}");
                        _customer.CardBalance = _customer.CardBalance - (monthlyDebt * month);
                        Console.Write($"Qalan balansiniz:{_customer.CardBalance}");
                        information = false;
                    }

                    
                }
            }
            return month;
        }
        //public int MonthAndLoanForCredit(int month,int loanAmount)
        //{

        //    return loanAmount;
        //}
       
    }
}
