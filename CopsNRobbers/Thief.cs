using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopsNRobbers
{
    public class Thief : Person
    {
        public override char Symbol => 'T';
        public List<string> Stolen { get; set; }
        public bool IsArrested { get; set; }


        public Thief()
        {
            {
                Stolen = new List<string>();
                IsArrested = false;
            }
        }

        //public Thief(Random random) : Person
        //{
        //    Stolen = new List<string>();
        //    IsArrested = false;
        //}

    public void Robbery(Citizen citizen)
        {
            Random random = new();
            int removeAtIndex = random.Next(citizen.Belongings.Count - 1);

            // Lägg till det valda föremålet i tjuvens "stolen" lista (tjuven stjäl föremålet).
            Stolen.Add(citizen.Belongings[removeAtIndex]);

            // Ta bort det stulna föremålet från medborgarens "Belongings" lista (medborgaren förlorar föremålet).
            citizen.Belongings.RemoveAt(removeAtIndex);
        }

        public override string CollidesWith(Person person, Random rnd)
        {
            if (person is Citizen && person.Inventory.Count > 0)
            {
                int index = rnd.Next(person.Inventory.Count);
                Inventory.Add(person.Inventory[index]);
                person.Inventory.RemoveAt(index);
                return Message.Robbery;
            }
            if (person is Police && person.Inventory.Count > 0)
            {
                person.Inventory.AddRange(Inventory);
                Inventory.Clear();
                return Message.Arrest;
            }
            return null;
        }
    }
}
