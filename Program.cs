// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System.Reflection.Metadata;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;


var transactions = new Transaction();

while(true)
{
    Console.WriteLine("Please enter which type of transaction. credit / debit. To view history type 'history'.\n");
    string type_of_transaction = Console.ReadLine();
    
    try
    {
        if (type_of_transaction == "credit")
        {
            Console.WriteLine("Amount of credit:");
            string amount_of_transaction = Console.ReadLine();
            Console.WriteLine("Description:");
            string description = Console.ReadLine();

            var newCredit = new Credit(DateTime.Now, Int32.Parse(amount_of_transaction), description);   //// Valeurs hard-coded
            if (newCredit.get_Operation_status())
            {
                transactions.AddToHistory(type_of_transaction, Int32.Parse(amount_of_transaction), description);
                Console.WriteLine("Successful operation!");

            }
        }
        else if (type_of_transaction == "debit")
        {
            Console.WriteLine("Current Balance:");
            string current_balance = Console.ReadLine();
            Console.WriteLine("Amount to debit:");
            string amount_of_transaction = Console.ReadLine();
            Console.WriteLine("Description:");
            string description = Console.ReadLine();

            var newDebit = new Debit(DateTime.Now, Int32.Parse(amount_of_transaction), description, Int32.Parse(current_balance));    //// Valeurs hard-coded
            if (newDebit.get_Operation_status())
            {
                transactions.AddToHistory(type_of_transaction, Int32.Parse(amount_of_transaction), description);
                Console.WriteLine("Successful operation!");
            }
        }
        else if(type_of_transaction == "history")
        {
            transactions.ShowHistory();
        }
        else
        {
            throw new Exception("Oops");
        }

    }
    catch (Exception ex) { Console.WriteLine("Sorry, I didn't understand your choice."); }
}
