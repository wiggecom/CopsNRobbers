using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopsNRobbers
{
    internal class Events
    {
        // Statiska variabler för att hålla räkning på antalet rånade medborgare och gripna tjuvar.
        private static int RobbedNumber = 0;
        private static int ArrestedNumber = 0;

        //Encounter
        Random rnd = new Random();
        public void Meeting(Person actingPerson, Person targetPerson)
        {
            int movSrcLft = 1;
            int movSrcTop = 11;
            int movSrcWid = 46;
            int movSrcHgh = 30;
            int movDstLft = 1;
            int movDstTop = 17;
            int strtRow = 11;
            bool SamePlace = actingPerson.YPos == targetPerson.YPos && actingPerson.XPos == targetPerson.XPos; // Bool om personerna är på samma plats
            // Medborgarna gör en high five!                  ║
            // 1234567890123456789012345678901234567890123456 
            //          1         2         3         4 
            if (actingPerson is Thief && targetPerson is Citizen && SamePlace) //Om medborgare träffar tjuv
            {
                Console.MoveBufferArea(movSrcLft, movSrcTop, movSrcWid, movSrcHgh, movDstLft, movDstTop);
                Console.ForegroundColor = (ConsoleColor)(rnd.Next(1, 15));
                Console.SetCursorPosition((17-(targetPerson.Name.Length/2)),strtRow);
                Console.WriteLine("Medborgaren " + targetPerson.Name);
                Console.SetCursorPosition(17, strtRow+1);
                Console.WriteLine("har rånats av");
                Console.SetCursorPosition((23 - (actingPerson.Name.Length / 2)), strtRow+2);
                Console.WriteLine(actingPerson.Name);
                Console.SetCursorPosition(1, strtRow+3);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(1, strtRow+4);
                Console.WriteLine("░░░▒▒▒▒▒▒▓▓▓▓▓▓▓███████████████▓▓▓▓▓▓▓▒▒▒▒▒▒░░░");

                RobCitizen((Thief)actingPerson, (Citizen)targetPerson); //Anropa RobCitizen // Thief == actingPerson
            }
            else if (targetPerson is Thief && actingPerson is Citizen && SamePlace) //Om tjuv träffar medborgare
            {
                Console.MoveBufferArea(movSrcLft, movSrcTop, movSrcWid, movSrcHgh, movDstLft, movDstTop);
                Console.SetCursorPosition(1, 16);
                Console.SetCursorPosition((17 - (actingPerson.Name.Length / 2)), strtRow);
                Console.WriteLine("Medborgaren " + actingPerson.Name); 
                Console.SetCursorPosition(17, strtRow+1);
                Console.WriteLine("har rånats av");
                Console.SetCursorPosition((23 - (targetPerson.Name.Length / 2)), strtRow+2);
                Console.WriteLine(targetPerson.Name);
                Console.SetCursorPosition(1, strtRow+3);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(1, strtRow+4);
                Console.WriteLine("░░░▒▒▒▒▒▒▓▓▓▓▓▓▓███████████████▓▓▓▓▓▓▓▒▒▒▒▒▒░░░");

                RobCitizen((Thief)targetPerson, (Citizen)actingPerson); //Anropa RobCitizen // Thief == targetPerson
            }
            else if (targetPerson is Police && actingPerson is Thief && SamePlace) //Om polis och tjuv är på samma plats
            {
                Console.MoveBufferArea(movSrcLft, movSrcTop, movSrcWid, movSrcHgh, movDstLft, movDstTop);
                Console.ForegroundColor = (ConsoleColor)(rnd.Next(1, 15));
                Console.SetCursorPosition((18 - (targetPerson.Name.Length / 2)), strtRow);
                Console.WriteLine("Konstapel " + targetPerson.Name);
                Console.SetCursorPosition(15, strtRow+1);
                Console.WriteLine("har fångat tjuven");
                Console.SetCursorPosition((23 - (actingPerson.Name.Length / 2)), strtRow+2);
                Console.WriteLine(actingPerson.Name);
                Console.SetCursorPosition(1, strtRow+3);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(1, strtRow+4);
                Console.WriteLine("░░░▒▒▒▒▒▒▓▓▓▓▓▓▓███████████████▓▓▓▓▓▓▓▒▒▒▒▒▒░░░");

                ArrestThief((Police)targetPerson, (Thief)actingPerson); //Anropar ArrestTheif

            }
            else if (actingPerson is Police && targetPerson is Thief && SamePlace) //Om polis och tjuv är på samma plats
            {
                Console.MoveBufferArea(movSrcLft, movSrcTop, movSrcWid, movSrcHgh, movDstLft, movDstTop);
                Console.ForegroundColor = (ConsoleColor)(rnd.Next(1, 15));
                Console.SetCursorPosition((18 - (actingPerson.Name.Length / 2)), strtRow);
                Console.WriteLine("Konstapel " + actingPerson.Name);
                Console.SetCursorPosition(15, strtRow + 1);
                Console.WriteLine("har fångat tjuven");
                Console.SetCursorPosition((23 - (targetPerson.Name.Length / 2)), strtRow+2);
                Console.WriteLine(targetPerson.Name);
                Console.SetCursorPosition(1, strtRow+3);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(1, strtRow+4);
                Console.WriteLine("░░░▒▒▒▒▒▒▓▓▓▓▓▓▓███████████████▓▓▓▓▓▓▓▒▒▒▒▒▒░░░");
                //Console.WriteLine($"Polisens position: ({police.XPos}, {police.YPos}), Tjuvens position: ({targetThief.XPos}, {targetThief.YPos})");
                ArrestThief((Police)actingPerson, (Thief)targetPerson); //Anropar ArrestTheif
            }

            else if (actingPerson is Citizen && targetPerson is Citizen && SamePlace)
            {
                //Console.WriteLine("En Tjuv har arresterats.");
                //Console.WriteLine($"Polisens position: ({police.XPos}, {police.YPos}), Tjuvens position: ({targetThief.XPos}, {targetThief.YPos})");
                Console.MoveBufferArea(movSrcLft, movSrcTop, movSrcWid, movSrcHgh, movDstLft, movDstTop);
                Console.ForegroundColor = (ConsoleColor)(rnd.Next(1, 15));
                Console.SetCursorPosition((17 - (actingPerson.Name.Length / 2)), strtRow);
                Console.WriteLine("Medborgaren " + actingPerson.Name);
                Console.SetCursorPosition(7, strtRow + 1);
                Console.WriteLine("gör en high five med medborgaren");
                Console.SetCursorPosition((23 - (targetPerson.Name.Length / 2)), strtRow+2);
                Console.WriteLine(targetPerson.Name);
                Console.SetCursorPosition(1, strtRow+3);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(1, strtRow+4);
                Console.WriteLine("░░░▒▒▒▒▒▒▓▓▓▓▓▓▓███████████████▓▓▓▓▓▓▓▒▒▒▒▒▒░░░");
            }
        }
        //public void ThiefMeetingCitizen(Thief thief, Citizen citizen)
        //{

        //}

        //Metod för rån
        public void RobCitizen(Thief thief, Citizen citizen)
        {
            Console.SetCursorPosition(160, 32);

            if (citizen.Belongings.Count > 0)
            {
                Console.SetCursorPosition(160, 37);
                Console.Write("Thief has " + (thief.Stolen.Count) + " items");
                Console.SetCursorPosition(160, 38);
                Console.Write("Citizen has " + (citizen.Belongings.Count) + " items");
                RobbedNumber++;

                Random random = new Random();
                int removeAtIndex = random.Next(citizen.Belongings.Count);

                string stolenItem = citizen.Belongings[removeAtIndex];
                citizen.Belongings.RemoveAt(removeAtIndex);
                thief.Stolen.Add(stolenItem);
                Console.SetCursorPosition(160, 39);
                Console.Write("Thief has " + (thief.Stolen.Count) + " items");
                Console.SetCursorPosition(160, 40);
                Console.Write("Citizen has " + (citizen.Belongings.Count) + " items");
            }
        }

        //Metod för arrest
        public void ArrestThief(Police police, Thief thief)
        {
            if (thief.Stolen.Count > 0)
            {
                ArrestedNumber++;
                police.Confiscated.AddRange(thief.Stolen);
                thief.Stolen.Clear();
                thief.IsArrested = true;
                thief.XPos = 3; thief.YPos = 30;
            }
        }

        public static void CitySummary()
        {
            //Console.WriteLine("______________________________________________________________________________________ ");
            Console.SetCursorPosition(160, 1);
            Console.WriteLine($"Antal rånade medborgare: {RobbedNumber}");
            Console.SetCursorPosition(160, 2);
            Console.WriteLine($"Antal gripna tjuvar: {ArrestedNumber}");
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
