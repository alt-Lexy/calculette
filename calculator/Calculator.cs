using System;

namespace calculator
{
    public class Calculator
    {
        /// <summary>
        /// Cette méthod permet de logger
        /// </summary>
        /// <param name="valeur"></param>
        public void Logger( string valeur){
            Console.WriteLine(valeur);
        }

        /// <summary>
        /// Cette méthode renvoie le resultat de l'addition de deux nombres
        /// </summary>
        /// <param name="firstNb"></param>
        /// <param name="secondNb"></param>
        /// <returns></returns>
        public int Addition(int firstNb, int secondNb){
            return firstNb + secondNb;
        }

        /// <summary>
        /// Cette méthode renvoie le resultat de la soustraction de deux nombres
        /// </summary>
        /// <param name="firstNb"></param>
        /// <param name="secondNb"></param>
        /// <returns></returns>
        public int Soustraction(int firstNb, int secondNb){
            return firstNb - secondNb;
        }

        /// <summary>
        /// Cette méthode renvoie le resultat de la multiplication de deux nombres
        /// </summary>
        /// <param name="firstNb"></param>
        /// <param name="secondNb"></param>
        /// <returns></returns>
        public int Multiplication(int firstNb, int secondNb){
            return firstNb * secondNb;
        }

        /// <summary>
        /// Cette méthode renvoie le resultat de la division de deux nombres
        /// </summary>
        /// <param name="firstNb"></param>
        /// <param name="secondNb"></param>
        /// <returns></returns>
        public int Division(int firstNb, int secondNb){
            if (secondNb == 0){
                return 0;
            }
            return firstNb / secondNb;
        }

        /// <summary>
        /// Cette méthode renvoie le reste de la division de deux nombres
        /// </summary>
        /// <param name="firstNb"></param>
        /// <param name="secondNb"></param>
        /// <returns></returns>
        public int Modulo(int firstNb, int secondNb){
            return firstNb % secondNb;
        }

        public static implicit operator Calculator(string v)
        {
            throw new NotImplementedException();
        }
    }
}
