﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicesNThiefs
{
    internal class Events
    {
        // Statiska variabler för att hålla räkning på antalet rånade medborgare och gripna tjuvar.
        private static int RobbedNumber = 0;
        private static int ArrestedNumber = 0;

        //Encounter
        private void Meeting(Person person, Person otherPerson, List<Person> people)
        {
            bool SamePlace = person.YPos == otherPerson.YPos && person.XPos == otherPerson.XPos;
            
            // Thiefy()
            if (person is thief && otherPerson is Citizen && SamePlace)
            {
                Thiefy((Thief)person, (Citizen)otherPerson);
            }
            else if (person is Citizen && otherPerson is thief && SamePlace)
            {
                Thiefy((Thief)otherPerson, (Citizen)person);
            }

            // Arrest()
            if (person is Police && otherPerson is thief && SamePlace)
            {
                Arrest((Police)person, (Thief)otherPerson, people);
            }
            else if (person is thief && otherPerson is Police && SamePlace)
            {
                Arrest((Police)otherPerson, (Thief)person, people);
            }
        }

        //Events
        //Metod för rån
        private void Thiefy(Thief Thief, Citizen citizen)
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
                Thief.Stolen.Add(citizen.Belongings[removeAtIndex]);

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
        private void Arrest(Police Police, Thief Thief, List<Person> people)
        {
            // Skriver ut ett meddelande om att polisen stannar och undersöker en tjuv.
            Console.Write("\aPolisen stannar och undersöker en tjuv...");
            Thread.Sleep(2000);

            // Kontrollerar om tjuven har stulit något.
            if (Thief.Stolen.Count > 0)
            {
                // Ökar räknaren för antalet arresterade tjuvar.
                ArrestedNumber++;

                // Polisen utför en arrest av tjuven.
                Police.Arrest(Thief);

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
