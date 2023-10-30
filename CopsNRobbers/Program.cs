using System.Collections;

namespace CopsNRobbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            0 ;   // Black
            8 ;   // DarkGray
            7 ;   // Gray
            15;   // White
            1 ;   // DarkBlue
            9 ;   // Blue
            3 ;   // DarkCyan
            11;   // Cyan
            2 ;   // DarkGreen
            10;   // Green
            6 ;   // DarkYellow
            14;   // Yellow
            5 ;   // DarkMagenta
            13;   // Magenta
            4 ;   // DarkRed
            12;   // Red
            */
            Console.CursorVisible = false;
            bool pacMan = false; // Toggles bounce / pacman
            // City.cs/city/PutMapOnLayer to switch map
            // ---- City Size ---- //
            int cityWidth = 102;
            int cityHeight = 40;
            int cityDepth = 10;
            // ------------------- //
            Console.SetBufferSize((200), 50);
            Console.SetWindowSize((200), 50);
            //if (cityWidth < 80)
            //{
            //    Console.SetBufferSize((80 + 80), 50);
            //    Console.SetWindowSize((80 + 80), 50);
            //}
            //else
            //{
            //    Console.SetBufferSize((cityWidth + 40), 50);
            //    Console.SetWindowSize((cityWidth + 40), 50);
            //}
            int cityLeftStartCentered = (Console.WindowWidth / 2) - (cityWidth / 2);

            // Switch comment to change between set position or centered, here, in method Person.ClearPerson and Person.PlacePerson
            // int cityTopStartCentered = (Console.WindowHeight / 2) - (cityHeight / 2);
            int cityTopStartCentered = 7; // - OVERRIDE HORIZONTAL CENTERING -


            Events events = new Events(); //Skapar en instans av Events klassen


            Gfx.DrawSinCity(cityTopStartCentered);
            City sinCity = new City(cityWidth, cityHeight, cityDepth);
            string[,,] cityMap = sinCity.MakeCity(sinCity);
            cityMap = sinCity.FillCity(cityMap);
            Gfx.LocalPeeps();
            Gfx.CityFrame(cityWidth, cityHeight, cityLeftStartCentered, cityTopStartCentered);
            string[] directionString =
{
                "N",
                "NE",
                "NE",
                "NE",
                "E",
                "SE",
                "SE",
                "SE",
                "S",
                "SW",
                "SW",
                "SW",
                "W",
                "NW",
                "NW",
                "NW"
            };
            List<Person> personsList = new List<Person>();
            // ---------- Create Peeps BEGIN -----------------
            Citizen citizen01 = new Citizen(46, 12, 2, "E", "Greger-Dude");
            cityMap[citizen01.YPos, citizen01.XPos, citizen01.DPos] = citizen01.Symbol;
            Citizen citizen02 = new Citizen(47, 13, 2, "N", "Greger-Bro");
            cityMap[citizen02.YPos, citizen02.XPos, citizen02.DPos] = citizen02.Symbol;
            Citizen citizen03 = new Citizen(51, 9, 2, "S", "Greger the Citizen");
            cityMap[citizen03.YPos, citizen03.XPos, citizen03.DPos] = citizen03.Symbol;
            Citizen citizen04 = new Citizen(54, 15, 2, "W", "Greger-Bro 2");
            cityMap[citizen04.YPos, citizen04.XPos, citizen04.DPos] = citizen04.Symbol;
            Citizen citizen05 = new Citizen(10, 10, 2, "NE", "Greger the Citizen Jr");
            cityMap[citizen05.YPos, citizen05.XPos, citizen05.DPos] = citizen05.Symbol;


            Citizen citizen06 = new Citizen(1, 1, 2, "E", "Jon-Greger");
            cityMap[citizen06.YPos, citizen06.XPos, citizen06.DPos] = citizen06.Symbol;
            Citizen citizen07 = new Citizen(1, 2, 2, "E", "Greger the Citizen");
            cityMap[citizen07.YPos, citizen07.XPos, citizen07.DPos] = citizen07.Symbol;
            Citizen citizen08 = new Citizen(1, 3, 2, "E", "Greger the Citizen");
            cityMap[citizen08.YPos, citizen08.XPos, citizen08.DPos] = citizen08.Symbol;
            Citizen citizen09 = new Citizen(1, 4, 2, "E", "Greger the Citizen");
            cityMap[citizen09.YPos, citizen09.XPos, citizen09.DPos] = citizen09.Symbol;
            Citizen citizen10 = new Citizen(1, 5, 2, "E", "Greger the Citizen");
            cityMap[citizen10.YPos, citizen10.XPos, citizen10.DPos] = citizen10.Symbol;
            Citizen citizen11 = new Citizen(1, 6, 2, "E", "Greger the Citizen");
            cityMap[citizen11.YPos, citizen11.XPos, citizen11.DPos] = citizen11.Symbol;
            Citizen citizen12 = new Citizen(1, 7, 2, "E", "Greger the Citizen");
            cityMap[citizen12.YPos, citizen12.XPos, citizen12.DPos] = citizen12.Symbol;
            Citizen citizen13 = new Citizen(1, 8, 2, "E", "Greger the Citizen");
            cityMap[citizen13.YPos, citizen13.XPos, citizen13.DPos] = citizen13.Symbol;
            Citizen citizen14 = new Citizen(1, 9, 2, "E", "Greger the Citizen");
            cityMap[citizen14.YPos, citizen14.XPos, citizen14.DPos] = citizen14.Symbol;
            Citizen citizen15 = new Citizen(1, 10, 2, "E", "Greger the Citizen");
            cityMap[citizen15.YPos, citizen15.XPos, citizen15.DPos] = citizen15.Symbol;
            Citizen citizen16 = new Citizen(1, 11, 2, "E", "Greger the Citizen");
            cityMap[citizen16.YPos, citizen16.XPos, citizen16.DPos] = citizen16.Symbol;

            //Citizen citizen06 = new Citizen(60, 10, 2, "SE", "Greger the Citizen Jr");
            //cityMap[citizen06.YPos, citizen06.XPos, citizen06.DPos] = citizen06.Symbol;
            //Citizen citizen07 = new Citizen(65, 8, 2, "NW", "Greger the Citizen Jr");
            //cityMap[citizen07.YPos, citizen07.XPos, citizen07.DPos] = citizen07.Symbol;
            //Citizen citizen08 = new Citizen(70, 19, 2, "SW", "Greger the Citizen Jr");
            //cityMap[citizen08.YPos, citizen08.XPos, citizen08.DPos] = citizen08.Symbol;

            Thief thief01 = new Thief(56, 12, 1, "NE", "Tjyv-Greger");
            cityMap[thief01.YPos, thief01.XPos, thief01.DPos] = thief01.Symbol;
            Thief thief02 = new Thief(1, 1, 1, "SE", "Tjyv-Greger");
            cityMap[thief02.YPos, thief02.XPos, thief02.DPos] = thief02.Symbol;
            Thief thief03 = new Thief(100, 1, 1, "SW", "Tjyv-Greger");
            cityMap[thief03.YPos, thief03.XPos, thief03.DPos] = thief03.Symbol;

            Police police01 = new Police(49, 6, 0, "SW", "Greger the Cop");
            cityMap[police01.YPos, police01.XPos, police01.DPos] = police01.Symbol;
            Police police02 = new Police(1, 25, 0, "NE", "Greger the Cop");
            cityMap[police02.YPos, police02.XPos, police02.DPos] = police02.Symbol;
            Police police03 = new Police(100, 25, 0, "NW", "Greger the Cop");
            cityMap[police03.YPos, police03.XPos, police03.DPos] = police03.Symbol;

            // ---------- Create Peeps END-----------------
            personsList.Add(citizen01);
            personsList.Add(citizen02);
            personsList.Add(citizen03);
            personsList.Add(citizen04);
            personsList.Add(citizen05);
            personsList.Add(citizen06);
            personsList.Add(citizen07);
            personsList.Add(citizen08);
            personsList.Add(citizen09);
            personsList.Add(citizen15);
            personsList.Add(citizen14);
            personsList.Add(citizen13);
            personsList.Add(citizen12);
            personsList.Add(citizen11);
            personsList.Add(citizen10);
            personsList.Add(citizen16);
            personsList.Add(thief01);
            personsList.Add(thief02);
            personsList.Add(thief03);
            personsList.Add(police01);
            personsList.Add(police02);
            personsList.Add(police03);
            //City.PutCityFrame(cityMap, cityHeight, cityWidth, cityDepth);
            cityMap = City.PutMapOnLayer(cityHeight, cityWidth, cityDepth, cityMap);
            sinCity.DrawCity(cityMap, cityLeftStartCentered, cityTopStartCentered);

            while (true)
            {
                //Console.ReadKey();
                cityMap = Person.MovePeeps(cityMap, personsList, pacMan);
                pacMan = Toggle(pacMan, cityMap);
                //                Meetings(events, personsList);
                // Loopa genom befolkningen och hitta möten.
                for (int i = 0; i < personsList.Count; i++)
                {
                    for (int j = i + 1; j < personsList.Count; j++)
                    {
                        events.Meeting(personsList[i], personsList[j]);
                        if ((personsList[i].XPos == personsList[i].XPos) && (personsList[j].YPos == personsList[j].YPos))
                        {
                            Random rnd = new Random();

                            Console.ForegroundColor = (ConsoleColor)(rnd.Next(1,16));
                            Console.SetCursorPosition(160, 5+j);
                            Console.Write(i + " " + j);
                        }
                        
                    }
                }
                Events.CitySummary();
                Thread.Sleep(120); // ----------------------------------------------  SLEEP -----------------------------------------------------
                //pacMan = Toggle(pacMan, cityMap);
            }
        }
        //public static void Meetings(Events events, List<Person> personsList)
        //{
        //    // Loopa genom befolkningen och hitta möten.
        //    for (int i = 0; i < personsList.Count; i++)
        //    {
        //        for (int j = i + 1; j < personsList.Count; j++)
        //        {
        //            events.Meeting(personsList[i], personsList[j]);
        //        }
        //    }
        //    //return events;
        //}
        public static bool Toggle(bool pacMan, string[,,] cityMap)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Spacebar:
                        if (pacMan == true)
                        {
                            pacMan = false;
                        }
                        else if (pacMan == false)
                        {
                            pacMan = true;
                        }

                        break;
                    default:
                        break;
                }

            }
            return pacMan;
        }
    }
}