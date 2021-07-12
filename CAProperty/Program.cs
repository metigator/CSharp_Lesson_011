using System;

namespace CAProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Dollar dollar = new Dollar(1.99m);
            dollar.SetAmount(0m); // set 
            Console.WriteLine(dollar.Amount); // get 
            Console.WriteLine(dollar.IsZero); // get 
            Console.ReadKey();
        }
    } 

    public class Dollar
    {
        private decimal _amount; // 1.99, 120.99, 5.00   [1.009 => 1.01]

        public decimal Amount
        {
            get
            {
                return this._amount;
            }
            private set
            {
                // validation
                this._amount = ProcessValue(value);
            }
        }
        
        public bool IsZero
        {
            get
            {
                return _amount == 0;
            }
        }

        public void SetAmount(decimal value)
        {
            Amount = value;
        }

        public Dollar(decimal amount)
        {
            this._amount = ProcessValue(amount);
        }

        private decimal ProcessValue(decimal value) => value <= 0 ? 0 : Math.Round(value, 2);
    }
}
