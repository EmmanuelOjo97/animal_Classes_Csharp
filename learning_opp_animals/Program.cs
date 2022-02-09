// See https://aka.ms/new-console-template for more information

namespace learning_opp_animals;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Worldo");

        Bat myBat = new Bat();

        Console.WriteLine(myBat.takeOff());
        Console.WriteLine(myBat.flight());

        Console.WriteLine(myBat.Age);
        myBat.Name = "Not John Cena";
        Console.WriteLine(myBat.Name);

    }
}


// Console.WriteLine("Hello, World!");
