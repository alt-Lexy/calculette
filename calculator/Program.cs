using calculator;

Logger logger = new();

logger.LoggerFn("Saisir le premier nombre");
var firstNb = int.Parse(Console.ReadLine());

logger.LoggerFn("Saisir le deuxième nombre");
var secondNb = int.Parse(Console.ReadLine());

Calculator operation = new(firstNb, secondNb);

logger.LoggerFn("Sasir l'opérateur : + ou - ou * ou / ou %");
string sign = Console.ReadLine();

switch (sign)
{
    case "+":
        operation.Addition();
        break;
    case "-":
        operation.Soustraction();
        break;
    case "*":
        operation.Multiplication();
        break;
    case "/":
        operation.Division();
        break;
    case "%":
        operation.Modulo();
        break;
    default:
        logger.LoggerFn("Operateur non reconnu");
        break;
}

logger.LoggerFn($"Le résultat de votre opération est : {operation.Resultat}");
