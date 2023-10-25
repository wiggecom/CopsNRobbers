using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopsNRobbers
{
    internal class Gfx
    {
        public static void DrawBustedSingleCol()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ ▓▓▓▓████▓▓▓▓███▓▓▓▓████▓▓▓▓████▓▓▓▓██▓▓                                                ║");
            Console.WriteLine("║ ██    ░▒░   ░▒░   ░▒░   ░▒░   ░▒░    ██                                                ║");
            Console.WriteLine("║ ▓▓    ▒▓▒   ▒▓▒   ▒▓▒   ▒▓▒   ▒▓▒    ▓▓                                                ║");
            Console.WriteLine("║ ██    ▒▓▒   ▒▓▒   ▒▓▒   ▒▓▒   ▒▓▒    ██  █████  ██  ██ █████ ██████ ████ █████    ███  ║");
            Console.WriteLine("║ ▓▓    ▒▓▒░▓▓███▓▒ ▒▓▒ ▒▓███▓▓░▒▓▒    ▓▓  ██░░██ ██░ ██░██░░░░  ██░░░██░░░██░░██   ███░ ║");
            Console.WriteLine("║ ██    ▒▓░▓▓▓░▒░   ▒▓▒   ░▒░▓▓▓░▓▒    ██  █████░░██░ ██░ ███    ██░  ███  ██░  █░   █░░ ║");
            Console.WriteLine("║ ▓▓    ▒▓░▓▓▓███▓▒ ▒▓▒ ▒▓███▓▓▓░▓▒    ▓▓  ██░░██ ██░ ██░   ██   ██░  ██░░ ██░ ██░    ░  ║");
            Console.WriteLine("║ ██    ▒▓░▓▓▓░▒░   ▒▓▒   ░▒░▓▓▓░▓▒    ██  █████░░ ████░░████░░  ██░  ████ █████░░   █   ║");
            Console.WriteLine("║ ▓▓    ▒▓░░▓▓███▓▒ ▒▓▒ ▒▓███▓▓░░▓▒    ▓▓   ░░░░░   ░░░░  ░░░░    ░░   ░░░░ ░░░░░     ░  ║");
            Console.WriteLine("║ ██    ▒▓░   ░▒░   ▒▓▒   ░▒░   ░▓▒    ██                                                ║");
            Console.WriteLine("║ ▓▓▓▓████▓▓▓▓███▓▓▓▓████▓▓▓▓████▓▓▓▓██▓▓                                                ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void DrawRobberySingleCol()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║      ░░░░░░░░░░                                                                        ║");
            Console.WriteLine("║    ░░░░░░░░░░░░░                                                                       ║");
            Console.WriteLine("║   ░░░░░░░░░░░░░░░                                                                      ║");
            Console.WriteLine("║  ░░░░▒▒▒▒▒▒▒▒▒▒░░              █▓    ████   ███  ████  ████  █████ ████  █   █ █ █ █   ║");
            Console.WriteLine("║  ░░░                         █▓▒░    █░░░█ █ ░░█ █ ░░█ █ ░░█ █░░░░░█░░░█  █ █ ░█░█░█░  ║");
            Console.WriteLine("║  ░         ▒█▓   ░          █▓▒░     ████ ░█░  █░████ ░█████░███   ████ ░  █ ░ █░█░█░  ║");
            Console.WriteLine("║  ░░░▒▒          ▒▒░        █▓▒░      █░░░█ █░  █░█ ░░█ █ ░░█ █░░░  █░░░█   █░   ░ ░ ░  ║");
            Console.WriteLine("║   ░░▒▒▒▒░░░░░░░░░░░░      █▓▒░       █░  █░ ███ ░████ ░████ ░█████ █░  █░  █░  █ █ █   ║");
            Console.WriteLine("║   ░░░▒▒░▓▒▓▒▓▒▓▒▓       ██▓▒░▒▒       ░   ░  ░░░  ░░░░  ░░░░  ░░░░░ ░   ░   ░   ░ ░ ░  ║");
            Console.WriteLine("║   ░░ ░▒▒░▓▒▓▒▓░░░      ▓▒▒░░░▒░▒▒                                                      ║");
            Console.WriteLine("║   ░  ░▒▒▒░░░░▒░         ▒▒▒▒░░░▒░░                                                     ║");
            Console.WriteLine("║     ░▒▒▒▒▒▒▒░             ▒▒▒▒░░░                                                      ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void DrawSinCitySingleCol()
        {
            // 88 chars wide, 6 chars high
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("░░░   ▒▒▒▒       ▒▒▒▒ ░░░░     ▒▒▒▒  ▒▒▒▒    ░░░   ▓▓▓▓   ░░░░░  ▒▒▒▒      ▓▓▓▓      ░░░");
            Console.WriteLine("░▒▒▒▒ ▒▓▒███ ░░██▒▓▒▓▓ ▓▓▓▓▓ ▓▓ ▓▓  ▓▓ ░  ▓▓▓▓ ▓▓ ▓▓▓▓▓▓ ▓▓ ░░ ▓▓ ▒▓▓▓░░░░ █▓█▓  ▒▒███░░");
            Console.WriteLine("▓▓▓▒▓ ▒▒▒█▓█▓▓░██▒▒▓▓█ ██    ██ ███ ██ ░ ██    ██   ██  ░ ██  ██ ░▒▓█▓▒░▒▒▒▓▓▓▓░░▒▓█▓█░░");
            Console.WriteLine("▓█▓▒███▓▒███▓█▒███▒▓█▓  ▓▓▓  ▓▓ ▓▓▓▓▓▓ ░ ▓▓ ░░ ▓▓ ░ ▓▓ ░▓░ ▓▓▓▓ ░▒▒▓▓▓░░▒███▓█▓▒░▒▒███░░");
            Console.WriteLine("▓▓▓▒█▓█▒▒█▓█▓▓▒███▒▓▓█░   ▒▒ ▒▒ ▒▒ ▒▒▒ ░ ▒▒    ▒▒ ░ ▒▒ ░▓▓░ ▒▒ ░░▒▒▓█▓▒░▒█▓█▓▓▓░░▒▓█▓█░░");
            Console.WriteLine("▓▓▓▒███▒▒███▓▓▒███▒▓▓█ ░░░░░ ░░ ░░  ░░ ░░ ░░░░ ░░ ░ ░░ ░▓▓░ ░░ ░░▒▒▓▓▓░░▒███▓▓▓░░▒▒███░░");
        }
        //public static void DrawSinCity(int posLeft, int posTop)
        public static void DrawSinCity(int cityTopStartCentered)
        {
            int posCenteredStartLeft = (Console.WindowWidth / 2) - 44;
            // 87 chars wide, 6 chars high (center - 44)
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(posCenteredStartLeft, cityTopStartCentered + -7);
            Console.Write("░░░   ▒▒▒▒       ▒▒▒▒ ░░░░     ▒▒▒▒  ▒▒▒▒    ░░░   ▓▓▓▓   ░░░░░  ▒▒▒▒      ▓▓▓▓      ░░░");

            Console.SetCursorPosition(posCenteredStartLeft, cityTopStartCentered - 6);
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

            Console.SetCursorPosition(posCenteredStartLeft, cityTopStartCentered -5);
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

            Console.SetCursorPosition(posCenteredStartLeft, cityTopStartCentered -4);
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

        public static void DrawBusted()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.Write("║ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("▓▓▓▓████▓▓▓▓███▓▓▓▓████▓▓▓▓████▓▓▓▓██▓▓");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                ║");
            Console.Write("║ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    ░▒░   ░▒░   ░▒░   ░▒░   ░▒░    ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                ║");
            Console.Write("║ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("▓▓");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    ▒▓▒   ▒▓▒   ▒▓▒   ▒▓▒   ▒▓▒    ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("▓▓");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                ║");
            Console.Write("║ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    ▒▓▒   ▒▓▒   ▒▓▒   ▒▓▒   ▒▓▒    ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  █████  ██  ██ █████ ██████ ████ █████    ███  ║");
            Console.Write("║ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("▓▓");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  ██░░██ ██░ ██░██░░░░  ██░░░██░░░██░░██   ███░ ║");
            Console.Write("║ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  █████░░██░ ██░ ███    ██░  ███  ██░  █░   █░░ ║");
            Console.Write("║ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("▓▓");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  ██░░██ ██░ ██░   ██   ██░  ██░░ ██░ ██░    ░  ║");
            Console.Write("║ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  █████░░ ████░░████░░  ██░  ████ █████░░   █   ║");
            Console.Write("║ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("▓▓");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   ░░░░░   ░░░░  ░░░░    ░░   ░░░░ ░░░░░     ░  ║");
            Console.Write("║ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    ▒▓░   ░▒░   ▒▓▒   ░▒░   ░▓▒    ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                ║");
            Console.Write("║ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("▓▓▓▓████▓▓▓▓███▓▓▓▓████▓▓▓▓████▓▓▓▓██▓▓");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void DrawRobbery()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║      ░░░░░░░░░░                                                                        ║");
            Console.WriteLine("║    ░░░░░░░░░░░░░                                                                       ║");
            Console.WriteLine("║   ░░░░░░░░░░░░░░░                                                                      ║");
            Console.Write("║  ░░░░▒▒▒▒▒▒▒▒▒▒░░             ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█▓");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("     ████   ███  ████  ████  █████ ████  █   █ █ █ █   ║");
            Console.Write("║  ░░░                         ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█▓▒░");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("    █░░░█ █ ░░█ █ ░░█ █ ░░█ █░░░░░█░░░█  █ █ ░█░█░█░  ║");
            Console.Write("║  ░         ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▒█▓");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("   ░          ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█▓▒░");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("     ████ ░█░  █░████ ░█████░███   ████ ░  █ ░ █░█░█░  ║");
            Console.Write("║  ░░░▒▒          ▒▒░        ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█▓▒░");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("      █░░░█ █░  █░█ ░░█ █ ░░█ █░░░  █░░░█   █░   ░ ░ ░  ║");
            Console.Write("║   ░░▒▒▒▒░░░░░░░░░░░░      ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("█▓▒░");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("       █░  █░ ███ ░████ ░████ ░█████ █░  █░  █░  █ █ █   ║");
            Console.Write("║   ░░░▒▒░");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▓▒▓▒▓▒▓▒▓");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("       ██▓▒░");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("▒▒       ░   ░  ░░░  ░░░░  ░░░░  ░░░░░ ░   ░   ░   ░ ░ ░  ║");
            Console.Write("║   ░░ ░▒▒░");
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
            Console.WriteLine("▒░▒▒                                                      ║");
            Console.Write("║   ░  ░▒▒▒░░░░▒░         ▒▒▒▒");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("░░░");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("▒░░                                                     ║");
            Console.Write("║     ░▒▒▒▒▒▒▒░             ▒▒▒▒");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("░░░");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                                      ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
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
            Console.SetCursorPosition(1, 1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Citizen: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("☻");
            Console.SetCursorPosition(1, 2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Police: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("☻");
            Console.SetCursorPosition(1, 3);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Thief: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("☻");
            Console.ForegroundColor = ConsoleColor.White;

        }

        // ☺ ☻ ♥ ♦ ♣ ♠ • ◘ ○ ◙ ♂ ♀ ♪ ♫ ☼ ► ◄ ↕ ‼ ¶ § ▬ ↨ ↑ ↓
        // → ← ∟ ↔ ▲ ▼ ^ ` ⌂ Ü ü º¿¡ ⌐ ¬ ª ® © « » ░ ▒ ▓ █ ▄ ▌▐ ▀
        // │ ┤ ╡ ╢ ╖ ╕ ╣ ║ ╗ ╝ ╜ ╛ ┐ └ ┴ ├ ├ ─ ┼ ╞
        //  ╟ ╚ ╔ ╩ ╦ ╠ ═ ╬ ╧ ╨ ╤ ╥ ╙ ╘ ╒ ╓ ╫ ╪ ┘ ┌
        // - _ / | \
        //
        // DrawHotkeysFrame


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
        /*
          
Console.WriteLine("░░░   ▒▒▒▒       ▒▒▒▒ ░░░░     ▒▒▒▒  ▒▒▒▒    ░░░   ▓▓▓▓   ░░░░░  ▒▒▒▒      ▓▓▓▓      ░░");
Console.WriteLine("░▒▒▒▒ ▒▓▒███ ░░██▒▓▒▓▓ ▓▓▓▓▓ ▓▓ ▓▓  ▓▓ ░  ▓▓▓▓ ▓▓ ▓▓▓▓▓▓ ▓▓ ░░ ▓▓ ▒▓▓▓░░░░ █▓█▓  ▒▒███░");
Console.WriteLine("▓▓▓▒▓ ▒▒▒█▓█▓▓░██▒▒▓▓█ ██    ██ ███ ██ ░ ██    ██   ██  ░ ██  ██ ░▒▓█▓▒░▒▒▒▓▓▓▓░░▒▓█▓█░");
Console.WriteLine("▓█▓▒███▓▒███▓█▒███▒▓█▓  ▓▓▓  ▓▓ ▓▓▓▓▓▓ ░ ▓▓ ░░ ▓▓ ░ ▓▓ ░▓░ ▓▓▓▓ ░▒▒▓▓▓░░▒███▓█▓▒░▒▒███░");
Console.WriteLine("▓▓▓▒█▓█▒▒█▓█▓▓▒███▒▓▓█░   ▒▒ ▒▒ ▒▒ ▒▒▒ ░ ▒▒    ▒▒ ░ ▒▒ ░▓▓░ ▒▒ ░░▒▒▓█▓▒░▒█▓█▓▓▓░░▒▓█▓█░");
Console.WriteLine("▓▓▓▒███▒▒███▓▓▒███▒▓▓█ ░░░░░ ░░ ░░  ░░ ░░ ░░░░ ░░ ░ ░░ ░▓▓░ ░░ ░░▒▒▓▓▓░░▒███▓▓▓░░▒▒███░");



         */
    }
}
