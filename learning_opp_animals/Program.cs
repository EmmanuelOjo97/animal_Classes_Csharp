// See https://aka.ms/new-console-template for more information

namespace learning_opp_animals;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Worldo");

        Bat myBat = new Bat("BatMan", 20);

        //Console.WriteLine(myBat.takeOff);
        //Console.WriteLine(myBat.flight);
        myBat.takeOff();
        myBat.flight();
        myBat.landing();
        Console.WriteLine(myBat.flapWings());


        Console.WriteLine(myBat.Age);
        //myBat.Name = "Not John Cena";
        Console.WriteLine(myBat.Name);
        myBat.eat("french fries");

        Console.WriteLine("What is the name of your dog");
        Dog myDog = new Dog("Dogman", 10, "Pug", 30);
        // myDog.Name = Console.ReadLine();
        Console.WriteLine("Hello there " + myDog.Name + " you are " + myDog.Age + " years old");
        Console.WriteLine(myDog.Breed);

        Dog JohnnyTheDog = new Dog("John", 2, "Pug", 1);
        Console.WriteLine(JohnnyTheDog.Name + JohnnyTheDog.Age + JohnnyTheDog.Breed + JohnnyTheDog.Weight);

        Snake SnapeTheSnake = new Snake("Snape", 50, "Python", 5.6);
        Console.WriteLine(SnapeTheSnake.Species);


    }
}


// Console.WriteLine("Hello, World!");
