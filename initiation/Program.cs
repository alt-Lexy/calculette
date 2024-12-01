// simple prog to test : donet run
try
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
}
