namespace ConsoleBank_Ders5
{
    internal class Program
    {
        public static void Main(string[] args) 
        {

            Console.WriteLine("Zehmet olmasa adinizi daxil edin");
            string userName = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa passwordu daxil edin");
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
