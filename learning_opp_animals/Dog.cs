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






        public Dog(String Name, int Age, String Breed, double Weight) : base(Name, Age)
        {
            this.Breed = Breed;
            this.Weight = Weight;
        }

        public Dog(int Age, String Breed, double Weight) : this("", Age, Breed, Weight)
        {

        }

        public Dog(String Name, String Breed, double Weight) : this(Name, 0, Breed, Weight)
        {

        }
        public Dog(String Name, int Age, double Weight) : this(Name, Age, "", Weight)
        {

        }
        public Dog(String Name, int Age, String Breed) : this(Name, Age, Breed, 0)
        {

        }

        public Dog(String Breed, int Weight) : this("Place Holder Name ", 0, Breed, Weight)
        {

        }

        // single input

        public Dog(String Name) : this(Name, 0, " No dog Breed entered ", 0)
        {

        }

        public Dog(int Age) : this("Enter Name", Age, " No dog Breed entered ", 0)
        {

        }









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



    }
}
