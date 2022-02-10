using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_opp_animals
{
    public abstract class Mammel : Animal
    {
        //////////////////////// Attributes////////////////









        //////////////////////// Constructors////////////////

        /*public Mammel() : base("Default", 1)
        {

        }*/

        public Mammel(string Name, int Age) : base(Name, Age)
        {

        }

        public Mammel(string Name) : this(Name, 0)
        {

        }

        public Mammel(int Age) : this("", Age)
        {

        }






        //////////////////////// Methods////////////////

        // public abstract void breathe();
        override public void breathe()
        {
            Console.WriteLine("Take in Oxygen expel cO2");
        }

        /*public override Mammel reproduce(Mammel otherParent)
        {
            throw null;
        }*/

        public override Mammel reproduce(Animal[] OtherParent)
        {
            throw new NotImplementedException();
        }

        public override void eat(string food)
        {
            Console.WriteLine("Our mammel is eating" + food);
        }



    }
}
