namespace calculator.Operations
{
    public class Soustraction : Operation
    {
        public Soustraction(int firstNumber, int secondNumber) : base(firstNumber, secondNumber)
        {
        }

        public void Excute()
        {
            Resultat = FirstNumber - SecondNumber;
        }
    }
}
