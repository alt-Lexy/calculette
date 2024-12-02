using calculator;

Calculator operation = new();

operation.Logger("Saisir le premier nombre");
int firstNb = int.Parse(Console.ReadLine());

operation.Logger("Saisir le deuxième nombre");
int secondNb = int.Parse(Console.ReadLine());

operation.Logger("Sasir l'opérateur : + ou - ou * ou / ou %");
string sign = Console.ReadLine();

int result;
switch (sign)
{
    case "+":
        result = operation.Addition(firstNb, secondNb);
        break;
    case "-":
        result = operation.Soustraction(firstNb, secondNb);
        break;
    case "*":
        result = operation.Multiplication(firstNb, secondNb);
        break;
    case "/":
        result = operation.Division(firstNb, secondNb);
        break;
    case "%":
        result = operation.Modulo(firstNb, secondNb);
        break;
    default:
        result = 0;
        break;
}

operation.Logger($"Le résultat de votre opération est : {result}");
