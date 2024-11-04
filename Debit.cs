// See https://aka.ms/new-console-template for more information

public class Debit : TransactionService    ////// Appel Classe Débit
{
    public Debit(DateTimeOffset Date, float Amount, string Description, float Balance)
    {
        ValidationProcess_Debit(Date, Amount, Description, Balance);
    }
}
