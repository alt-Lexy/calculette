﻿using System.Text;
using calculette.calcul;
using calculette.calcul.Operations;

Console.ForegroundColor = ConsoleColor.Green;

// ----------------------------------------------
/*Console.WriteLine("Enter your age");
string age = Console.ReadLine();
int adult = 18;
int ageParsed = int.Parse(age);

if (ageParsed >= adult)
{
    Console.WriteLine($"Vous etes majeur");
    return; // si la personne est majeur c'est inutile d'aller plus loin, c'est pour ca que je mets l'instruction return 
}

Console.WriteLine($"Vous etes mineur");*/

// ----------------------------------------------

/*Console.WriteLine("Enter your name");
string name = Console.ReadLine();
Console.WriteLine($"Hello, {name}");
int age = 6;
// interpolation can be enhanced, i want to test int.toString
Console.WriteLine($"j'ai {age.ToString()} d'experience en developpement");*/


// ----------------------------------------------

/*try
{
    Console.WriteLine("Enter your name");
    string name = Console.ReadLine();
    Console.WriteLine("Hello, " + name);
    Console.WriteLine("enter your age");
    int age = int.Parse(Console.ReadLine());
    Console.WriteLine("Merci, nous avons pris en compte votre age");
}
catch (Exception)
{
    Console.WriteLine("votre age n'est pas correct");
    throw;
}*/
// ----------------------------------------------


Logger logger = new();
var firstNb = 0;
var secondNb = 0;


void sasir(string typeNombre)
{
    var isValidNb = false;

    while (isValidNb.Equals(false))
    {
        logger.LoggerFn($"Saisir le {typeNombre} nombre");
        string nb_str = Console.ReadLine();
        try
        {
            var operartionNb = int.Parse(nb_str);
            if (operartionNb < 0)
            {
                isValidNb = false;
                continue;
            }

            if (typeNombre.Equals("premier"))
            {
                firstNb += operartionNb;
                break;
            }

            secondNb += operartionNb;

            isValidNb = true;

        }
        catch (Exception e)
        {

            logger.LoggerFn($"Err, vous devez rentrer un nombre valid. Details: {e.Message}");
        }

    }
}

sasir("premier");
sasir("second");

logger.LoggerFn("Sasir l'opérateur : + ou - ou * ou / ou %");
string sign = Console.ReadLine();

// je n'utilise pas de List ou List tuple car je connais la taille de mon tableau
string[] signList = ["+", "-", "/", "*", "%"];

IOperation res;

if (!signList.Contains(sign))
{
    logger.LoggerFn("Opérateur non reconnu");
    return;
};

logger.LoggerFn($"Opérateur reconnu: {signList.Contains(sign)}");

switch (sign)
{
    case "+":
        res = new Addition(firstNb, secondNb);
        break;
    case "-":
        res = new Soustraction(firstNb, secondNb);
        break;
    case "*":
        res = new Multiplication(firstNb, secondNb);
        break;
    case "/":
        res = new Division(firstNb, secondNb);
        break;
    case "%":
        res = new Modulo(firstNb, secondNb);
        break;
    default:
        return;
}

Calculator operationFn = new(res);
operationFn.Execute();

/*logger.LoggerFn($"Le résultat de votre opération est : {operationFn.Resultat}");*/

StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append("Le résultat de votre opération est: ").Append(operationFn.Resultat);
logger.LoggerFn(stringBuilder.ToString());

