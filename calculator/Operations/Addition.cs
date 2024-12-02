namespace calculator.Operations
{
    public class Addition : Operation
    {
        public Addition(int firstNumber, int secondNumber) : base(firstNumber, secondNumber)
        {
        }

        public override void Excute()
        {
            Logger logger = new();
            Resultat = FirstNumber + SecondNumber;
        }

    }
}
