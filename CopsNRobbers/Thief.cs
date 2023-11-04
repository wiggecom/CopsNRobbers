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

        public int SentenceSecondsPerItem { get; set; }
        public DateTime LeavingPrison { get; set; }


        public Thief(int xPos, int yPos, int dPos, string direction, string name) : base(xPos, yPos, dPos, direction, name)
        {
            {
                Stolen = new List<string>();
                IsArrested = false;
                LeavingPrison = DateTime.MinValue;
                SentenceSecondsPerItem = 10;
            }
        }
    }
}
