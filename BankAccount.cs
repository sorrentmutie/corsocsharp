namespace DemoCorsoCSharp;

public interface IAccountValidator
{
    void Validate(decimal amount);
    event EventHandler<AccountArgs>? Validated;
}

public class SimpleValidator : IAccountValidator
{
    private  decimal top;

    public SimpleValidator(decimal top)
    {
        this.top = top;
    }

    public event EventHandler<AccountArgs>? Validated;

    public void Validate(decimal amount)
    {
        if(amount > top)
        {
            Validated?.Invoke(this, new AccountArgs { Message = "Messaggio 1" });
        } else
        {
            Validated?.Invoke(this, new AccountArgs { Message = "Messaggio 2" });
        }
    }
}


public class AccountArgs: EventArgs
{
    public string? Message { get; set; }
}




public class BankAccount
{
    private IAccountValidator validator;


    public BankAccount()
    {
        validator = new SimpleValidator(100000);
        validator.Validated +=
            (s, e) => _withdrawn?.Invoke(s, e);
    }

    public decimal Balance { get; private set; }
    //public delegate void AccountHandler(object sender, AccountArgs args);
    //public event AccountHandler? WithDrawn;

    private EventHandler<AccountArgs>? _withdrawn;

    public event EventHandler<AccountArgs>? WithDrawn
    {
        add { _withdrawn += value; }
        remove { _withdrawn -= value; }
    }


    public void Deposit(decimal amount)
    {
        Balance += amount;
        validator.Validate(Balance);
    }

    public void Withdraw(decimal amount)
    {
        Balance -= amount;
        //if(Balance < 0)
        //{
        //    _withdrawn?.Invoke(this, new AccountArgs { Message = "ahia!"});
        //}
        validator.Validate(Balance);
    }
}
