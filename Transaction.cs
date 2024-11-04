// See https://aka.ms/new-console-template for more information

using System.Text.Json.Nodes;

public class Transaction
{
    private JsonArray _jsonArray;
    public Transaction()
    {
        var jsonArray = new JsonArray();
        this._jsonArray = jsonArray;
    }

    public void AddToHistory(string Type, float Amount_of_transaction, string Description_of_transaction)
    {
        var transaction_info = new JsonObject();
        transaction_info["Date_of_transaction"] = DateTime.Now;
        transaction_info["Type"] = Type;
        transaction_info["Amount_of_transaction"] = Amount_of_transaction;
        transaction_info["Description_of_transaction"] = Description_of_transaction;
        _jsonArray.Add(transaction_info);
    }

    public void ShowHistory()
    {
        Console.WriteLine(_jsonArray);
    }

}
