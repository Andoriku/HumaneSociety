using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Bird : Animal
    {
        public Bird()
        {

        }
        public Guid GetAnimalID()
        {
            animalID = System.Guid.NewGuid();
            return animalID;
        }
    }
}
