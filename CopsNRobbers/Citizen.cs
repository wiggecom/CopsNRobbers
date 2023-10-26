using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopsNRobbers
{

    public class Citizen : Person
    {
        public override string Symbol => "☻";
        public List<string> Belongings { get; set; }

        public Citizen(int xPos, int yPos, int dPos, string direction, string name) : base(xPos, yPos, dPos, direction, name)
        {
            Belongings = new List<string>();
            Belongings.Add("Mobile phone");
            Belongings.Add("Keys");
            Belongings.Add("Watch");
            Belongings.Add("Wallet");

            //Inventory.Add("Nycklar");
            //Inventory.Add("Mobiltelefon");
            //Inventory.Add("Pengar");
            //Inventory.Add("Klocka");
        }


        /*public string CollidesWith(Person person, Random rnd)
        {
            if (person is Thief && Inventory.Count > 0)
            {
                int index = rnd.Next(0, Belongings.Count);
                person.Stolen.Add(Belongings[index]);
                Belongings.RemoveAt(index);
                return Message.Robbery;
            }

            return null;
        }*/
    }

}
