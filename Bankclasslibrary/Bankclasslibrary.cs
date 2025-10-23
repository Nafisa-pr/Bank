using Bankclasslibrary;
using System.Runtime.CompilerServices;

namespace Bankclasslibrary
{
    public class Account
    {
        public string AccountHolderName { get; set; }
        public string SortCode { get; set; }
        public string CardNumber { get; set; }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account Details");
            Console.WriteLine($"Account Holder Name: {AccountHolderName}");
            Console.WriteLine($"Sort Code: {SortCode}");
            Console.WriteLine($"Card Number: {CardNumber}");
        }
        public override string ToString()
        {
            return $"Account Holder: {AccountHolderName}, Sort Code: {SortCode}, Card Number: {CardNumber}";
        }
    }
}
   