namespace ConsoleBank_Ders5
{
    internal class Program
    {
        public static void Main(string[] args) 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Zehmet olmasa adinizi daxil edin");
            Console.ResetColor();
            string userName = Console.ReadLine();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Zehmet olmasa passwordu daxil edin");
            Console.ResetColor();
            string userPassword = Console.ReadLine();

            Customer customer = new Customer();
            customer.Name = userName;
            customer.Surname = userPassword;
            
           
            

            BankService bankService = new BankService(customer);
            Bank bank = new(bankService);
            bank.UserProtection(customer.Name,customer.Surname);
           

           


        }
        
    }
    
    
}
