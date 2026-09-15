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
                Console.WriteLine($"Баланс: {account.Balance}");
            }
        };

        foreach (var operation in operations)
        {
            try { operation(); }
            catch (InsufficientFundsException ex)
            { Console.WriteLine($"Недостаточно средств: {ex.RequestedAmount}, доступно: {ex.AvailableBalance}"); }
            catch (InvalidAccountException ex)
            { Console.WriteLine($"Неверный счёт: {ex.AccountId}"); }
            catch (BankingException ex)
            { Console.WriteLine(ex.Message); }
        }
    }
}
