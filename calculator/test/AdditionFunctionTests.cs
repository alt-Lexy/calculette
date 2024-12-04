using calculator.Operations;
using sharp.calculator;

namespace calculator.test
{
    public class AdditionFunctionTests
    {
        // Naming convension - ClassName_MethodeName_ExpectedResult
        public void AdditionFunction_Addition_ReturnVoid()
        {
            Logger logger = new();
            try
            {
                int firstNb = 2;
                int secondNb = 10;

                IOperation resultat = new Addition(firstNb, secondNb);

                Calculator addition = new Calculator(resultat);

                addition.Execute();

                logger.LoggerFn($"ok => expected: 12 and actual: {addition.Resultat}");

            }
            catch (Exception e)
            {
                logger.LoggerFn($"{e}");
                throw;
            }

        }

    }
}
