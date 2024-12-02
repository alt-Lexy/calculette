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
            Logger logger = new();
            if (Operation is Addition addition)
            {
                addition.Excute();
                return;
            }
            if (Operation is Soustraction soustraction)
            {
                soustraction.Excute();
                return;
            }
            if (Operation is Multiplication multiplication)
            {
                multiplication.Excute();
                return;
            }
            if (Operation is Division division)
            {
                division.Excute();
                return;
            }
            if (Operation is Modulo modulo)
            {
                modulo.Excute();
                return;
            }
            logger.LoggerFn("Opérateur non reconnu");
        }
    }
}
