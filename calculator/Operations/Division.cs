namespace calculator.Operations
{
    public class Division : Operation
    {
        public Division(int firstNumber, int secondNumber) : base(firstNumber, secondNumber)
        {
        }

        public override void Excute()
        {
            if (SecondNumber == 0)
            {
                Resultat = 0;
            }
            Resultat = FirstNumber / SecondNumber;
        }
    }
}
