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
        public static void DrawBusted()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ ▓▓▓▓████▓▓▓▓███▓▓▓▓████▓▓▓▓████▓▓▓▓██▓▓                                                ║");
            Console.WriteLine("║ ██    ░▒░   ░▒░   ░▒░   ░▒░   ░▒░    ██                                                ║");
            Console.WriteLine("║ ▓▓    ▒▓▒   ▒▓▒   ▒▓▒   ▒▓▒   ▒▓▒    ▓▓                                                ║");
            Console.WriteLine("║ ██    ▒▓▒   ▒▓▒   ▒▓▒   ▒▓▒   ▒▓▒    ██  █████  ██  ██ █████ ██████ ████ █████    ███  ║");

            Console.Write("║ ▓▓    ▒▓▒");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" ░▓███▓▒ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("▒▓▒ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▒▓███▓░ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("▒▓▒    ▓▓  ██░░██ ██░ ██░██░░░░  ██░░░██░░░██░░██   ███░ ║");


            Console.Write("║ ██    ▒▓░");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░▓▓░▒░   ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("▒▓▒   ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░▒░▓▓░");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("░▓▒    ██  █████░░██░ ██░ ███    ██░  ███  ██░  █░   █░░ ║");


            Console.Write("║ ▓▓    ▒▓░");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░▓▓███▓▒ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("▒▓▒ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▒▓███▓▓░");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("░▓▒    ▓▓  ██░░██ ██░ ██░   ██   ██░  ██░░ ██░ ██░    ░  ║");


            Console.Write("║ ██    ▒▓░");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░▓▓░▒░   ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("▒▓▒   ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("░▒░▓▓░");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("░▓▒    ██  █████░░ ████░░████░░  ██░  ████ █████░░   █   ║");


            Console.Write("║ ▓▓    ▒▓░");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" ░▓███▓▒ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("▒▓▒ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▒▓███▓░ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("░▓▒    ▓▓   ░░░░░   ░░░░  ░░░░    ░░   ░░░░ ░░░░░     ░  ║");


            Console.WriteLine("║ ██    ▒▓░   ░▒░   ▒▓▒   ░▒░   ░▓▒    ██                                                ║");
            Console.WriteLine("║ ▓▓▓▓████▓▓▓▓███▓▓▓▓████▓▓▓▓████▓▓▓▓██▓▓                                                ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public static void DrawRobbery()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║      ░░░░░░░░░░                                                                        ║");
            Console.WriteLine("║    ░░░░░░░░░░░░░                                                                       ║");
            Console.WriteLine("║   ░░░░░░░░░░░░░░░                                                                      ║");
            Console.WriteLine("║  ░░░░▒▒▒▒▒▒▒▒▒▒░░              █▓    ████   ███  ████  ████  █████ ████  █   █ █ █ █   ║");
            Console.WriteLine("║  ░░░                         █▓▒░    █░░░█ █ ░░█ █ ░░█ █ ░░█ █░░░░░█░░░█  █ █ ░█░█░█░  ║");
            Console.Write("║  ░         ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▒█▓");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   ░          █▓▒░     ████ ░█░  █░████ ░█████░███   ████ ░  █ ░ █░█░█░  ║");
            Console.WriteLine("║  ░░░▒▒          ▒▒░        █▓▒░      █░░░█ █░  █░█ ░░█ █ ░░█ █░░░  █░░░█   █░   ░ ░ ░  ║");
            Console.WriteLine("║   ░░▒▒▒▒░░░░░░░░░░░░      █▓▒░       █░  █░ ███ ░████ ░████ ░█████ █░  █░  █░  █ █ █   ║");
            Console.Write("║   ░░░▒▒░");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▓▒▓▒▓▒▓▒▓");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("       ██▓▒░▒▒       ░   ░  ░░░  ░░░░  ░░░░  ░░░░░ ░   ░   ░   ░ ░ ░  ║");
            Console.Write("║   ░░ ░▒▒░");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▓▒▓▒▓");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("░░░      ▓▒▒░░░▒░▒▒                                                      ║");
            Console.WriteLine("║   ░  ░▒▒▒░░░░▒░         ▒▒▒▒░░░▒░░                                                     ║");
            Console.WriteLine("║     ░▒▒▒▒▒▒▒░             ▒▒▒▒░░░                                                      ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
