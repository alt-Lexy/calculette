namespace calculator.Operations
{
    public class Addition : Operation
    {
        public Addition(int firstNumber, int secondNumber) : base(firstNumber, secondNumber)
        {
        }

        public override void Execute()
        {
            Resultat = FirstNumber + SecondNumber;
        }

    }
}
