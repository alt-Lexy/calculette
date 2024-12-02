namespace calculator.Operations
{
    public abstract class Operation
    {
        public int Resultat { get; protected set; }
        protected int FirstNumber { get; }
        protected int SecondNumber { get; }

        // Constructor
        protected Operation(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        public abstract void Excute();
    }
}
