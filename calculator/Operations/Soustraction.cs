namespace calculator.Operations
{
    public class Soustraction : Operation
    {
        public Soustraction(int firstNumber, int secondNumber) : base(firstNumber, secondNumber)
        {
        }

        public override void Excute()
        {
            Resultat = FirstNumber - SecondNumber;
        }
    }
}
