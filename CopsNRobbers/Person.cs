using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopsNRobbers
{
    public abstract class Person
    {
        public int XPos { get; set; }
        public int YPos { get; set; }
        public int DirectionX { get; set; }
        public int DirectionY { get; set; }
        public virtual char Symbol { get; }

        public abstract string CollidesWith(Person person, Random rnd);

        public List<string> Inventory { get; set; } = new List<string>();
    }
}
