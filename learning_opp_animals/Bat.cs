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










        //////////////////////// Attributes////////////////












        //////////////////////// Attributes////////////////
        public override void eat(string food)
        {
            throw new NotImplementedException();
        }

        public string flight()
        {
            return "In the air we are";
        }

        public string landing()
        {
            return "We have touch the ground";
        }

        public string takeOff()
        {
            return "We have taken off";
        }
    }
}
