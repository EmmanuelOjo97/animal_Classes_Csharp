using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_opp_animals
{

    public abstract class Animal
    {
        //////////////////////// Attributes////////////////
        //private int age;
        //private string name;

        public int Age { get; set; }
        public string Name { get; set; }



        /////////////////// Constructors///////////////////



        public Animal()
            : base()
        {
            Age = 1;
            Name = "John Cena";
        }


        ///////////////Methods///////////////////////////////



        public abstract void eat(string food);
        public void sleep(int lengthOfSleep)
        {
            // sleep method
        }
        public abstract Animal reproduce(Animal[] OtherParent);
        // 
        public abstract void breathe();

        public string poo()
        {
            return "poop";
        }

        public void die()
        {
            // add die method
        }





    }
    /*   internal class AnimalClass
       {
       } */
}
