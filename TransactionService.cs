// See https://aka.ms/new-console-template for more information

public class TransactionService   ///////// Règles de validation des Process
{
    private DateTimeOffset _Date;
    private float _Montant;
    private string _Description;
    private string _Transaction_Type;
    private bool _OperationSuccess { get; set; } = false;

    public bool get_Operation_status()
    {
        return _OperationSuccess;
    }
    public void ValidationProcess_Credit(DateTimeOffset Date1, float Amount, string Description2)
    {
        try
        {
            if (Amount >= 10000)
            {
               _OperationSuccess = false;
                throw new Exception("Something went wrong...");
            }
            else
            {
                _Date = Date1;
                _Montant = Amount;
                _Description = Description2;
                _OperationSuccess = true;
                _Transaction_Type = "Credit";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("The amount is superior to 10000.");
        }

    }
    public void ValidationProcess_Debit(DateTimeOffset Date1, float Amount, string Description2, float Balance)
    {
        try
        {
            if (Balance - Amount <= -5000)
            {
                _OperationSuccess = false;
                throw new Exception("Something went wrong...");
            }
            else
            {
                _Date = Date1;
                _Montant = Amount;
                _Description = Description2;
                _OperationSuccess = true;
                _Transaction_Type = "Debit";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Operation not possible. Balance will be below -5000.");
        }
    }
}
