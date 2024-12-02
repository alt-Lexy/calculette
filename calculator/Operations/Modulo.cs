namespace calculator.Operations
{
    public class Modulo : Operation
    {
        public Modulo(int firstNumber, int secondNumber) : base(firstNumber, secondNumber)
        {
        }
        public override void Excute()
        {
            Resultat = FirstNumber % SecondNumber;
        }
    }
}
