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

        public void Meeting(Person actingPerson, Person targetPerson)
        {
            bool SamePlace = actingPerson.YPos == targetPerson.YPos && actingPerson.XPos == targetPerson.XPos; // Bool om personerna är på samma plats

            if (actingPerson is Thief thief && targetPerson is Citizen citizen && SamePlace) //Om tjuv och medborgare är på samma plats
            {
                Console.SetCursorPosition(1, 30);
                Console.WriteLine("En medborgare har rånats.");
                //Console.WriteLine($"Tjuvens position: ({thief.XPos}, {thief.YPos}), Medborgarens position: ({citizen.XPos}, {citizen.YPos})");
                RobCitizen(thief, citizen); //Anropa RobCitizen

            }
            else if (actingPerson is Police police && targetPerson is Thief targetThief && SamePlace) //Om polis och tjuv är på samma plats
            {
                //Console.WriteLine("En Tjuv har arresterats.");
                //Console.WriteLine($"Polisens position: ({police.XPos}, {police.YPos}), Tjuvens position: ({targetThief.XPos}, {targetThief.YPos})");
                ArrestThief(police, targetThief); //Anropar ArrestTheif

            }
        }


        //Metod för rån
        public void RobCitizen(Thief thief, Citizen citizen)
        {
            if (citizen.Belongings.Count > 0)
            {
                RobbedNumber++;

                Random random = new Random();
                int removeAtIndex = random.Next(citizen.Belongings.Count);

                string stolenItem = citizen.Belongings[removeAtIndex];
                citizen.Belongings.RemoveAt(removeAtIndex);
                thief.Stolen.Add(stolenItem);

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
