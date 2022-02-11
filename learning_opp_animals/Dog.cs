using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_opp_animals
{
    public class Dog : Mammel
    {


        public string Breed { get; set; }
        public double Weight { get; set; }


        // all handles all 4 attributes
        public Dog(String Name, int Age, String Breed, double Weight) : base(Name, Age)
        {
            this.Breed = Breed;
            this.Weight = Weight;
        }


        // handles missing name
        public Dog(int Age, String Breed, double Weight) : this("", Age, Breed, Weight)
        {

        }
        // handles missing age
        public Dog(String Name, String Breed, double Weight) : this(Name, 0, Breed, Weight)
        {

        }
        // handles missing breed
        public Dog(String Name, int Age, double Weight) : this(Name, Age, "", Weight)
        {

        }

        // handles missing weight
        public Dog(String Name, int Age, String Breed) : this(Name, Age, Breed, 0)
        {

        }
        // handles missing breed and weight
        public Dog(String Name, int Age) : this(Name, Age, "Enter Breed", 0)
        {

        }



        /*public Dog(int Age, String Breed) : this(Age, Breed, 30)
        {

        }

        public Dog(int Age) : this("Enter Name", Age, " No dog Breed entered ", 0)
        {

        } */


        public override void eat(string food)
        {
            throw new NotImplementedException();
        }


        public void WalkingTime()
        {
            Console.WriteLine("The dog has been walked");
        }


        public void PetAnimal()
        {
            Console.WriteLine("We pet the dog");
        }

        public void takeMedication(string meds)
        {
            Console.WriteLine("We have given the dog the " + meds);
        }

        public string DogHealth(int AgeOfDog)
        {
            if (AgeOfDog <= 5)
            {
                string message = "The dog is still relatively young";
                return message;
                //Console.WriteLine("The dog is still relatively young");
            }
            else if (AgeOfDog > 6)
            {
                string message = "The dog is getting on in age and will require surgery";
                return message;
                //Console.WriteLine("The dog is getting on in age and will require surgery");
            }
            else
            {
                return "Enter regular age";
            }
            // Console.WriteLine("DogHealth " + AgeOfDog);
        }



    }
}
