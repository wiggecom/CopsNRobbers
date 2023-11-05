using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopsNRobbers
{
    public class Police : Person
    {
        public override string Symbol => "☻";
        public List<string> Confiscated { get; set; }

        public Police(int xPos, int yPos, int dPos, string direction, string name) : base(xPos, yPos, dPos, direction, name)
        {
            Confiscated = new List<string>();
        }
        public static string PoliceName()
        {
            Random rnd = new Random();
            string name = "";
            string[] prefix =
            {
                "Officer ",
                "Constaple ",
                "Sergant ",
                "Inspector ",
                "Deputy ",
                "Captain ",
                "Lieutenant ",
            };

            string[] suffix =
{
                "Stevens",
                "Anderson",
                "Smith",
                "Jones",
                "Lopez",
                "Miller",
                "Taylor",
                "Adams",
                "Hill",
                "Carter",
                "Cooper",
                "Gomez"
            };
            name = prefix[rnd.Next(0, prefix.Length)] + suffix[rnd.Next(0, suffix.Length)];
            return name;
        }

    }
}
