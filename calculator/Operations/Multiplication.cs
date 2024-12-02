namespace calculator.Operations
{
    public class Multiplication : Operation
    {
        public Multiplication(int firstNumber, int secondNumber) : base(firstNumber, secondNumber)
        {
        }

        public override void Excute()
        {
            Resultat = FirstNumber * SecondNumber;
        }
    }
}
