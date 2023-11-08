using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopsNRobbers
{
    public class Thief : Person
    {
        public override string Symbol => "☻";
        public List<string> Stolen { get; set; }
        public bool IsArrested { get; set; }

        public int SentenceSecondsPerItem { get; set; }
        public DateTime LeavingPrison { get; set; }

        public Thief(int xPos, int yPos, int dPos, string direction, string name, int sentenceSecondsPerItem) : base(xPos, yPos, dPos, direction, name)
        {
            {
                Stolen = new List<string>();
                IsArrested = false;
                LeavingPrison = DateTime.MinValue;
                SentenceSecondsPerItem = sentenceSecondsPerItem;
            }
        }
        public static string ThiefName()
        {
            Random rnd = new Random();
            string name = "";
            string[] prefix =
            {
                "Switchblade ",
                "Bad ",
                "Fishy ",
                "Muthaf*ckin' ",
                "Sleezy ",
                "Bloody ",
                "Gangster ",
                "Stab Wound-",
                "Filthy ",
                "Dirty ",
                "One-Eyed ",
                "Cheating ",
            };

            string[] suffix =
{
                "McCracken",
                "Jack",
                "Ryder",
                "Blaze",
                "Zeke",
                "Fox",
                "Bruce",
                "Willy",
                "Lars",
                "Ben",
                "Jones",
            };
            name = prefix[rnd.Next(0, prefix.Length)] + suffix[rnd.Next(0, suffix.Length)];
            return name;
        }
    }
}
