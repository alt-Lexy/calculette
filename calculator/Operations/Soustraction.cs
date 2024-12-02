namespace calculator.Operations
{
    public class Soustraction : Operation
    {
        public Soustraction(int firstNumber, int secondNumber) : base(firstNumber, secondNumber)
        {
        }

        public override void Execute()
        {
            Resultat = FirstNumber - SecondNumber;
        }
    }
}
