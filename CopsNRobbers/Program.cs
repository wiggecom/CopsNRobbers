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
            // ---- City Size ---- //
            int cityWidth = 102;
            int cityHeight = 27;
            int cityDepth = 10;
            // ------------------- //

            if (cityWidth < 80)
            {
                Console.SetBufferSize((80 + 40), (cityHeight + 22));
                Console.SetWindowSize((80 + 40), (cityHeight + 22));
            }
            else
            {
                Console.SetBufferSize((cityWidth + 40), (cityHeight + 22));
                Console.SetWindowSize((cityWidth + 40), (cityHeight + 22));
            }
            int cityLeftStartCentered = (Console.WindowWidth / 2) - (cityWidth / 2);
            int cityTopStartCentered = (Console.WindowHeight / 2) - (cityHeight / 2);
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
            Citizen citizen01 = new Citizen(33, 14, 2, "E", "Greger-Dude");
            cityMap[citizen01.YPos, citizen01.XPos, citizen01.DPos] = citizen01.Symbol;
            Citizen citizen02 = new Citizen(38, 8, 2, "N", "Greger-Bro");
            cityMap[citizen02.YPos, citizen02.XPos, citizen02.DPos] = citizen02.Symbol;
            Citizen citizen03 = new Citizen(55, 6, 2, "S", "Greger the Citizen");
            cityMap[citizen03.YPos, citizen03.XPos, citizen03.DPos] = citizen03.Symbol;
            Citizen citizen04 = new Citizen(42, 10, 2, "W", "Greger-Bro 2");
            cityMap[citizen04.YPos, citizen04.XPos, citizen04.DPos] = citizen04.Symbol;

            Citizen citizen05 = new Citizen(50, 7, 2, "NE", "Greger the Citizen Jr");
            cityMap[citizen05.YPos, citizen05.XPos, citizen05.DPos] = citizen05.Symbol;
            Citizen citizen06 = new Citizen(58, 15, 2, "SE", "Greger the Citizen Jr");
            cityMap[citizen06.YPos, citizen06.XPos, citizen06.DPos] = citizen06.Symbol;
            Citizen citizen07 = new Citizen(29, 9, 2, "NW", "Greger the Citizen Jr");
            cityMap[citizen07.YPos, citizen07.XPos, citizen07.DPos] = citizen07.Symbol;
            Citizen citizen08 = new Citizen(33, 10, 2, "SW", "Greger the Citizen Jr");
            cityMap[citizen08.YPos, citizen08.XPos, citizen08.DPos] = citizen08.Symbol;

            Thief thief01 = new Thief(32, 4, 1, "E", "Tjyv-Greger");
            cityMap[thief01.YPos, thief01.XPos, thief01.DPos] = thief01.Symbol;

            Police police01 = new Police(49, 6, 0, "SW", "Greger the Cop");
            cityMap[police01.YPos, police01.XPos, police01.DPos] = police01.Symbol;
            // ---------- Create Peeps END-----------------
            personsList.Add(citizen01);
            personsList.Add(citizen02);
            personsList.Add(citizen03);
            personsList.Add(citizen04);
            personsList.Add(citizen05);
            personsList.Add(citizen06);
            personsList.Add(citizen07);
            personsList.Add(citizen08);
            personsList.Add(thief01);
            personsList.Add(police01);
            //City.PutCityFrame(cityMap, cityHeight, cityWidth, cityDepth);
            cityMap = City.PutMapOnLayer(cityHeight, cityWidth, cityDepth, cityMap);
            sinCity.DrawCity(cityMap, cityLeftStartCentered, cityTopStartCentered);
            int i = 0; // ---------------------------------------------------------------------------- TMP LOOP REDRAW CITY EVERY 10th TURN
            while (true)
            {
                cityMap = Person.MovePeeps(cityMap, personsList);

                // ------------------------------------------------------------------------------ START REDRAW LOOP
                if (i == 9)
                {
                    sinCity.DrawCity(cityMap, cityLeftStartCentered, cityTopStartCentered);
                    i = 0;
                }
                else
                {
                    i++;
                }
                // ------------------------------------------------------------------------------- END REDRAW LOOP
                Thread.Sleep(100);
            }
        }
    }
}