namespace CustomExceptionExample
{
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }

        private double _currentBalance;

        public double CurrentBalance
        {
            get { return _currentBalance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The value of 'CurrentBalance' should be a positive number");
                }
                _currentBalance = value;
            }
        }

    }

    class InsufficientFundsException : InvalidOperationException
    {
        public InsufficientFundsException() { }

        public InsufficientFundsException(string message) : base(message) { }

        public InsufficientFundsException(string message, Exception innerException) : base(message, innerException) { }
    }

    class FundsTransfer
    {
        public void Transfer(BankAccount sourcAccount, BankAccount destinationAccount, double amount)
        {
            try
            {

                if (amount < 0 || amount > 10000)
                {
                    throw new ArgumentOutOfRangeException("amount", 10000,
                        "For funds transfer the value of the amount should be between 1 to 10000");
                }
                if (sourcAccount == null)
                {
                    throw new ArgumentNullException(nameof(sourcAccount));
                }
                if (amount > sourcAccount.CurrentBalance)
                {
                    throw new InsufficientFundsException("Insufficient balace in the source bank account");
                }
                sourcAccount.CurrentBalance -= amount;
                destinationAccount.CurrentBalance += amount;
            }
            catch (NullReferenceException ex)
            {
                throw new ArgumentNullException("You have supplied null value to 'sourceAccount' patameter");
            }

        }
    }
    class Program
    {
        static void Main()
        {
            try
            {
                BankAccount BobAccount = new BankAccount()
                { AccountNumber = 101, AccountHolderName = "Bob", CurrentBalance = 7000 };
                BankAccount AliceAccount = new BankAccount()
                { AccountNumber = 102, AccountHolderName = "Alice", CurrentBalance = 7000 };
                BankAccount StevenAccount = null;

                FundsTransfer FundsTransfer = new FundsTransfer();

                FundsTransfer.Transfer(StevenAccount, AliceAccount, 3000);
                Console.WriteLine("Funds Transferred");


            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ActualValue);
                Console.WriteLine(ex.ParamName);
            }
        }
    }
}