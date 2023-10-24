using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopsNRobbers
{
    public class Police : Person
    {
        public override char Symbol => 'P';
        public List<string> Confiscated { get; set; }

        public Police()
        {
            Confiscated = new List<string>();
        }
        //public Cop(Random random) : base(random)
        //{
        //    Confiscated = new List<Item>();
        //}

        public void Arrest(Thief robber)
        {
            // Lägg till de stulna föremålen i polisens "Arrest" lista (konfiskering).
            Confiscated.AddRange(robber.Stolen);

            // Rensa tjuvens "stolen" lista (tjuven förlorar sina stulna föremål).
            robber.Stolen.Clear();

            // Markera tjuven som arresterad genom att sätta IsArrested till true.
            robber.IsArrested = true;
        }
        //public override string CollidesWith(Person person, Random rnd)
        //{
        //    if (person is Thief && person.Inventory.Count > 0)
        //    {
        //        Inventory.AddRange(person.Inventory);
        //        person.Inventory.Clear();
        //        return Message.Arrest;
        //    }

        //    return null;
        //}
    }
}
