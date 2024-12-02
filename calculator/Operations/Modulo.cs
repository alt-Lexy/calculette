namespace calculator.Operations
{
    public class Modulo : Operation
    {
        public Modulo(int firstNumber, int secondNumber) : base(firstNumber, secondNumber)
        {
        }
        public void Excute()
        {
            Resultat = FirstNumber % SecondNumber;
        }
    }
}
