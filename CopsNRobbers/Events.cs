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
        public void Meeting(Person person, Person otherPerson, List<Person> people)
        {
            bool SamePlace = person.YPos == otherPerson.YPos && person.XPos == otherPerson.XPos;

            // Thiefy()
            if (person is Thief && otherPerson is Citizen || person is Citizen && otherPerson is Thief && SamePlace)
            {
                Thiefy((Thief)person, (Citizen)otherPerson);
            }

            // Arrest()
            if (person is Police && otherPerson is Thief || person is Thief && otherPerson is Police && SamePlace)
            {
                Arrest((Police)person, (Thief)otherPerson, people);
            }
        }

        //Events
        //Metod för rån
        public void Thiefy(Thief thief, Citizen citizen)
        {
            Console.Write("\aEn tjuv smyger upp bakom en medborgare...");
            Thread.Sleep(2000);

            if (citizen.Belongings.Count > 0)
            {
                RobbedNumber++;

                //TEST från subklassen Thief
                Random random = new();
                int removeAtIndex = random.Next(citizen.Belongings.Count - 1);

                // Lägg till det valda föremålet i tjuvens "stolen" lista (tjuven stjäl föremålet).
                thief.Stolen.Add(citizen.Belongings[removeAtIndex]);

                // Ta bort det stulna föremålet från medborgarens "Belongings" lista (medborgaren förlorar föremålet).
                citizen.Belongings.RemoveAt(removeAtIndex);

                // Pausa i 2 sekunder (2000 millisekunder).
                Thread.Sleep(2000);
                string action = EventCards.Thiefy;
            }
            else
            {
                Console.Write("\aMedborgarens fickor var tomma, ingen stöds genomfördes.");
                Thread.Sleep(2000);
            }
        }

        //Metod för att hantera arrest
        public void Arrest(Police police, Thief thief, List<Person> people)
        {
            // Skriver ut ett meddelande om att polisen stannar och undersöker en tjuv.
            Console.Write("\aPolisen stannar och undersöker en tjuv...");
            Thread.Sleep(2000);

            // Kontrollerar om tjuven har stulit något.
            if (thief.Stolen.Count > 0)
            {
                // Ökar räknaren för antalet arresterade tjuvar.
                ArrestedNumber++;

                // Lägg till de stulna föremålen i polisens "Arrest" lista (konfiskering).
                police.Confiscated.AddRange(thief.Stolen);

                // Rensa tjuvens "stolen" lista (tjuven förlorar sina stulna föremål).
                thief.Stolen.Clear();

                // Markera tjuven som arresterad genom att sätta IsArrested till true.
                thief.IsArrested = true;

                // Tilldelar en händelse (action) från EventCards
                string action = EventCards.Thiefy;
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Tjuven hade inte stulit något.");
                Thread.Sleep(2000);
            }
        }

        //Skriva ut sammanfattning för tagna tjuvar och rånade medborgare i staden.
        public static void CitySummary()
        {
            Console.WriteLine("______________________________________________________________________________________ ");
            Console.WriteLine($"Antal rånade medborgare: {RobbedNumber}");
            Console.WriteLine($"Antal gripna tjuvar: {ArrestedNumber}");
        }
    }
}
