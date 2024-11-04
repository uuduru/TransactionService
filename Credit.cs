// See https://aka.ms/new-console-template for more information

public class Credit : TransactionService    ////// Appel Classe Crédit
{
    public Credit(DateTimeOffset Date, float Amount, string Description)
    {
        ValidationProcess_Credit(Date, Amount, Description);
    }
}