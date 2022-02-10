using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_opp_animals
{
    public class Bat : Mammel, Flying
    {
        //////////////////////// Attributes////////////////









        //////////////////////// Constructors ////////////////

        public Bat(String Name, int Age) : base(Name, Age)
        {

        }

        public Bat(int Age) : this("ManBat", Age)
        {

        }







        //////////////////////// Attributes////////////////
        /*public override void eat(string food)
        {
            throw new NotImplementedException();
        }*/

        public void flight()
        {
            Console.WriteLine("In the air we are");
        }

        public void landing()
        {
            Console.WriteLine("We have touch the ground");
        }

        public void takeOff()
        {
            Console.WriteLine("We have taken off");
        }

        public string flapWings()
        {
            return "the flying animal is flapping its wings";
        }
    }
}
