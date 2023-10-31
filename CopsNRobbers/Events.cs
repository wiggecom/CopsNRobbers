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
            bool SamePlace = actingPerson.YPos == targetPerson.YPos && actingPerson.XPos == targetPerson.XPos; // Bool om personerna är på samma plats
            // --------------------------------------------------------- TEST OF ANY COLLISION START -----------------------------------------------
            //Console.MoveBufferArea(1, 20, 40, 10, 1, 21);
            //Console.SetCursorPosition(1, 20);
            //Console.ForegroundColor = (ConsoleColor)(rnd.Next(1, 15));
            //Console.Write("En medborgare har ");
            //if (SamePlace)
            //{
            //    Type actingPersonType = actingPerson.GetType();
            //    Type targetPersonType = targetPerson.GetType();
            //    Console.WriteLine("dansat!, det var en " + actingPersonType + " och en " + targetPersonType);
            //}
            //else
            //{
            //    Console.WriteLine("svimmat!");
            //}
            // --------------------------------------------------------- TEST OF ANY COLLISION END -------------------------------------------------

            if (actingPerson is Thief && targetPerson is Citizen && SamePlace) //Om medborgare träffar tjuv
            {
                Console.MoveBufferArea(1, 20, 40, 10, 1, 21);
                Console.SetCursorPosition(1, 20);
                Console.ForegroundColor = (ConsoleColor)(rnd.Next(1, 15));
                Console.WriteLine(actingPerson.Name + " har rånats!");
                //Console.WriteLine($"Tjuvens position: ({thief.XPos}, {thief.YPos}), Medborgarens position: ({citizen.XPos}, {citizen.YPos})");
                //RobCitizen(actingPerson, targetPerson); //Anropa RobCitizen // Thief == actingPerson
            }
            else if (targetPerson is Thief && actingPerson is Citizen && SamePlace) //Om tjuv träffar medborgare
            {
                Console.MoveBufferArea(1, 20, 40, 10, 1, 21);
                Console.SetCursorPosition(1, 20);
                Console.ForegroundColor = (ConsoleColor)(rnd.Next(1, 15));
                Console.WriteLine(actingPerson.Name + " har rånats!!");
                //Console.WriteLine($"Tjuvens position: ({thief.XPos}, {thief.YPos}), Medborgarens position: ({citizen.XPos}, {citizen.YPos})");
                RobCitizen((Thief)targetPerson, (Citizen)actingPerson); //Anropa RobCitizen // Thief == targetPerson
            }
            else if ((actingPerson is Police && targetPerson is Thief && SamePlace) || (targetPerson is Police && actingPerson is Thief && SamePlace)) //Om polis och tjuv är på samma plats
            {
                //Console.WriteLine("En Tjuv har arresterats.");
                //Console.WriteLine($"Polisens position: ({police.XPos}, {police.YPos}), Tjuvens position: ({targetThief.XPos}, {targetThief.YPos})");
                //ArrestThief(police, targetThief); //Anropar ArrestTheif
                Console.MoveBufferArea(1, 20, 40, 10, 1, 21);
                Console.SetCursorPosition(1, 20);
                Console.ForegroundColor = (ConsoleColor)(rnd.Next(1, 15));
                Console.WriteLine("En tjuv har åkt dit!");
                RobbedNumber++;

            }
            else if (actingPerson is Citizen && targetPerson is Citizen && SamePlace)
            {
                //Console.WriteLine("En Tjuv har arresterats.");
                //Console.WriteLine($"Polisens position: ({police.XPos}, {police.YPos}), Tjuvens position: ({targetThief.XPos}, {targetThief.YPos})");
                //ArrestThief(police, targetThief); //Anropar ArrestTheif
                Console.MoveBufferArea(1, 20, 40, 10, 1, 21);
                Console.SetCursorPosition(1, 20);
                Console.ForegroundColor = (ConsoleColor)(rnd.Next(1, 15));
                Console.WriteLine("Medborgarna gör en high five!");
                

            }
        }
        //public void ThiefMeetingCitizen(Thief thief, Citizen citizen)
        //{

        //}

        //Metod för rån
        public void RobCitizen(Thief thief, Person citizen)
        {
            Console.SetCursorPosition(160, 32);
            
            if (thief.Stolen.Count > 0)
            {
                //if (citizen.Belongings.Count > 0)
                //{

                //}
            }
            //if (citizen.Belongings.Count > 0)
            //{
            //    RobbedNumber++;

            //    Random random = new Random();
            //    int removeAtIndex = random.Next(citizen.Belongings.Count);

            //    string stolenItem = citizen.Belongings[removeAtIndex];
            //    citizen.Belongings.RemoveAt(removeAtIndex);
            //    thief.Stolen.Add(stolenItem);

            //}
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
