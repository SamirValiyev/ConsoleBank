namespace ConsoleBank_Ders5
{
    internal class Program
    {
        public static void Main(string[] args) 
        {
            const string admin= "admin";
            const string password = "admin";

            string userName=Console.ReadLine();
            string userPassword = Console.ReadLine();

            if(admin==userName && password==userPassword)
            {
                Console.WriteLine("Bankimiza xos geldin Admin");
                Console.WriteLine("Secimler:");
                Console.WriteLine("[0] Cixis");
                Console.WriteLine("[1] Kredit Goturmek");
                Console.WriteLine("[2] Kredit Odemek");
                Console.WriteLine("[3] Hesabat");
                int secimOne =int.Parse(Console.ReadLine());
                Program.ExtentisonMethod(secimOne);

            }
            else
            {
                Console.WriteLine("Invalid Login");
            }


        }
        public static int ExtentisonMethod(int secim)
        {
            int balans = 0;  
            int aylarinSayi = 0;  //iterasiyada secdiyim ay sayi 
            int ayliqBorc=0;
            int umumiBorc=0;
            int odenilecekAySayi = 1;
            switch (secim)
            {
                 
                case 1:
                    Console.WriteLine(@"           Kredit goturmek          
Nece ayliq goturmek isdediyinizi daxil edin:
");
                     aylarinSayi = int.Parse(Console.ReadLine());
                     
                     
                    Console.WriteLine("Goturmek isdediyiniz meblegi daxil edin:");
                    int mebleg= int.Parse(Console.ReadLine());
                   
                    if(aylarinSayi>0 && mebleg > 0)
                    {
                        Console.WriteLine("Faiz Derecesi:12%");
                        int umumiodenecekMebleg = mebleg + (mebleg * 12 / 100);
                        Console.WriteLine($"Umumi odenecek mebleg:{umumiodenecekMebleg}");
                        int ayliqOdenilecekMebleg = umumiodenecekMebleg / aylarinSayi;
                        ayliqBorc=ayliqBorc+ayliqOdenilecekMebleg;
                        Console.WriteLine($"Ayliq odenilecek mebleg:{ayliqOdenilecekMebleg}");
                        Console.WriteLine(@"    Razisiz?  
                         [1] Beli          [2] Xeyr
");
                         int razisiz = int.Parse(Console.ReadLine());
                        if(razisiz == 1)
                        {
                            Console.WriteLine("Kreditiniz yekunlasdi.Tebrikler !!");
                            Console.WriteLine("Kredit balansiniza elave olundu");
                            balans = balans + mebleg;
                            umumiBorc = umumiBorc + umumiodenecekMebleg;
                            Console.WriteLine($"Balansiniz:{balans}");
                            Console.WriteLine($"Umumi Borcunuz:{umumiBorc}");
                            Console.WriteLine(@"Kreditinizi odemek isteyirsinizmi?
                              [1].Beli
                              [2].Xeyr
 
"
);
                            int secimtwo=int.Parse(Console.ReadLine());
                            if (secimtwo == 1)
                            {
                                Console.WriteLine("Kreditinizi odemek ucun ayliq meblegi daxil edin:");
                                int odeme2 = int.Parse(Console.ReadLine());
                                if (odeme2 > balans)
                                {
                                    Console.WriteLine("Odenis balansdan cox ola bilmez");
                                    break;
                                }
                                else if (odeme2 == balans)
                                {
                                    Console.WriteLine("Kreditiniz yekunlasdi.Tebrikler !!");
                                    break;
                                }
                                else
                                {
                                    while (balans > 0 && aylarinSayi > 0)
                                    {
                                        if (odenilecekAySayi > 0)
                                        {
                                            balans = balans - (odenilecekAySayi * odeme2);
                                            umumiBorc = umumiBorc - (odenilecekAySayi * odeme2);
                                            aylarinSayi = aylarinSayi - odenilecekAySayi;
                                            Console.WriteLine($"Qalan borcunuz:{umumiBorc}");
                                            Console.WriteLine($"Qalan balans:{balans}");
                                            break;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Muracietiniz ucun tesekkurler");
                                break;
                            }

                            break;
                        }
                        else
                        {
                            Console.WriteLine("Muracietiniz ucun tesekkurler");
                            break;
                        }

                    }
                    break;
                case 2:
                    Console.WriteLine(@"           Kredit odemek
Zehmet olmasa ayliq meblegi daxil edin:
Odemek isdediyiniz ay sayi:
");
                    int odeme = int.Parse(Console.ReadLine());
                    int odemekIsdediyimizAySayi=int.Parse(Console.ReadLine());
                    if (odeme > balans)
                    {
                        Console.WriteLine("Odenis balansdan cox ola bilmez");
                        break;

                    }
                    else if (odeme == balans)
                    {
                        Console.WriteLine("Kreditiniz yekunlasdi.Tebrikler !!");
                        break;
                    }
                    else
                    {
                        //if (odeme > ayliqOdenilecekMebleg)
                        //{

                        //}

                        while (balans>0 &&  aylarinSayi>0)
                        {
                            if (odemekIsdediyimizAySayi > 0)
                            {
                                balans = balans - (odemekIsdediyimizAySayi * odeme);
                                umumiBorc = umumiBorc - (odemekIsdediyimizAySayi * odeme);
                                aylarinSayi = aylarinSayi - odemekIsdediyimizAySayi;
                                Console.WriteLine($"Qalan borcunuz:{umumiBorc}");
                                Console.WriteLine($"Qalan balans:{balans}");
                                break;
                            }
                          
                        }
                    }
                break;
                case 3:
                    Console.WriteLine("Bankimiz 2005 ci ilden fealiyyet gostermekdedir");
                break;
                default:
                    Console.WriteLine("Cixis olundu");
                    break;

            }

            return secim;
           
        }

    }
    
    
}
