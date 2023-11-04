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
        // Statiska variabler för att hålla räkning på antalet rånade medborgare och gripna tjuvar.
        private static int RobbedNumber = 0;
        //private static int ArrestedNumber = 0;

        //Encounter
        Random rnd = new Random();

        public void Meeting(Person actingPerson, Person targetPerson)
        {

            bool SamePlace = actingPerson.YPos == targetPerson.YPos && actingPerson.XPos == targetPerson.XPos; // Bool om personerna är på samma plats
            // 1234567890123456789012345678901234567890123456 
            //          1         2         3         4 


            // ----------------------------------- ROBBERY START -------------------------------------------------------

            if (actingPerson is Thief && targetPerson is Citizen && SamePlace) //Om medborgare träffar tjuv
            {
                RobCitizen((Thief)actingPerson, (Citizen)targetPerson); //Anropa RobCitizen // Thief == actingPerson
            }
            else if (targetPerson is Thief && actingPerson is Citizen && SamePlace) //Om tjuv träffar medborgare
            {
                RobCitizen((Thief)targetPerson, (Citizen)actingPerson); //Anropa RobCitizen // Thief == targetPerson
            }

            // ----------------------------------- ARREST START --------------------------------------------------------

            else if (targetPerson is Police && actingPerson is Thief && SamePlace) //Om polis och tjuv är på samma plats
            {
                ArrestThief((Police)targetPerson, (Thief)actingPerson); //Anropar ArrestTheif
            }
            else if (actingPerson is Police && targetPerson is Thief && SamePlace) //Om polis och tjuv är på samma plats
            {
                ArrestThief((Police)actingPerson, (Thief)targetPerson); //Anropar ArrestTheif
            }

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

            // ----------------------------------- ARREST BUM START -------------------------------------------------

            else if (targetPerson is Police && actingPerson is Citizen && SamePlace) //Om polis och medborgare är på samma plats
            {
                ArrestBum((Police)targetPerson, (Citizen)actingPerson); //Anropar ArrestBum
            }
            else if (actingPerson is Police && targetPerson is Citizen && SamePlace) //Om polis och medborgare är på samma plats
            {
                ArrestBum((Police)actingPerson, (Citizen)targetPerson); //Anropar ArrestBum
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
                Console.SetCursorPosition((18 - (citizen.Name.Length / 2)), strtRow);
                Console.WriteLine("The citizen " + citizen.Name);
                Console.SetCursorPosition(15, strtRow + 1);
                Console.WriteLine("has been robbed by");
                Console.SetCursorPosition((23 - (thief.Name.Length / 2)), strtRow + 2);
                Console.WriteLine(thief.Name);
                Console.SetCursorPosition(1, strtRow + 3);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(1, strtRow + 4);
                Console.WriteLine("███████████████████████████████▓▓▓▓▓▓▓▒▒▒▒▒▒░░░");
                Random random = new Random();
                int removeAtIndex = random.Next(citizen.Belongings.Count);
                string stolenItem = citizen.Belongings[removeAtIndex];
                citizen.Belongings.RemoveAt(removeAtIndex);
                thief.Stolen.Add(stolenItem);
                Gfx.DrawTinyClear((Console.WindowWidth / 2) - 29, 34);
                Gfx.DrawTinyRobberyTxt((Console.WindowWidth / 2) - 29, 34);
                Thread.Sleep(1000);
                Gfx.DrawTinyClear((Console.WindowWidth / 2) - 29, 34);
                Gfx.DrawTinyRobbery((Console.WindowWidth / 2) - 20, 34);
                Thread.Sleep(2000);
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
                Console.SetCursorPosition((18 - (police.Name.Length / 2)), strtRow);
                Console.WriteLine("Officer " + police.Name);
                Console.SetCursorPosition(13, strtRow + 1);
                Console.WriteLine("has caught the theief");
                Console.SetCursorPosition((23 - (thief.Name.Length / 2)), strtRow + 2);
                Console.WriteLine(thief.Name);
                Console.SetCursorPosition(1, strtRow + 3);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(1, strtRow + 4);
                Console.WriteLine("███████████████████████████████▓▓▓▓▓▓▓▒▒▒▒▒▒░░░");
                thief.LeavingPrison = DateTime.Now.AddSeconds((thief.SentenceSecondsPerItem * thief.Stolen.Count));
                police.Confiscated.AddRange(thief.Stolen);
                thief.Stolen.Clear();
                thief.IsArrested = true;
                thief.XPos = rnd.Next(1, 20); thief.YPos = rnd.Next(27, 38);
                Gfx.DrawTinyClear((Console.WindowWidth / 2) - 29, 34);
                Gfx.DrawTinyBustedTxt((Console.WindowWidth / 2) - 29, 34);
                Thread.Sleep(1000);
                Gfx.DrawTinyClear((Console.WindowWidth / 2) - 29, 34);
                Gfx.DrawTinyBusted((Console.WindowWidth / 2) - 19, 34);
                Thread.Sleep(2000);
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
                Console.SetCursorPosition((17 - (police.Name.Length / 2)), strtRow);
                Console.WriteLine("Officer " + police.Name);
                Console.SetCursorPosition(12, strtRow + 1);
                Console.WriteLine("has dealt with the bum");
                Console.SetCursorPosition((23 - (citizen.Name.Length / 2)), strtRow + 2);
                Console.WriteLine(citizen.Name);
                Console.SetCursorPosition(1, strtRow + 3);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(1, strtRow + 4);
                Console.WriteLine("███████████████████████████████▓▓▓▓▓▓▓▒▒▒▒▒▒░░░");

                citizen.Woke = true;
                citizen.XPos = rnd.Next(82, 101); 
                citizen.YPos = rnd.Next(27, 38);
                Gfx.DrawTinyBumTxt((Console.WindowWidth / 2) - 29, 34);
                Thread.Sleep(1000);
                Gfx.DrawTinyClear((Console.WindowWidth / 2) - 29, 34);
                Gfx.DrawTinyBum((Console.WindowWidth / 2) - 29, 34);
                Thread.Sleep(2000);
                Gfx.DrawTinyClear((Console.WindowWidth / 2) - 29, 34);
            }
        }

        public static void CitySummary(List<Person> personsList, int cityLeftStartCentered, int cityTopStartCentered, int sleepy)
        {
            
            Console.SetCursorPosition(167, 11);
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine($"Total robberies: \t{RobbedNumber}");
            
            int arrested = 0;
            int bums = 0;
            int free = 0;
            Random rnd = new Random();
            foreach (Thief thief in personsList.OfType<Thief>()) 
            {
                if (DateTime.Now > thief.LeavingPrison && thief.IsArrested) 
                {
                    thief.IsArrested = false;
                    Console.SetCursorPosition(cityLeftStartCentered + thief.XPos, cityTopStartCentered + thief.YPos);
                    Console.Write(" ");
                    thief.XPos = 6;
                    thief.YPos = 25;
                    // --------------  Info  ----------------
                    Console.MoveBufferArea(movSrcLft, movSrcTop, movSrcWid, movSrcHgh, movDstLft, movDstTop);
                    Console.ForegroundColor = (ConsoleColor)(rnd.Next(1, 15));
                    Console.SetCursorPosition((17 - (thief.Name.Length / 2)), strtRow);
                    Console.WriteLine("The thief " + thief.Name);
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
            Console.SetCursorPosition(167, 12);
            Console.WriteLine($"Thieves arrested: \t{arrested}");
            Console.SetCursorPosition(167, 13);
            Console.WriteLine($"Thieves roaming: \t{free}");
            Console.SetCursorPosition(167, 14);
            Console.WriteLine($"Caught bums: \t\t{bums}");
            Console.SetCursorPosition(167, 16);
            Console.WriteLine($"Delay: \t\t{sleepy}   ");

        }























        //public void Meeting(Person person, Person otherPerson, List<Person> people)
        //{
        //    bool SamePlace = person.YPos == otherPerson.YPos && person.XPos == otherPerson.XPos;

        //    // Thiefy()
        //    if (person is Thief && otherPerson is Citizen || person is Citizen && otherPerson is Thief && SamePlace)
        //    {
        //        Thiefy((Thief)person, (Citizen)otherPerson);
        //    }

        //    // Arrest()
        //    if (person is Police && otherPerson is Thief || person is Thief && otherPerson is Police && SamePlace)
        //    {
        //        Arrest((Police)person, (Thief)otherPerson, people);
        //    }
        //}

        //Events
        //Metod för rån
        //public void Thiefy(Thief thief, Citizen citizen)
        //{
        //    Console.Write("\aEn tjuv smyger upp bakom en medborgare...");
        //    Thread.Sleep(2000);

        //    if (citizen.Belongings.Count > 0)
        //    {
        //        RobbedNumber++;

        //        //TEST från subklassen Thief
        //        Random random = new();
        //        int removeAtIndex = random.Next(citizen.Belongings.Count - 1);

        //        // Lägg till det valda föremålet i tjuvens "stolen" lista (tjuven stjäl föremålet).
        //        thief.Stolen.Add(citizen.Belongings[removeAtIndex]);

        //        // Ta bort det stulna föremålet från medborgarens "Belongings" lista (medborgaren förlorar föremålet).
        //        citizen.Belongings.RemoveAt(removeAtIndex);

        //        // Pausa i 2 sekunder (2000 millisekunder).
        //        Thread.Sleep(2000);
        //        string action = EventCards.Thiefy;
        //    }
        //    else
        //    {
        //        Console.Write("\aMedborgarens fickor var tomma, ingen stöds genomfördes.");
        //        Thread.Sleep(2000);
        //    }
        //}

        //Metod för att hantera arrest
        //public void Arrest(Police police, Thief thief, List<Person> people)
        //{
        //    // Skriver ut ett meddelande om att polisen stannar och undersöker en tjuv.
        //    Console.Write("\aPolisen stannar och undersöker en tjuv...");
        //    Thread.Sleep(2000);

        //    // Kontrollerar om tjuven har stulit något.
        //    if (thief.Stolen.Count > 0)
        //    {
        //        // Ökar räknaren för antalet arresterade tjuvar.
        //        ArrestedNumber++;

        //        // Lägg till de stulna föremålen i polisens "Arrest" lista (konfiskering).
        //        police.Confiscated.AddRange(thief.Stolen);

        //        // Rensa tjuvens "stolen" lista (tjuven förlorar sina stulna föremål).
        //        thief.Stolen.Clear();

        //        // Markera tjuven som arresterad genom att sätta IsArrested till true.
        //        thief.IsArrested = true;

        //        // Tilldelar en händelse (action) från EventCards
        //        string action = EventCards.Thiefy;
        //        Thread.Sleep(2000);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Tjuven hade inte stulit något.");
        //        Thread.Sleep(2000);
        //    }
        //}

        //Skriva ut sammanfattning för tagna tjuvar och rånade medborgare i staden.

    }
}
