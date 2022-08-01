using DotnetPOO.src.Entites;

class Program
{
    static void Main(string[] args)
    {   
        Knitgth arus = new Knitgth("Arus", 23, "Knight");
        Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
      
        Console.WriteLine(arus);
        Console.WriteLine(wizard);
        Console.WriteLine(wizard.Attack(1));
        Console.WriteLine(wizard.Attack(7));
        Console.WriteLine(arus.Attack());
        
        
    }
}