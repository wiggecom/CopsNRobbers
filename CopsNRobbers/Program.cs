using System.Collections;
using System.Collections.Generic;

namespace CopsNRobbers
{
    internal class Program
    {
        public static int sleepy = 20;
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            bool pacMan = false; // Toggles bounce / pacman


            // ---- City Size ---- //
            int cityWidth = 102;
            int cityHeight = 40;
            int cityDepth = 10;
            int citizensTotal = 3;
            int thievesTotal = 2;
            int copsTotal = 1;
            int sentencePerItem = 10;
            // ------------------- //
            Gfx.SplashScreen(20, 12);  // ----------------------------- SPLASH ---------------------------
            Console.SetBufferSize((200), 50);
            Console.SetWindowSize((200), 50);
            int cityFilled = Splash.SelectMap();      //  <----------  switch map
            int cityLeftStartCentered = (Console.WindowWidth / 2) - (cityWidth / 2);

            // Switch comment to change between set position or centered, here, in method Person.ClearPerson and Person.PlacePerson
            // int cityTopStartCentered = (Console.WindowHeight / 2) - (cityHeight / 2);
            int cityTopStartCentered = 7; // - OVERRIDE HORIZONTAL CENTERING -

            Random rnd = new Random();

            Events events = new Events(); //Skapar en instans av Events klassen

            Gfx.DrawSinCity(cityTopStartCentered);
            City sinCity = new City(cityWidth, cityHeight, cityDepth);
            string[,,] cityMap = sinCity.MakeCity(sinCity);
            cityMap = sinCity.FillCity(cityMap);
            Gfx.LocalPeeps();
            Gfx.CityFrame(cityWidth, cityHeight, cityLeftStartCentered, cityTopStartCentered);

            List<Person> personsList = new List<Person>();

            cityMap = City.PutMapOnLayer(cityHeight, cityWidth, cityDepth, cityMap, cityFilled);

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
            sinCity.DrawCity(cityMap, cityLeftStartCentered, cityTopStartCentered);

            Console.SetCursorPosition(1, 9);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("███████████████████░N░E░W░S░███▓▓▓▓▓▓▓▒▒▒▒▒▒░░░");
            Console.SetCursorPosition(152, 9);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("░░░▒▒▒▒▒▒▓▓▓▓▓▓▓███░S░T░A░T░S░████████████████");

            while (true)
            {
                //Console.ReadKey();
                cityMap = Person.MovePeeps(cityMap, personsList, pacMan);
                //pacMan = Toggle(pacMan, cityMap);

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
                        case ConsoleKey.D2:
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
                        case ConsoleKey.D3:
                            charPosX = rnd.Next(18, 83);
                            charPosY = rnd.Next(8, 18);
                            personsList.Add(new Thief(charPosX, charPosY, 1, Person.DirectionStr(), Thief.ThiefName(), sentencePerItem));
                            thievesTotal++;
                            break;
                        case ConsoleKey.D4:
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
                        case ConsoleKey.D5:
                            charPosX = rnd.Next(18, 83);
                            charPosY = rnd.Next(8, 18);
                            personsList.Add(new Police(charPosX, charPosY, 0, Person.DirectionStr(), Police.PoliceName()));
                            copsTotal++;
                            break;
                        case ConsoleKey.D6:
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
                        case ConsoleKey.D7:
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
                        case ConsoleKey.D8:
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


                Thread.Sleep(sleepy); // ----------------------------------------------  SLEEP -----------------------------------------------------
            } 
        }
    }
}
