using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopsNRobbers
{
    public class Thief : Person
    {
        public override string Symbol => "☺";
        public List<string> Stolen { get; set; }
        public bool IsArrested { get; set; }


        public Thief(int xPos, int yPos, int dPos, string direction, string name) : base(xPos, yPos, dPos, direction, name)
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

        //public string CollidesWith(Person person, Random rnd)
        //{
        //if (person is Citizen && person.Inventory.Count > 0)
        //{
        //int index = rnd.Next(person.Inventory.Count);
        //Inventory.Add(person.Inventory[index]);
        //person.Inventory.RemoveAt(index);
        //return Message.Robbery;
        //}
        //if (person is Police && person.Inventory.Count > 0)
        //{
        //person.Inventory.AddRange(Inventory);
        //Inventory.Clear();
        //return Message.Arrest;
        //}
        //return null;
    }
}
