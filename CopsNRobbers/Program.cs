namespace CopsNRobbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            // ---- City Size ---- //
            int cityWidth = 100;
            int cityHeight = 25;
            int cityDepth = 5;
            // ------------------- //

            if (cityWidth < 80)
            {
                Console.SetWindowSize((80+40), (cityHeight + 15));
            }
            else
            {
                Console.SetWindowSize((cityWidth + 40), (cityHeight + 15));
            }

            int cityLeftStartCentered = (Console.WindowWidth / 2) - (cityWidth / 2);
            int cityTopStartCentered = (Console.WindowHeight / 2) - (cityHeight / 2);
            Gfx.DrawSinCity(cityTopStartCentered);
            City sinCity = new City(cityWidth, cityHeight, cityDepth);
            string[,,] cityMap = sinCity.MakeCity(sinCity);
            cityMap = sinCity.FillCity(cityMap);
            Gfx.LocalPeeps();
            Gfx.CityFrame(cityWidth, cityHeight, cityLeftStartCentered, cityTopStartCentered);
            sinCity.DrawCity(cityMap, cityLeftStartCentered, cityTopStartCentered);


            //while (true) // Gfx display loop
            //{
            //    // Single color graphics
            //Gfx.DrawRobberySingleCol();
            //Console.WriteLine();
            //Gfx.DrawBustedSingleCol();
            //Console.WriteLine();
            //Console.ReadKey();

            // Dual color graphics
            //Console.Clear();
            //Gfx.DrawRobbery();
            //Console.WriteLine();
            //Gfx.DrawBusted();
            //Console.WriteLine();
            //Console.ReadKey();
            //}


            // ☺ ☻ ♥ ♦ ♣ ♠ • ◘ ○ ◙ ♂ ♀ ♪ ♫ ☼ ► ◄ ↕ ‼ ¶ § ▬ ↨ ↑ ↓
            // → ← ∟ ↔ ▲ ▼ ^ ` ⌂ Ü ü º¿¡ ⌐ ¬ ª ® © « » ░ ▒ ▓ █ ▄ ▌▐ ▀
            // │ ┤ ╡ ╢ ╖ ╕ ╣ ║ ╗ ╝ ╜ ╛ ┐ └ ┴ ├ ├ ─ ┼ ╞
            //  ╟ ╚ ╔ ╩ ╦ ╠ ═ ╬ ╧ ╨ ╤ ╥ ╙ ╘ ╒ ╓ ╫ ╪ ┘ ┌
            // - _ / | \
            //
            // DrawHotkeysFrame
        }
    }
}