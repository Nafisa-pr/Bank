using Bankclasslibrary;
using System.Net.NetworkInformation;


Account account = new Account

{
    AccountHolderName = "Meghan Markle",
    SortCode = "12-23-23",
    CardNumber = "1234 4532 2322 1211"
};

account.DisplayAccountDetails();

Console.WriteLine("\nThank you for banking with Nafisa Bank!");



