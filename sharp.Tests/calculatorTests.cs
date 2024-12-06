using calculette.calcul;
using calculette.calcul.Operations;

namespace calcuetteSharp.Tests
{
    public class calculatorTests
    {
        [Fact]
        public void AdditionFunction_Addition_ReturnVoid()
        {
            try
            {
                int firstNb = 2;
                int secondNb = 10;
                int expected = 12;
                IOperation resultat = new Addition(firstNb, secondNb);
                Calculator addition = new Calculator(resultat);
                addition.Execute();
                Assert.Equal(expected, addition.Resultat);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }

        [Fact]
        public void SoustractionFunction_Soustraction_ReturnVoid()
        {
            try
            {
                int firstNb = 10;
                int secondNb = 2;
                int expected = 8;
                IOperation resultat = new Soustraction(firstNb, secondNb);
                Calculator addition = new Calculator(resultat);
                addition.Execute();
                Assert.Equal(expected, addition.Resultat);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }

        [Fact]
        public void MultiplicationFunction_Multiplication_ReturnVoid()
        {
            try
            {
                int firstNb = 2;
                int secondNb = 10;
                int expected = 20;
                IOperation resultat = new Multiplication(firstNb, secondNb);
                Calculator addition = new Calculator(resultat);
                addition.Execute();
                Assert.Equal(expected, addition.Resultat);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }     

        [Fact]
        public void DivisionFunction_Division_ReturnVoid()
        {
            try
            {
                int firstNb = 10;
                int secondNb = 2;
                int expected = 5;
                IOperation resultat = new Division(firstNb, secondNb);
                Calculator addition = new Calculator(resultat);
                addition.Execute();
                Assert.Equal(expected, addition.Resultat);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }

        [Fact]
        public void DivisionFunction_Division_ReturnZero()
        {
            try
            {
                int firstNb = 10;
                int secondNb = 0;
                int expected = 0;
                IOperation resultat = new Division(firstNb, secondNb);
                Calculator addition = new Calculator(resultat);
                addition.Execute();
                Assert.Equal(expected, addition.Resultat);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }

        [Fact]
        public void ModuloFunction_Modulo_ReturnVoid()
        {
            try
            {
                int firstNb = 10;
                int secondNb = 5;
                int expected = 0;
                IOperation resultat = new Modulo(firstNb, secondNb);
                Calculator addition = new Calculator(resultat);
                addition.Execute();
                Assert.Equal(expected, addition.Resultat);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }
    }
}