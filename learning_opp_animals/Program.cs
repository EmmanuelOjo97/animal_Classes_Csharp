// See https://aka.ms/new-console-template for more information

namespace learning_opp_animals;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Worldo");

        Bat myBat = new Bat("BatMan", 20);


        myBat.takeOff();
        myBat.flight();
        myBat.landing();
        Console.WriteLine(myBat.flapWings());


        Console.WriteLine(myBat.Age);
        Console.WriteLine(myBat.Name);
        myBat.eat("french fries");

        Console.WriteLine("What is the name of your dog");
        Dog myDog = new Dog("Dogman", 10, "Pug", 30);
        Console.WriteLine("Hello there " + myDog.Name + " you are " + myDog.Age + " years old");
        Console.WriteLine(myDog.Breed);

        Dog JohnnyTheDog = new Dog("Johnny", 10, "Pug", 25);
        Console.WriteLine(JohnnyTheDog.Name + JohnnyTheDog.Age + JohnnyTheDog.Breed + JohnnyTheDog.Weight);

        Snake SnapeTheSnake = new Snake("Snape", 50, "Python", 5.6);
        Console.WriteLine(SnapeTheSnake.Species);
        Console.WriteLine(myDog.DogHealth(30));
        Console.WriteLine(myDog.Age);

        Animal myExtraAnimal = new Bat("ManBat", 4);
        LinkedList<Animal> zoo = new LinkedList<Animal>();
        List<Animal> list = new List<Animal>();
        list.Add(myBat);
        list.Add(myExtraAnimal);
        list.Add(myDog);
        list.Add(JohnnyTheDog);
        list.Add(SnapeTheSnake);


        //myBat.Name = Console.ReadLine();
        Console.WriteLine(myBat.Name);

        foreach (Animal a in list)
        {
            Console.WriteLine(a.Name);
            Console.WriteLine(a.Age);
        }

        bool runProgram = true;







    }
}


// Console.WriteLine("Hello, World!");
