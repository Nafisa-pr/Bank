using Bankclasslibrary;

// Normal Account
Account account = new Account("Meghan Markle", "12-23-23", "1234 4532 2322 1211", 1000);
account.DisplayAccountDetails();
account.Deposit(500);
account.Withdraw(200);
Console.WriteLine(account);

// OverDraftAccount
OverDraftAccount overdraft = new OverDraftAccount("Harry Windsor", "33-44-55", "1111 2222 3333 4444", 1500);
overdraft.DisplayAccountDetails();
overdraft.Withdraw(1600);  // within overdraft limit
overdraft.Withdraw(100);   // may hit overdraft limit
Console.WriteLine(overdraft);

Console.WriteLine("\nThank you for banking with Nafisa Bank!"); 