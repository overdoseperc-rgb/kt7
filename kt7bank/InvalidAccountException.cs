namespace BankAccountProject;

public class InvalidAccountException : BankingException
{
    public string AccountId { get; }

    public InvalidAccountException(string accountId)
        : base($"Некорректный номер счёта: {accountId}")
    {
        AccountId = accountId;
    }

    public InvalidAccountException() { }
    public InvalidAccountException(string message, Exception innerException) : base(message, innerException) { }
}