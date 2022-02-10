using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_opp_animals
{
    public class Fish : Animal
    {

        ////////////////////// Attributes///////////////////////////////



        public Fish(String Name, int Age) : base(Name, Age)
        {

        }


        public string FishSpecies { get; set; }

        /*public Fish("Fisherman",1)
        {
            FishSpecies = "";
        } */


        override public void breathe()
        {
            Console.WriteLine("The fish breathes through its gills");
        }


        public override Fish reproduce(Animal[] otherFish)
        {
            throw new NotImplementedException();
        }

        public override void eat(string food)
        {
            Console.WriteLine("The fish eats " + food);
        }


    }
}
