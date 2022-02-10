using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_opp_animals
{
    public class Snake : Animal, Reptile
    {

        ////////////////// Attributes//////////////////////


        public string Species { get; set; }
        public double Length { get; set; }


        public Snake(String Name, int Age, String Species, double Length) : base(Name, Age)
        {
            this.Species = Species;
            this.Length = Length;
        }

        public void ShedSkin()
        {
            Console.WriteLine("In the air we are");
        }

        public void LayEggs()
        {
            Console.WriteLine("The Snake has layed eggs");
        }

        /////////////////



        override public void breathe()
        {
            Console.WriteLine("Reptile Breathes ");
        }

        public override void eat(string food)
        {
            Console.WriteLine("Our mammel is eating" + food);
        }

        public override Snake reproduce(Animal[] LayEggs)
        {
            throw new NotImplementedException();
        }



    }
}
