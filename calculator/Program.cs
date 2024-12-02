using calculator;

Calculator operation = new();

operation.Logger("Saisir le premier nombre");
operation.FirstNumber = int.Parse(Console.ReadLine());

operation.Logger("Saisir le deuxième nombre");
operation.SecondNumber = int.Parse(Console.ReadLine());

operation.Logger("Sasir l'opérateur : + ou - ou * ou / ou %");
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
        operation.Logger("Operateur non reconnu");
        break;
}

operation.Logger($"Le résultat de votre opération est : {operation.Resultat}");
