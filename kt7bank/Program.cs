namespace BankAccountProject;

class Program
{
    static void Main()
    {
        var operations = new Action[]
        {
            () => new BankAccount("12345", 1000m),
            () => new BankAccount("123456", 1000m).Withdraw(2000m),
            () =>
            {
                var account = new BankAccount("123456", 1000m);
                account.Withdraw(500m);
                Console.WriteLine($"Операция успешна. Баланс: {account.Balance}");
            }
        };

        foreach (var operation in operations)
        {
            try
            {
                operation();
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine("Исключение InsufficientFundsException:");
                Console.WriteLine($"Запрошено: {ex.RequestedAmount}");
                Console.WriteLine($"Доступно: {ex.AvailableBalance}");
            }
            catch (InvalidAccountException ex)
            {
                Console.WriteLine("Исключение InvalidAccountException:");
                Console.WriteLine($"Номер счёта: {ex.AccountId}");
            }
            catch (BankingException ex)
            {
                Console.WriteLine("Общее банковское исключение:");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("--------------------");
        }
    }
}