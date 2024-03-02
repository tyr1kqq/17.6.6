namespace _17._6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Account account = new Account();
            account.Type = "Обычный";
            account.Balance = 100000;
            
            Calculator.CalculateInterest(account);
            Console.WriteLine("Interest calculated: " + account.Interest);

            Account account1 = new Account();
            account1.Type = "Зарплатный";
            account1.Balance = 1000;

            Calculator.CalculateInterest(account1);
            Console.WriteLine("Interest calculated: " + account1.Interest);

            Account account2 =new Account();
            account2.Type = "Обычный";
            account2.Balance = 999;

            Calculator.CalculateInterest(account2);
            Console.WriteLine("Interest calculated: " + account2.Interest);

        }
    }
}