using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopsNRobbers
{
    internal class Events
    {       public static int movSrcLft = 1;
            public static int movSrcTop = 11;
            public static int movSrcWid = 46;
            public static int movSrcHgh = 30;
            public static int movDstLft = 1;
            public static int movDstTop = 17;
            public static int strtRow = 11;

        private static int RobbedNumber = 0;

        Random rnd = new Random();

        public void Meeting(Person actingPerson, Person targetPerson)
        {

            bool SamePlace = actingPerson.YPos == targetPerson.YPos && actingPerson.XPos == targetPerson.XPos;

            // ----------------------------------- ROBBERY START -------------------------------------------------------

            if (actingPerson is Thief && targetPerson is Citizen && SamePlace)
            {
                RobCitizen((Thief)actingPerson, (Citizen)targetPerson); 
            }
            else if (targetPerson is Thief && actingPerson is Citizen && SamePlace) 
            {
                RobCitizen((Thief)targetPerson, (Citizen)actingPerson);
            }

            // ----------------------------------- ARREST START --------------------------------------------------------

            else if (targetPerson is Police && actingPerson is Thief && SamePlace)
            {
                ArrestThief((Police)targetPerson, (Thief)actingPerson);
            }
            else if (actingPerson is Police && targetPerson is Thief && SamePlace)
            {
                ArrestThief((Police)actingPerson, (Thief)targetPerson);
            }
            #region FIstbump - Citizen vs Citizen
            // ----------------------------------- FISTBUMP START - REFUSED (TOO MANY NEWS) --------------------------------------------------

            //else if (actingPerson is Citizen && targetPerson is Citizen && SamePlace)
            //{
            //Console.MoveBufferArea(movSrcLft, movSrcTop, movSrcWid, movSrcHgh, movDstLft, movDstTop);
            //Console.ForegroundColor = (ConsoleColor)(rnd.Next(1, 15));
            //Console.SetCursorPosition((17 - (actingPerson.Name.Length / 2)), strtRow);
            //Console.WriteLine("Medborgaren " + actingPerson.Name);
            //Console.SetCursorPosition(7, strtRow + 1);
            //Console.WriteLine("gör en high five med medborgaren");
            //Console.SetCursorPosition((23 - (targetPerson.Name.Length / 2)), strtRow + 2);
            //Console.WriteLine(targetPerson.Name);
            //Console.SetCursorPosition(1, strtRow + 3);
            //Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.DarkGray;
            //Console.SetCursorPosition(1, strtRow + 4);
            //Console.WriteLine("███████████████████████████████▓▓▓▓▓▓▓▒▒▒▒▒▒░░░");
            //}
            #endregion
            // ----------------------------------- ARREST BUM START -------------------------------------------------

            else if (targetPerson is Police && actingPerson is Citizen && SamePlace)
            {
                ArrestBum((Police)targetPerson, (Citizen)actingPerson);
            }
            else if (actingPerson is Police && targetPerson is Citizen && SamePlace)
            {
                ArrestBum((Police)actingPerson, (Citizen)targetPerson);
            }

            // ----------------------------------- ARREST BUM END ---------------------------------------------------

        }


        public void RobCitizen(Thief thief, Citizen citizen)
        {
            Console.SetCursorPosition(160, 32);

            if (citizen.Belongings.Count > 0)
            {
                RobbedNumber++;
                Console.MoveBufferArea(movSrcLft, movSrcTop, movSrcWid, movSrcHgh, movDstLft, movDstTop);
                Console.ForegroundColor = (ConsoleColor)(rnd.Next(1, 15));
                Console.SetCursorPosition(((47 - citizen.Name.Length) / 2), strtRow);
                Console.Write(citizen.Name);
                Console.SetCursorPosition(14, strtRow + 1);
                Console.Write("has been robbed by");
                Console.SetCursorPosition(((47 - thief.Name.Length) / 2), strtRow + 2);
                Console.Write(thief.Name);
                Console.SetCursorPosition(1, strtRow + 3);
                Console.Write("");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(1, strtRow + 4);
                Console.Write("███████████████████████████████▓▓▓▓▓▓▓▒▒▒▒▒▒░░░");
                Random random = new Random();
                int removeAtIndex = random.Next(citizen.Belongings.Count);
                string stolenItem = citizen.Belongings[removeAtIndex];
                citizen.Belongings.RemoveAt(removeAtIndex);
                thief.Stolen.Add(stolenItem);
                Gfx.DrawTinyClear((Console.WindowWidth / 2) - 29, 34);
                Gfx.DrawTinyRobberyTxt((Console.WindowWidth / 2) - 29, 34);
                Thread.Sleep(500);
                Gfx.DrawTinyClear((Console.WindowWidth / 2) - 29, 34);
                Gfx.DrawTinyRobbery((Console.WindowWidth / 2) - 20, 34);
                Thread.Sleep(1000);
                Gfx.DrawTinyClear((Console.WindowWidth / 2) - 29, 34);
            }
        }

        //Metod för arrest
        public void ArrestThief(Police police, Thief thief)
        {
            Random rnd = new Random();
            if (thief.Stolen.Count > 0)
            {
                Console.MoveBufferArea(movSrcLft, movSrcTop, movSrcWid, movSrcHgh, movDstLft, movDstTop);
                Console.ForegroundColor = (ConsoleColor)(rnd.Next(1, 15));
                Console.SetCursorPosition(((47 - police.Name.Length) / 2), strtRow);
                Console.Write(police.Name);
                Console.SetCursorPosition(13, strtRow + 1);
                Console.Write("has caught the theief");
                Console.SetCursorPosition(((47 - thief.Name.Length) / 2), strtRow + 2);
                Console.Write(thief.Name);
                Console.SetCursorPosition(1, strtRow + 3);
                Console.Write("");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(1, strtRow + 4);
                //                  123456789 123456789 123456789 123456789 123456
                Console.Write("███████████████████████████████▓▓▓▓▓▓▓▒▒▒▒▒▒░░░");
                thief.LeavingPrison = DateTime.Now.AddSeconds((thief.SentenceSecondsPerItem * thief.Stolen.Count));
                police.Confiscated.AddRange(thief.Stolen);
                thief.Stolen.Clear();
                thief.IsArrested = true;
                thief.XPos = rnd.Next(1, 20); thief.YPos = rnd.Next(27, 38);
                Gfx.DrawTinyClear((Console.WindowWidth / 2) - 29, 34);
                Gfx.DrawTinyBustedTxt((Console.WindowWidth / 2) - 29, 34);
                Thread.Sleep(500);
                Gfx.DrawTinyClear((Console.WindowWidth / 2) - 29, 34);
                Gfx.DrawTinyBusted((Console.WindowWidth / 2) - 19, 34);
                Thread.Sleep(1500);
                Gfx.DrawTinyClear((Console.WindowWidth / 2) - 29, 34);

            }
        }

        public void ArrestBum(Police police, Citizen citizen)
        {
            Random rnd = new Random();
            if (citizen.Belongings.Count == 0)
            {
                Console.MoveBufferArea(movSrcLft, movSrcTop, movSrcWid, movSrcHgh, movDstLft, movDstTop);
                Console.ForegroundColor = (ConsoleColor)(rnd.Next(1, 15));
                Console.SetCursorPosition(((47 - police.Name.Length) / 2), strtRow);
                Console.Write(police.Name);
                Console.SetCursorPosition(12, strtRow + 1);
                Console.Write("has dealt with the bum");
                Console.SetCursorPosition(((47 - citizen.Name.Length) / 2), strtRow + 2);
                Console.Write(citizen.Name);
                Console.SetCursorPosition(1, strtRow + 3);
                Console.Write("");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(1, strtRow + 4);
                Console.Write("███████████████████████████████▓▓▓▓▓▓▓▒▒▒▒▒▒░░░");

                citizen.Woke = true;
                citizen.XPos = rnd.Next(82, 101); 
                citizen.YPos = rnd.Next(27, 38);
                Gfx.DrawTinyBumTxt((Console.WindowWidth / 2) - 29, 34);
                Thread.Sleep(500);
                Gfx.DrawTinyClear((Console.WindowWidth / 2) - 29, 34);
                Gfx.DrawTinyBum((Console.WindowWidth / 2) - 29, 34);
                Thread.Sleep(1500);
                Gfx.DrawTinyClear((Console.WindowWidth / 2) - 29, 34);
            }
        }

        public static void CitySummary(List<Person> personsList, int cityLeftStartCentered, int cityTopStartCentered, int sleepy, int citizensTotal, int thievesTotal, int copsTotal, bool pacMan, int sentencePerItem)
        {
            
            int arrested = 0;
            int bums = 0;
            int free = 0;
            int stRow = 12;
            Random rnd = new Random();
            foreach (Thief thief in personsList.OfType<Thief>()) 
            {
                if (DateTime.Now > thief.LeavingPrison && thief.IsArrested) 
                {
                    thief.IsArrested = false;
                    Console.SetCursorPosition(cityLeftStartCentered + thief.XPos, cityTopStartCentered + thief.YPos);
                    Console.Write(" ");
                    thief.XPos = 6;
                    thief.YPos = 24;
                    thief.Direction = "NE";
                    // --------------  Info  ----------------
                    Console.MoveBufferArea(movSrcLft, movSrcTop, movSrcWid, movSrcHgh, movDstLft, movDstTop);
                    Console.ForegroundColor = (ConsoleColor)(rnd.Next(1, 15));
                    Console.SetCursorPosition(((47 - thief.Name.Length) / 2), strtRow);
                    Console.WriteLine(thief.Name);
                    Console.SetCursorPosition(15, strtRow + 1);
                    Console.WriteLine("gets out of prison");
                    Console.SetCursorPosition(15 , strtRow + 2);
                    Console.WriteLine("after the sentence");
                    Console.SetCursorPosition(1, strtRow + 3);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.SetCursorPosition(1, strtRow + 4);
                    Console.WriteLine("███████████████████████████████▓▓▓▓▓▓▓▒▒▒▒▒▒░░░");
                }

                if (thief.IsArrested) 
                {
                    arrested++; 
                }
                else
                {
                    free++;
                }
            }
            foreach (Citizen citizen in personsList.OfType<Citizen>())
            {
                if (citizen.Woke)
                {
                    bums++;
                }

            }
            Console.ForegroundColor = ConsoleColor.White;
            #region - Write info -
            Console.SetCursorPosition(165, stRow);
            Console.Write("Number of Citizens:  " + citizensTotal + "  ");
            Console.SetCursorPosition(165, stRow + 1);
            Console.Write("Number of Thieves:\t  " + thievesTotal + "  ");
            Console.SetCursorPosition(165, stRow + 2);
            Console.Write("Number of Police:\t  " + copsTotal + "  ");
            Console.SetCursorPosition(165, stRow + 3);
            Console.Write("");
            Console.SetCursorPosition(165, stRow + 4);
            Console.Write($"Total robberies: \t{RobbedNumber}  ");
            Console.SetCursorPosition(165, stRow + 5);
            Console.Write($"Thieves arrested: \t{arrested}  ");
            Console.SetCursorPosition(165, stRow + 6);
            Console.Write($"Thieves roaming: \t{free}  ");
            Console.SetCursorPosition(165, stRow + 7);
            Console.Write($"Bums locked in: \t{bums}  ");
            Console.SetCursorPosition(165, stRow + 8);
            Console.Write("");

            if (pacMan == false)
            {
                Console.SetCursorPosition(165, stRow + 9);
                Console.Write("F1: [Bounce] / Pac-Man");
            }
            else
            {
                Console.SetCursorPosition(165, stRow + 9);
                Console.Write("F1: Bounce / [Pac-Man]");
            }

            Console.SetCursorPosition(165, stRow + 10);
            Console.Write("F2: Slow Speed");
            Console.SetCursorPosition(165, stRow + 11);
            Console.Write("F3: Medium Speed");
            Console.SetCursorPosition(165, stRow + 12);
            Console.Write("F4: Fast Speed");
            Console.SetCursorPosition(165, stRow + 13);
            Console.Write("F5: Insane Speed");

            if (sleepy == 100)
            {
                Console.SetCursorPosition(163, stRow + 10);
                Console.Write("+");
                Console.SetCursorPosition(163, stRow + 11);
                Console.Write(" ");
                Console.SetCursorPosition(163, stRow + 12);
                Console.Write(" ");
                Console.SetCursorPosition(163, stRow + 13);
                Console.Write(" ");

            }
            else if (sleepy == 50)
            {
                Console.SetCursorPosition(163, stRow + 10);
                Console.Write(" ");
                Console.SetCursorPosition(163, stRow + 11);
                Console.Write("+");
                Console.SetCursorPosition(163, stRow + 12);
                Console.Write(" ");
                Console.SetCursorPosition(163, stRow + 13);
                Console.Write(" ");
            }
            else if (sleepy == 20)
            {
                Console.SetCursorPosition(163, stRow + 10);
                Console.Write(" ");
                Console.SetCursorPosition(163, stRow + 11);
                Console.Write(" ");
                Console.SetCursorPosition(163, stRow + 12);
                Console.Write("+");
                Console.SetCursorPosition(163, stRow + 13);
                Console.Write(" ");
            }
            else if (sleepy == 0)
            {
                Console.SetCursorPosition(163, stRow + 10);
                Console.Write(" ");
                Console.SetCursorPosition(163, stRow + 11);
                Console.Write(" ");
                Console.SetCursorPosition(163, stRow + 12);
                Console.Write(" ");
                Console.SetCursorPosition(163, stRow + 13);
                Console.Write("+");
            }

            Console.SetCursorPosition(165, stRow + 15);
            Console.Write("1: Add Citizen");
            Console.SetCursorPosition(165, stRow + 16);
            Console.Write("2: Add Thief");
            Console.SetCursorPosition(165, stRow + 17);
            Console.Write("3: Add Police");
            Console.SetCursorPosition(165, stRow + 18);
            Console.Write("");
            Console.SetCursorPosition(165, stRow + 19);
            Console.Write("5: Remove Citizen");
            Console.SetCursorPosition(165, stRow + 20);
            Console.Write("6: Remove Thief");
            Console.SetCursorPosition(165, stRow + 21);
            Console.Write("7: Remove Police");

            Console.SetCursorPosition(165, stRow + 23);
            Console.Write("Sentence Per Item " + sentencePerItem + " sec  ");
            Console.SetCursorPosition(165, stRow + 24);
            Console.Write("9. Lower Sentence");
            Console.SetCursorPosition(165, stRow + 25);
            Console.Write("0. Raise Sentence");
            #endregion
        }

    }
}
