namespace BankV05
{
    /// <summary>
    /// This class represents a very simple bank account.
    /// Only the amount of money on the account is represented.
    /// </summary>
    public class BankAccount
    {
        private double _balance;
        private string _nameAH;
        private int _age;

        public BankAccount(string nameAH, int age)
        {
            _balance = 0.0;
            _nameAH = nameAH;
            _age = age;
        }

        public string accountHoldName
        {
            get {return _nameAH;}
        }

        public int ageofperson
        {
            get {return _age;}
        }

        public double Balance
        {
            get { return _balance;}
        }

        public void Deposit(double amount)
        {
            _balance = _balance + amount;
        }

        public void Withdraw(double amount)
        {
            _balance = _balance - amount;
        }
    }
}