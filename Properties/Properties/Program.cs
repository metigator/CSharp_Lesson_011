namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Properties Promote Encapsulation
            // Property is a public way to access private field


            Dollar dollar = new Dollar(1.99m);
            //dollar.Amount = 1.99m;    // public  set
            dollar.SetAmount(1.99m);  // private set
            Console.WriteLine(dollar.Amount);   // get
            Console.WriteLine(dollar.IsZero);

            Console.ReadKey();
        }
    }

    public class Dollar
    {
        // Backing field
        private decimal _amount;  // 1.99 ,120.99 ,5.00
        public decimal Amount
        {
            get
            {
                return this._amount;
            }
            private set
            {
                // Validation
                this._amount = ProcessValue(value);

            }
        }

        // Read Only Property
        public decimal Rate
        {
            get
            {
                return this._amount;
            }

        }

        public bool IsZero => _amount == 0;

        // Property And Initialization
        public decimal ConversionFactor { get; set; } = 1.99m;


        public void SetAmount(decimal value)
        {
            Amount = value;
        }

        public Dollar(decimal amount)
        {
            this._amount = ProcessValue(amount);
        }

        private decimal ProcessValue(decimal value) => value <= 0 ? 0 : Math.Round(value, 2); //[1.009 -> 0.01]
    }
}