using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopsNRobbers
{
    internal class Gfx
    {
        public static void DrawTinyClear(int startX, int startY)
        {
            Console.SetCursorPosition(startX, startY);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("                                                          ");

            Console.SetCursorPosition(startX, startY+1);
            Console.Write("                                                          ");

            Console.SetCursorPosition(startX, startY + 2);
            Console.Write("                                                          ");

            Console.SetCursorPosition(startX, startY + 3);
            Console.Write("                                                          ");

            Console.SetCursorPosition(startX, startY + 4);
            Console.Write("                                                          ");

            Console.SetCursorPosition(startX, startY + 5);
            Console.Write("                                                          ");

            Console.SetCursorPosition(startX, startY + 6);
            Console.Write("                                                          ");

            Console.SetCursorPosition(startX, startY + 7);
            Console.Write("                                                          ");

            Console.SetCursorPosition(startX, startY + 8);
            Console.Write("                                                          ");

            Console.SetCursorPosition(startX, startY + 9);
            Console.Write("                                                          ");

            Console.SetCursorPosition(startX, startY + 10);
            Console.Write("                                                          ");

            Console.SetCursorPosition(startX, startY + 11);
            Console.Write("                                                          ");
        }
        public static void DrawTinyRobbery(int startX, int startY)
        {
            Console.SetCursorPosition(startX, startY);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("      ░░░░░░░░░░                 ");

            Console.SetCursorPosition(startX, startY + 1);
            Console.Write("    ░░░░░░░░░░░░░                ");

            Console.SetCursorPosition(startX, startY + 2);
            Console.Write("   ░░░░░░░░░░░░░░░               ");

            Console.SetCursorPosition(startX, startY + 3);
            Console.Write("  ░░░░▒▒▒▒▒▒▒▒▒▒░░             ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█▓");

            Console.SetCursorPosition(startX, startY + 4);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  ░░░                         ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█▓▒░");

            Console.SetCursorPosition(startX, startY + 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  ░         ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▒█▓");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("   ░          ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█▓▒░");

            Console.SetCursorPosition(startX, startY + 6);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  ░░░▒▒          ▒▒░        ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█▓▒░");

            Console.SetCursorPosition(startX, startY + 7);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("   ░░▒▒▒▒░░░░░░░░░░░░      ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█▓▒░");

            Console.SetCursorPosition(startX, startY + 8);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("   ░░░▒▒░");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▓▒▓▒▓▒▓▒▓");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("       ██▓▒░");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("▒▒");

            Console.SetCursorPosition(startX, startY + 9);
            Console.Write("   ░░ ░▒▒░");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▓▒▓▒▓");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("░░░      ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("▓");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("▒▒");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("░░░");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("▒░▒▒");

            Console.SetCursorPosition(startX, startY + 10);
            Console.Write("   ░  ░▒▒▒░░░░▒░         ▒▒▒▒");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("░░░");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("▒░░");

            Console.SetCursorPosition(startX, startY + 11);
            Console.Write("     ░▒▒▒▒▒▒▒░             ▒▒▒▒");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("░░░");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void DrawTinyRobberyTxt(int startX, int startY)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(startX, startY+3);
            Console.Write("      ████   ███  ████  ████  █████ ████  █   █ █ █ █ ");
            Console.SetCursorPosition(startX, startY+4);
            Console.Write("      █░░░█ █ ░░█ █ ░░█ █ ░░█ █░░░░░█░░░█  █ █ ░█░█░█░");
            Console.SetCursorPosition(startX, startY + 5);
            Console.Write("      ████ ░█░  █░████ ░█████░███   ████ ░  █ ░ █░█░█░");
            Console.SetCursorPosition(startX, startY + 6);
            Console.Write("      █░░░█ █░  █░█ ░░█ █ ░░█ █░░░  █░░░█   █░   ░ ░ ░");
            Console.SetCursorPosition(startX, startY + 7);
            Console.Write("      █░  █░ ███ ░████ ░████ ░█████ █░  █░  █░  █ █ █ ");
            Console.SetCursorPosition(startX, startY + 8);
            Console.Write("       ░   ░  ░░░  ░░░░  ░░░░  ░░░░░ ░   ░   ░   ░ ░ ░");


            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void DrawTinyBusted(int startX, int startY)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(startX, startY);  // 0
            Console.Write("▓▓▓▓████▓▓▓▓███▓▓▓▓████▓▓▓▓████▓▓▓▓██▓▓");

            Console.SetCursorPosition(startX, startY+1); // 1
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    ░▒░   ░▒░   ░▒░   ░▒░   ░▒░    ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██");

            Console.SetCursorPosition(startX, startY + 2); // 2
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("▓▓");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    ▒▓▒   ▒▓▒   ▒▓▒   ▒▓▒   ▒▓▒    ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("▓▓");

            Console.SetCursorPosition(startX, startY + 3); // 3
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    ▒▓▒   ▒▓▒   ▒▓▒   ▒▓▒   ▒▓▒    ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██");

            Console.SetCursorPosition(startX, startY + 4); // 4
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("▓▓");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    ▒▓▒");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("░▓▓███▓▒ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▒▓▒ ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("▒▓███▓▓░");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▒▓▒    ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("▓▓");

            Console.SetCursorPosition(startX, startY + 5); // 5
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    ▒▓░");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("▓▓▓░▒░   ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▒▓▒   ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("░▒░▓▓▓");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░▓▒    ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██");

            Console.SetCursorPosition(startX, startY + 6); // 6
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("▓▓");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    ▒▓░");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("▓▓▓███▓▒ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▒▓▒ ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("▒▓███▓▓▓");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░▓▒    ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("▓▓");

            Console.SetCursorPosition(startX, startY + 7); // 7
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    ▒▓░");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("▓▓▓░▒░   ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▒▓▒   ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("░▒░▓▓▓");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░▓▒    ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██");

            Console.SetCursorPosition(startX, startY + 8); // 8
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("▓▓");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    ▒▓░");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("░▓▓███▓▒ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▒▓▒ ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("▒▓███▓▓░");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░▓▒    ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("▓▓");

            Console.SetCursorPosition(startX, startY + 9); // 9
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    ▒▓░   ░▒░   ▒▓▒   ░▒░   ░▓▒    ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██");

            Console.SetCursorPosition(startX, startY + 10); // 10
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    ▒▓░   ░▒░   ▒▓▒   ░▒░   ░▓▒    ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("██");

            Console.SetCursorPosition(startX, startY + 11); // 11
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("▓▓▓▓████▓▓▓▓███▓▓▓▓████▓▓▓▓████▓▓▓▓██▓▓");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void DrawTinyBustedTxt(int startX, int startY)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(startX, startY+3);  // 0
            Console.Write("       █████  ██  ██ █████ ██████ ████ █████    ███");

            Console.SetCursorPosition(startX, startY+4);  // 0
            Console.Write("       ██░░██ ██░ ██░██░░░░  ██░░░██░░░██░░██   ███░");

            Console.SetCursorPosition(startX, startY+5);  // 0
            Console.Write("       █████░░██░ ██░ ███    ██░  ███  ██░  █░   █░░");

            Console.SetCursorPosition(startX, startY+6);  // 0
            Console.Write("       ██░░██ ██░ ██░   ██   ██░  ██░░ ██░ ██░    ░ ");

            Console.SetCursorPosition(startX, startY+7);  // 0
            Console.Write("       █████░░ ████░░████░░  ██░  ████ █████░░   █  ");

            Console.SetCursorPosition(startX, startY+8);  // 0
            Console.Write("        ░░░░░   ░░░░  ░░░░    ░░   ░░░░ ░░░░░     ░ ");

        }
        public static void DrawTinyBumTxt(int startX, int startY)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(startX, startY + 3);  // 1
            Console.Write("           █████   ██  ██  ██     ██  ████  ████ ");
            Console.SetCursorPosition(startX, startY + 4);  // 2
            Console.Write("           ██▒▒██  ██▒ ██▒ ███▒  ███▒ ████▒ ████▒");
            Console.SetCursorPosition(startX, startY + 5);  // 3
            Console.Write("           █████▒▒ ██▒ ██▒ ████▒████▒  ██▒▒  ██▒▒");
            Console.SetCursorPosition(startX, startY + 6);  // 4
            Console.Write("           ██▒▒██  ██▒ ██▒ ██▒███▒██▒   ▒▒    ▒▒ ");
            Console.SetCursorPosition(startX, startY + 7);  // 5
            Console.Write("           █████▒▒  ████▒▒ ██▒ █▒▒██▒  ██    ██  ");
            Console.SetCursorPosition(startX, startY + 8);  // 6
            Console.Write("            ▒▒▒▒▒    ▒▒▒▒   ▒▒  ▒  ▒▒   ▒▒    ▒▒ ");

        }
        public static void DrawTinyBum(int startX, int startY)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            
            Console.SetCursorPosition(startX, startY + 1);  // 1
            Console.Write("            ▒ ▒                                    ");
            Console.SetCursorPosition(startX, startY + 2);  // 2
            Console.Write("          ░█████░        ▒███▒             ▒█████▒ ");
            Console.SetCursorPosition(startX, startY + 3);  // 3
            Console.Write("         ░▓ ▒ ▒ ▓░     ▒███▒              ▒█    ██▒");
            Console.SetCursorPosition(startX, startY + 4);  // 4
            Console.Write("         ░▓ ▒ ▒      ▒███▒      ▒██████▒  ▒█   █ █▒");
            Console.SetCursorPosition(startX, startY + 5);  // 5
            Console.Write("          ▓█▒█▒█▓   ▒██▒                  ▒█  █  █▒");
            Console.SetCursorPosition(startX, startY + 6);  // 6
            Console.Write("            ▒ ▒ ▓░   ▒███▒      ▒██████▒  ▒█ █   █▒");
            Console.SetCursorPosition(startX, startY + 7);  // 6
            Console.Write("         ░▓ ▒ ▒ ▓░     ▒███▒              ▒██    █▒");
            Console.SetCursorPosition(startX, startY + 8);  // 6
            Console.Write("          ░█████░        ▒███▒             ▒█████▒ ");
            Console.SetCursorPosition(startX, startY + 9);  // 6
            Console.Write("            ▒ ▒                                    ");
        }
        public static void DrawSinCity(int cityTopStartCentered)
        {
            int posCenteredStartLeft = (Console.WindowWidth / 2) - 44;
            // 87 chars wide, 6 chars high (center - 44)
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(posCenteredStartLeft, cityTopStartCentered  -7);
            Console.Write("░░░   ▒▒▒▒       ▒▒▒▒ ░░░░     ▒▒▒▒  ▒▒▒▒    ░░░   ▓▓▓▓   ░░░░░  ▒▒▒▒      ▓▓▓▓      ░░░");

            Console.SetCursorPosition(posCenteredStartLeft, cityTopStartCentered  -6);
            Console.Write("░▒▒▒▒ ▒▓▒███ ░░██▒▓▒▓▓ ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("▓▓▓▓▓ ▓▓ ▓▓  ▓▓ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("  ▓▓▓▓ ▓▓ ▓▓▓▓▓▓ ▓▓");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" ░░ ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("▓▓");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" ▒▓▓▓░░░░ █▓█▓  ▒▒███░░");

            Console.SetCursorPosition(posCenteredStartLeft, cityTopStartCentered  -5);
            Console.Write("▓▓▓▒▓ ▒▒▒█▓█▓▓░██▒▒▓▓█ ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("██    ██ ███ ██ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░ ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("██    ██   ██");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  ░ ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("██  ██ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░▒▓█▓▒░▒▒▒▓▓▓▓░░▒▓█▓█░░");

            Console.SetCursorPosition(posCenteredStartLeft, cityTopStartCentered  -4);
            Console.Write("▓█▓▒███▓▒███▓█▒███▒▓█▓  ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("▓▓▓  ▓▓ ▓▓▓▓▓▓ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░ ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("▓▓ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░░ ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("▓▓ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░ ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("▓▓ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░▓░ ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("▓▓▓▓ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░▒▒▓▓▓░░▒███▓█▓▒░▒▒███░░");

            Console.SetCursorPosition(posCenteredStartLeft, cityTopStartCentered -3);
            Console.Write("▓▓▓▒█▓█▒▒█▓█▓▓▒███▒▓▓█░   ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("▒▒ ▒▒ ▒▒ ▒▒▒ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░ ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("▒▒    ▒▒ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░ ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("▒▒ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░▓▓░ ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("▒▒ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░░▒▒▓█▓▒░▒█▓█▓▓▓░░▒▓█▓█░░");

            Console.SetCursorPosition(posCenteredStartLeft, cityTopStartCentered - 2);
            Console.Write("▓▓▓▒███▒▒███▓▓▒███▒▓▓█ ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("░░░░░ ░░ ░░  ░░ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░░ ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("░░░░ ░░ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░ ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("░░ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░▓▓░ ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("░░ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░░▒▒▓▓▓░░▒███▓▓▓░░▒▒███░░");
        }

        public static void CityFrame(int cityWidth, int cityHeight, int cityLeft, int cityTop)
        {
            // Topsection
            Console.SetCursorPosition(cityLeft - 1, cityTop - 1);
            Console.Write("╔");
            for (int i = 0; i < cityWidth; i++)
            {
                Console.SetCursorPosition(i + cityLeft, cityTop - 1);
                Console.Write("═");
            }
            Console.SetCursorPosition(cityLeft + cityWidth, cityTop - 1);
            Console.Write("╗");

            // Midsection
            for (int i = 0; i < cityHeight; i++)
            {
                Console.SetCursorPosition(cityLeft - 1, cityTop + i);
                Console.Write("║");
                Console.SetCursorPosition(cityLeft + cityWidth, cityTop + i);
                Console.Write("║");
            }

            // Basesection
            Console.SetCursorPosition(cityLeft - 1, cityTop + cityHeight);
            Console.Write("╚");
            for (int i = 0; i < cityWidth; i++)
            {
                Console.SetCursorPosition(i + cityLeft, cityTop + cityHeight);
                Console.Write("═");
            }
            Console.SetCursorPosition(cityLeft + cityWidth, cityTop + cityHeight);
            Console.Write("╝");

            //Console.WriteLine("╔ ═ ╗");
            //Console.WriteLine("║   ║");
            //Console.WriteLine("╚ ═ ╝");
        }
        public static void LocalPeeps()
        {
            int peepsListX = 15;
            Console.SetCursorPosition(peepsListX, 1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Citizen: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("☻");
            Console.SetCursorPosition(peepsListX, 2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Police: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("☻");
            Console.SetCursorPosition(peepsListX, 3);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Thief: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("☻");
            Console.ForegroundColor = ConsoleColor.White;

        }
        //public static void SplashScreen(int posX, int posY)
        //{
        //    Console.SetWindowSize(140, 45);
        //    Console.SetBufferSize(140, 45);
        //    Console.CursorVisible = false;
        //    Console.ReadKey();
        //    Console.Clear();
        //    Splash.Welcome(17, 2, 250, 8);
        //    Thread.Sleep(300);
        //    Splash.SinCityBWSunset(posX, posY);
        //    Thread.Sleep(200);
        //    Splash.Welcome(17, 2, 80, 3);
        //    Thread.Sleep(1000);
        //    Splash.SinCitySunSet(posX, posY);
        //    Splash.SinCityBackdrop(posX, posY);
        //    Thread.Sleep(1000);
        //    Splash.SinCityLogo(posX - 4, posY + 1, 0, 0);
        //    Splash.SinCityLogo(posX - 3, posY , 0, 0);
        //    Splash.SinCityLogo(posX - 5, posY, 50, 4);
        //    Thread.Sleep(100);
        //    Splash.SinCitySunSetWater(posX, posY + 20, 10);

        //    Thread.Sleep(3000);
        //    Console.Clear();
        //}
    }
}
