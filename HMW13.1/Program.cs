
Account heikkisAccount = new Account("Heikki's account", 100.00);
Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 1000000.00);                                                                                                                                              
                                                                                                                                                                                                                                         
heikkisAccount.Withdrawal(20);                                                                                                                                                                                                         
Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.Balance);                                                                                                                                                
                                                                  
heikkisSwissAccount.Deposit(200);
Console.WriteLine("The balance of Heikki's other account is now: " + heikkisSwissAccount.Balance);


public class Account
{
    public string Name { get; }
    private double _balance;

    public double Balance
    {
        get { return _balance; }
    }

    public Account(string name, double initialBalance)
        {
        Name = name;
        _balance = initialBalance;
        }

    public void Deposit(double amount)
    {
        if (amount > 0)
            _balance += amount;
    }
    
    public void Withdrawal(double amount)
    {
        if (amount > 0 && _balance - amount >= 0)
            _balance -= amount;                                                                                                                                                                                                        
    }
}
