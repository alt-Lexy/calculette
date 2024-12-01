Console.WriteLine("Enter your age");
string age = Console.ReadLine();
int adult = 18;
int ageParsed = int.Parse(age);

if (ageParsed >= adult){
    Console.WriteLine($"Vous etes majeur");
    return; // si la personne est majeur c'est inutile d'aller plus loin, c'est pour ca que je mets l'instruction return 
}

Console.WriteLine($"Vous etes mineur");