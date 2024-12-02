using calculator;
using calculator.Operations;

Logger logger = new();

logger.LoggerFn("Saisir le premier nombre");
var firstNb = int.Parse(Console.ReadLine());

logger.LoggerFn("Saisir le deuxième nombre");
var secondNb = int.Parse(Console.ReadLine());

logger.LoggerFn("Sasir l'opérateur : + ou - ou * ou / ou %");
string sign = Console.ReadLine();

// je n'utilise pas de List ou List tuple car je connais la taille de mon tableau
string[] signList = ["+", "-", "/", "*", "%"];

Operation res;

if (!signList.Contains(sign))
{
    return;
};

logger.LoggerFn($"{signList.Contains(sign)}");

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

logger.LoggerFn($"Le résultat de votre opération est : {operationFn.Resultat}");
