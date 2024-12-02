namespace calculator.Operations
{
    public class Operation
    {
        public int Resultat { get; set; }
        public int FirstNumber { get; }
        public int SecondNumber { get; }

        // Constructor
        public Operation(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }
    }
}
