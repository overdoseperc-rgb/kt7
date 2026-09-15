namespace BankAccountProject;

public class InsufficientFundsException : BankingException
{
    public decimal RequestedAmount { get; }
    public decimal AvailableBalance { get; }

    public InsufficientFundsException(decimal requestedAmount, decimal availableBalance)
        : base($"Недостаточно средств. Запрошено: {requestedAmount}, доступно: {availableBalance}")
    {
        RequestedAmount = requestedAmount;
        AvailableBalance = availableBalance;
    }

    public InsufficientFundsException() { }
    public InsufficientFundsException(string message) : base(message) { }
    public InsufficientFundsException(string message, Exception innerException) : base(message, innerException) { }
}
