using System.Collections;
using System.Collections.Generic;

namespace CopsNRobbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            bool pacMan = false; // Simulation starts with bounce-mode

            // ---- City Size ---- //
            int cityWidth = 102;
            int cityHeight = 40;
            int cityDepth = 10;

            // ---- Misc Settings ---- //
            int citizensTotal = 3;
            int thievesTotal = 2;
            int copsTotal = 1;
            int sentencePerItem = 10;
            int sleepy = 20;

            Random rnd = new Random();
            Events events = new Events();
            List<Person> personsList = new List<Person>();

            Splash.SplashScreen(20, 12);  // - SPLASH -
            Console.SetBufferSize((200), 50);
            Console.SetWindowSize((200), 50);

            int cityFilled = Splash.SelectMap(); //  <- Map Selector
            int cityLeftStartCentered = (Console.WindowWidth / 2) - (cityWidth / 2);
            
            // int cityTopStartCentered = (Console.WindowHeight / 2) - (cityHeight / 2);
            int cityTopStartCentered = 7; // - Fixed location due to features -

            Gfx.DrawSinCity(cityTopStartCentered);
            City sinCity = new City(cityWidth, cityHeight, cityDepth);
            string[,,] cityMap = sinCity.MakeCity(sinCity);
            cityMap = sinCity.FillCity(cityMap);
            Gfx.LocalPeeps();
            Gfx.CityFrame(cityWidth, cityHeight, cityLeftStartCentered, cityTopStartCentered);

            cityMap = City.PutMapOnLayer(cityHeight, cityWidth, cityDepth, cityMap, cityFilled);

            #region Make Base Actors
            for (int i = 0; i < citizensTotal; i++)
            {
                int charPosX = rnd.Next(18, 83);
                int charPosY = rnd.Next(8, 18);
                personsList.Add(new Citizen(charPosX, charPosY, 2, Person.DirectionStr(), Citizen.CitizenName()));
            }
            for (int i = 0; i < thievesTotal; i++)
            {
                int charPosX = rnd.Next(18, 83);
                int charPosY = rnd.Next(8, 18);
                personsList.Add(new Thief(charPosX, charPosY, 1, Person.DirectionStr(), Thief.ThiefName(), sentencePerItem));
            }
            for (int i = 0; i < copsTotal; i++)
            {
                int charPosX = rnd.Next(18, 83);
                int charPosY = rnd.Next(8, 18);
                personsList.Add(new Police(charPosX, charPosY, 0, Person.DirectionStr(), Police.PoliceName()));
            }
            #endregion
            sinCity.DrawCity(cityMap, cityLeftStartCentered, cityTopStartCentered);


            #region Main Loop
            while (true)
            {
                cityMap = Person.MovePeeps(cityMap, personsList, pacMan);

                // Loopa genom befolkningen och hitta möten.
                for (int i = 0; i < personsList.Count; i++)
                {
                    for (int j = i + 1; j < personsList.Count; j++)
                    {
                        if ((personsList[i].XPos == personsList[j].XPos) && (personsList[i].YPos == personsList[j].YPos))
                        {
                            events.Meeting(personsList[i], personsList[j]);
                        }

                    }
                }
                Events.CitySummary(personsList, cityLeftStartCentered, cityTopStartCentered, sleepy, citizensTotal, thievesTotal, copsTotal, pacMan, sentencePerItem);

                #region Read Keys
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    int charPosX = 0;
                    int charPosY = 0;
                    switch (key.Key)
                    {
                        case ConsoleKey.F1:
                            if (pacMan == true)
                            {
                                pacMan = false;
                            }
                            else if (pacMan == false)
                            {
                                pacMan = true;
                            }
                            break;
                        case ConsoleKey.F2:
                            sleepy = 100;
                            break;
                        case ConsoleKey.F3:
                            sleepy = 50;
                            break;
                        case ConsoleKey.F4:
                            sleepy = 20;
                            break;
                        case ConsoleKey.F5:
                            sleepy = 0;
                            break;
                        case ConsoleKey.D1:
                            charPosX = rnd.Next(18, 83);
                            charPosY = rnd.Next(8, 18);
                            personsList.Add(new Citizen(charPosX, charPosY, 2, Person.DirectionStr(), Citizen.CitizenName()));
                            citizensTotal++;
                            break;
                        case ConsoleKey.D5:
                            foreach (Person person in personsList)
                            {
                                if (person is Citizen)
                                {
                                    Console.SetCursorPosition(person.XPos+49, person.YPos+7);
                                    Console.Write(" ");
                                    personsList.Remove(person);
                                    if (citizensTotal > 0)
                                    {
                                        citizensTotal--;
                                    }
                                    break;
                                }
                            }
                            break;
                        case ConsoleKey.D2:
                            charPosX = rnd.Next(18, 83);
                            charPosY = rnd.Next(8, 18);
                            personsList.Add(new Thief(charPosX, charPosY, 1, Person.DirectionStr(), Thief.ThiefName(), sentencePerItem));
                            thievesTotal++;
                            break;
                        case ConsoleKey.D6:
                            foreach (Person person in personsList)
                            {
                                if (person is Thief)
                                {
                                    Console.SetCursorPosition(person.XPos + 49, person.YPos + 7);
                                    Console.Write(" ");
                                    personsList.Remove(person);
                                    if (thievesTotal > 0)
                                    {
                                        thievesTotal--;
                                    }
                                    break;
                                }
                            }
                            break;
                        case ConsoleKey.D3:
                            charPosX = rnd.Next(18, 83);
                            charPosY = rnd.Next(8, 18);
                            personsList.Add(new Police(charPosX, charPosY, 0, Person.DirectionStr(), Police.PoliceName()));
                            copsTotal++;
                            break;
                        case ConsoleKey.D7:
                            foreach (Person person in personsList)
                            {
                                if (person is Police)
                                {
                                    Console.SetCursorPosition(person.XPos + 49, person.YPos + 7);
                                    Console.Write(" ");
                                    personsList.Remove(person);
                                    if (copsTotal > 0)
                                    {
                                        copsTotal--;
                                    }
                                    break;
                                }
                            }
                            break;
                        case ConsoleKey.D9:
                            if (sentencePerItem >=40)
                            {
                                sentencePerItem -= 10;
                            }
                            if (sentencePerItem > 5)
                            {
                                sentencePerItem -= 5;
                            }
                            else if (sentencePerItem > 1)
                            {
                                sentencePerItem--;
                            }
                            else
                            {
                                sentencePerItem = 1;
                            }
                            break;
                        case ConsoleKey.D0:
                            if (sentencePerItem < 60)
                            {
                                if (sentencePerItem >= 30)
                                {
                                    sentencePerItem += 10;
                                }
                                else if (sentencePerItem >= 5)
                                {
                                    sentencePerItem+=5;
                                }
                                else
                                {
                                    sentencePerItem++;
                                }
                            }
                            break;
                        default:
                            break;
                    }

                }
                #endregion

                Thread.Sleep(sleepy); // ----------------------------------------------  SLEEP -----------------------------------------------------
            }
            #endregion
        }
    }
}
