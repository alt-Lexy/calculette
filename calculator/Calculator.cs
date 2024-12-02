using System;

namespace calculator
{
    public class Calculator
    {
        public int Resultat { get; set; }
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        /// <summary>
        /// Cette méthod permet de logger
        /// </summary>
        /// <param name="valeur"></param>
        public void Logger(string valeur)
        {
            Console.WriteLine(valeur);
        }

        /// <summary>
        /// Cette méthode renvoie le resultat de l'addition de deux nombres et renseigne la props Resultat
        /// </summary>
        /// <returns></returns>
        public void Addition()
        {
            Resultat = FirstNumber + SecondNumber;
        }

        /// <summary>
        /// Cette méthode renvoie le resultat de la soustraction de deux nombres et renseigne la props Resultat
        /// </summary>
        /// <returns></returns>
        public void Soustraction()
        {
            Resultat = FirstNumber - SecondNumber;
        }

        /// <summary>
        /// Cette méthode renvoie le resultat de la multiplication de deux nombres et renseigne la props Resultat
        /// </summary>
        /// <returns></returns>
        public void Multiplication()
        {
            Resultat = FirstNumber * SecondNumber;
        }

        /// <summary>
        /// Cette méthode renvoie le resultat de la division de deux nombres et renseigne la props Resultat
        /// </summary>
        /// <returns></returns>
        public void Division()
        {
            if (SecondNumber == 0)
            {
                Resultat = 0;
            }
            Resultat = FirstNumber / SecondNumber;
        }

        /// <summary>
        /// Cette méthode renvoie le reste de la division de deux nombres et renseigne la props Resultat
        /// </summary>
        /// <returns></returns>
        public void Modulo()
        {
            Resultat = FirstNumber % SecondNumber;
        }
    }
}
