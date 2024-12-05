using calculator.Operations;

namespace calculator
{
    public class Calculator
    {
        public IOperation Operation { get; }

        public int Resultat => Operation.Resultat;
        public Calculator(IOperation operation)
        {
            Operation = operation;
        }

        public void Execute()
        {
            Operation.Execute();

        }
    }
}
