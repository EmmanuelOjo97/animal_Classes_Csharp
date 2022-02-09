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











        //////////////////////// Methods////////////////

        // public abstract void breathe();
        override public void breathe()
        {

        }

        /*public override Mammel reproduce(Mammel otherParent)
        {
            throw null;
        }*/

        public override Mammel reproduce(Animal[] OtherParent)
        {
            throw new NotImplementedException();
        }



    }
}
