// Console.Write("helo world");
Console.WriteLine("Welcome to the Bank");

BankAccount account = 
new BankAccount(11000);

// account.balance = 100;

try{
account.makeDeposit(-1);
} catch (Exception ex){
   Console.WriteLine(ex.Message);
}

Console.Write($"Your account ballance is {account.getBalance()} /n");
Console.WriteLine($" Account Number: {account.accountNumber}");


