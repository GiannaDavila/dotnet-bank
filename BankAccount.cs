class BankAccount {

     public string accountNumber {get; set;}
     private decimal balance {get; set;} 
    //  public decimal balance {get; set;} 


    public decimal getBalance(){
        return balance;
    }

     public void makeDeposit(decimal newDeposit) {
        if (newDeposit < 0 ){
            // balance = balance;
            throw new Exception ("deposit was under zero dollars");
        } else {
            balance = balance + newDeposit;
        }
     }

    //constructor
     public BankAccount(){
        accountNumber = "95839";
        balance = 100.01M;

     }


     public BankAccount (string newAccountName){
        accountNumber = "unknown";
        balance = 100.01M;
     }
    public BankAccount(decimal startingBalance){
        accountNumber = "unknown";
        balance = 100.01M;

        if(startingBalance > 10000){
            balance = startingBalance + 2000;
        } else {
             balance = startingBalance + 100.01M;
        }
    }
}