using calculator.Operations;

namespace calculator
{
    public class Calculator
    {
        public Operation Operation { get; }

        public int Resultat => Operation.Resultat;
        public Calculator(Operation operation)
        {
            Operation = operation;
        }

        public void Execute()
        {
            Operation.Excute();

        }
    }
}
