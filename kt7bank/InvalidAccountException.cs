namespace BankAccountProject;

public class InvalidAccountException : BankingException
{
    public string AccountId { get; }

    public InvalidAccountException(string accountId)
        : base($"Неверный номер счёта: {accountId}")
    {
        AccountId = accountId;
    }

    public InvalidAccountException() { AccountId = string.Empty; }
    public InvalidAccountException(string message, Exception innerException) : base(message, innerException) { AccountId = string.Empty; }
}
