namespace CopsNRobbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            Citizen citizen01 = new Citizen(5, 5, 2, "NW", "Greger-Dude");
            cityMap[citizen01.YPos, citizen01.XPos, citizen01.DPos] = citizen01.Symbol;

            Citizen citizen02 = new Citizen(19, 8, 2, "N", "Greger-Bro");
            cityMap[citizen02.YPos, citizen02.XPos, citizen02.DPos] = citizen02.Symbol;

            Citizen citizen03 = new Citizen(27, 1, 2, "S", "Greger the Citizen");
            cityMap[citizen03.YPos, citizen03.XPos, citizen03.DPos] = citizen03.Symbol;

            Thief thief01 = new Thief(3, 4, 1, "E", "Tjyv-Greger");
            cityMap[thief01.YPos, thief01.XPos, thief01.DPos] = thief01.Symbol;

            Police police01 = new Police(7, 2, 0, "SW", "Greger the Cop");
            cityMap[police01.YPos, police01.XPos, police01.DPos] = police01.Symbol;
            // ---------- Create Peeps END-----------------
            personsList.Add(citizen01);
            personsList.Add(citizen02);
            personsList.Add(citizen03);
            personsList.Add(thief01);
            personsList.Add(police01);
            City.DrawCityFrame(cityMap, cityHeight, cityWidth, cityDepth);
            while (true)
            {
                sinCity.DrawCity(cityMap, cityLeftStartCentered, cityTopStartCentered);
                cityMap = Person.MovePeeps(cityMap, personsList);
                Thread.Sleep(100);
            }
        }
    }
}