using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopsNRobbers
{
    public class Splash
    {
        public static int SelectMap()
        {
            int mapSelect = 0;
            int centeredWidth = Console.WindowWidth / 2;
            int posX = centeredWidth-48;
            int ceneteredHeight = Console.WindowHeight / 2;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(posX, ceneteredHeight-6);

            Console.WriteLine("██████████████████████████████  ██████████████████████████████  ██████████████████████████████");

            Console.SetCursorPosition(posX, ceneteredHeight - 5);
            Console.WriteLine("██░░░░░░░░░░░░░░░░░░░░░░░░░░██  ██░░░░░░░░░░░░░░░░░░░░░░░░░░██  ██░░░░░░░░░░░░░░░░░░░░░░░░░░██");
            Console.SetCursorPosition(posX, ceneteredHeight - 4);
            Console.WriteLine("██░░░░░░░░░░░░░░░░░░░░░░░░░░██  ██░░░░░░░░░░░░░█████░░░░░░░░██  ██░░██░░██░░░░░░░░░░██░░██░░██");
            Console.SetCursorPosition(posX, ceneteredHeight - 3);
            Console.WriteLine("██░░░░░░░░░░░░░░░░░░░░░░░░░░██  ██░░░░█░░░░░░░░░░░░░░░░░░░░░██  ██░░░░░░░░░░░░░░░░░░░░░░░░░░██");
            Console.SetCursorPosition(posX, ceneteredHeight - 2);
            Console.WriteLine("██░░░░░░░░░░░░░░░░░░░░░░░░░░██  ██░░░░█░░░░░░░░░░░░░░░░█░░░░██  ██░░██░░░░░░░░░░░░░░░░░░██░░██");
            Console.SetCursorPosition(posX, ceneteredHeight - 1);
            Console.WriteLine("██░░░░░░░░░░░░░░░░░░░░░░░░░░██  ██░░░░░░░░░░░░░░░░░░░░░█░░░░██  ██░░░░░░░░░░░░░░░░░░░░░░░░░░██");
            Console.SetCursorPosition(posX, ceneteredHeight);
            Console.WriteLine("██░░░░░░░░░░░░░░░░░░░░░░░░░░██  ██░░░░░░░░██████░░░░░░░░░░░░██  ██░░██░░██░░░░░░░░░░██░░██░░██");
            Console.SetCursorPosition(posX, ceneteredHeight+1);
            Console.WriteLine("██░░░░░░░░░░░░░░░░░░░░░░░░░░██  ██░░░░░░░░░░░░░░░░░░░░░░░░░░██  ██░░░░░░░░░░░░░░░░░░░░░░░░░░██");
            Console.SetCursorPosition(posX, ceneteredHeight +2);
            Console.WriteLine("██████████████████████████████  ██████████████████████████████  ██████████████████████████████");
            Console.SetCursorPosition(posX, ceneteredHeight + 3);
            Console.WriteLine();
            Console.SetCursorPosition(posX, ceneteredHeight + 4);
            Console.WriteLine("                                      Please select map");
            Console.SetCursorPosition(posX, ceneteredHeight + 5);
            Console.WriteLine();
            Console.SetCursorPosition(posX, ceneteredHeight + 6);
            Console.WriteLine("              1                                2                               3              ");

            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    mapSelect = 1;
                    break;
                case ConsoleKey.D2:
                    mapSelect = 2;
                    break;
                case ConsoleKey.D3:
                    mapSelect = 3;
                    break;
                default:
                    break;
            }
            Console.Clear();
            return mapSelect;
        }
        public static void SinCitySunSet(int posX, int posY)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            //           1         2         3         4 
            // 012345678901234567890123456789012345678901
            Console.SetCursorPosition(posX + 42, posY);
            Console.Write("████████████"); // 0
            Console.SetCursorPosition(posX + 33, posY + 1);
            Console.Write("████▓██████▓████████▓█████████"); // 1
            Console.SetCursorPosition(posX + 25, posY + 2);
            Console.Write("████████████████▓███████▓████████▓████████████"); // 2
            Console.SetCursorPosition(posX + 19, posY + 3);
            Console.Write("████▓████▓██▓███▓██▓▓▓█▓▒▓▓▓▓█▓▓▓▓█▓▓▓████████▓███▓███████"); // 3
            Console.SetCursorPosition(posX + 14, posY + 4);
            Console.Write("████████████▓███▓▓▓▓▓█▓▓▓▒▓▓▓▓▓▓▓▒▓▓▓▓▒▓▓▓▓▓▒▓▓▓█▓▓▓▓████▓██▓██████"); // 4
            Console.SetCursorPosition(posX + 12, posY + 5);
            Console.Write("█████████▓██▓▓█▓▓▒▓▓▒▓▓▓▓▒▓▓▒▒▒▒▒▓▒▒▒▒▒▒▓▒▒▒▒▓▓▓▒▓▓▓▓▒▓▓▓█▓█▓█████▓█████"); // 5
            Console.SetCursorPosition(posX + 10, posY + 6);
            Console.Write("███████▓██▓█▓▓▓▓▓▒▓▓▓▓▒▒▒▓▒▒▒▒▓▒▒░▒▒▒▓▒▒░▒▒▒░▒▓▒▒▒▓▒▒▒▒▓▓▓▒▓▓▓▒▓▓▓▓███▓█████"); // 6
            Console.SetCursorPosition(posX + 8, posY + 7);
            Console.Write("██████▓██▓▓▒▓▓▓▒▓▓▒▓▒▒▒▒▓▒▒▒▒░▒▒▒░▒▒░░▒░░░▒░░░▒▒▒░▒▒▒░▒▓▒▒▒▒▓▒▒▓▓▓▒▓█▓▓▓████████"); // 7
            Console.SetCursorPosition(posX + 6, posY + 8);
            Console.Write("█████▓███▓▓█▓▓▓▓▒▒▒▒▒▒▒▒░▒▒░▒░░░▒░░▒▒░░░░▒▒░░░▒░▒░░▒░▒░░▒▒░▒▒▒░▓▒▒▒▒▒▓▓▒▓▓▓▓██▓█████"); // 8
            Console.SetCursorPosition(posX + 4, posY + 9);
            Console.Write("█████████▓▓▓▓▒▓▒▒▓▒▒▒▓▒░▒░░░▒▒░░▒░░▒░░░░░░░░░░░░░░░░▒░░░░░░▒░░░░▒▒▒▒░▒░▓▒▒▓▓█▓▓▓███▓████"); // 9

            Console.SetCursorPosition(posX + 3, posY + 10);
            Console.Write("██████▓█▓█▓▒▓▓▒▒▒▒░▒▒░▒▒░░░▒▒░░░▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒░░░▒░░▒▒▒▒▒▒▒▒▓▒▓█▓▓███████"); // 0
            Console.SetCursorPosition(posX + 2, posY + 11);
            Console.Write("████████▓▓▓▓▓▒▒▓▒▒▒▒░░▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒░▒░▒▒░▓▒▒▒▓▓▓▓▓██▓████"); // 1
            Console.SetCursorPosition(posX + 1, posY + 12);
            Console.Write("█████▓██▓▓▒▓▓▒▓▒▒░▒░░▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒░░▒▒▒▒▒▒▓▒▓█▓███████"); // 2
            Console.SetCursorPosition(posX, posY + 13);
            Console.Write("████████▓█▓▓▓▒▓▒▒▒▒░▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒░▒▒░▒▓▒▓▓▓▓▓█▓█████"); // 3
            Console.SetCursorPosition(posX, posY + 14);
            Console.Write("███████▓▓▓▓▒▓▒▒▒░▒░▒░▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒░░░▒▒▒▒▒▓▒▓█▓███████"); // 4

        }
        public static void SinCitySunSetWater(int posX, int posY, int sleep)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;

            Thread.Sleep(sleep);
            Console.SetCursorPosition(posX, posY);
            Console.Write("                  █░            ░▒█░▒        ░▒█▒              █           ▒█    ░"); // 0

            Thread.Sleep(sleep);
            Console.SetCursorPosition(posX, posY + 1);
            Console.Write("                 ░▒█▒▒         ░ █▒▒░░      ▒ ▒░           ░▓▒░ ▒░           ▓ "); // 1

            Thread.Sleep(sleep);
            Console.SetCursorPosition(posX, posY + 2);
            Console.Write("     ░         ▓                ▒ ▒▒ ▒          ▓             ▓   ▒▒      ▒█  ░ ░   "); // 2

            Thread.Sleep(sleep);
            Console.SetCursorPosition(posX, posY + 3);
            Console.Write("             ▒ ▒ ▒░▓░▒░░       ░ ░ ░       ▒▒░▓▒▓▒░          ░▓▒░▒▓      ░ ░▓  ░        ▒ "); // 3

            Thread.Sleep(sleep);
            Console.SetCursorPosition(posX, posY + 4);
            Console.Write("              ▒▓█░      ░▒▓░░ ░    ▓░ ░   ▒█ ░    ▓     ░▓▒░               ▓                     "); // 4

            Thread.Sleep(sleep);
            Console.SetCursorPosition(posX, posY + 5);
            Console.Write("  ░      ░░   ▓    ░▒ ░        █ ▒▒░          ▒█░▒ ░░          ▒  ░▓░ ░    ▒  ▓   ░░░            "); // 5

            Thread.Sleep(sleep);
            Console.SetCursorPosition(posX, posY + 6);
            Console.Write("      ░░    ░░░█   ▓               █▓               ▒ ▒     ▓   ██               █    ░          "); // 6

            Thread.Sleep(sleep);
            Console.SetCursorPosition(posX, posY + 7);
            Console.Write("        ░        █    ░░░      ▓        ░▒░    ░█▒▒  ░   ▒▒▒░░██ ▒░ █      ░░▒▒░ █         ░░    "); // 7

            Thread.Sleep(sleep);
            Console.SetCursorPosition(posX, posY + 8);
            Console.Write("     ░       █           █       ██▓          ██                █    █  █      █       ░░        "); // 8

            Thread.Sleep(sleep);
            Console.SetCursorPosition(posX, posY + 9);
            Console.Write("        ░         █     █       ░░░  ██      ░░░█     ███░░  ░░░ ░░░  ░░    ██     █      ░      "); // 9

            Thread.Sleep(sleep);
            Console.SetCursorPosition(posX, posY + 10);
            Console.Write("             ░             ░░            ░        ░░      ░░              ░           ░          "); // 9

        }
        public static void SinCityBackdrop(int posX, int posY)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(posX + 54, posY); Console.Write("░░░");    // 0  

            Console.SetCursorPosition(posX + 5, posY + 1); Console.Write("░░░░░░░░");
            Console.SetCursorPosition(posX + 38, posY + 1); Console.Write("░░░░");
            Console.SetCursorPosition(posX + 54, posY + 1); Console.Write("░░░");
            Console.SetCursorPosition(posX + 87, posY + 1); Console.WriteLine("░░░░░");// 1

            Console.SetCursorPosition(posX + 5, posY + 2); Console.Write("░▒░▒▒░▒░");
            Console.SetCursorPosition(posX + 38, posY + 2); Console.Write("░▒▒░");
            Console.SetCursorPosition(posX + 54, posY + 2); Console.Write("░░░");
            Console.SetCursorPosition(posX + 87, posY + 2); Console.WriteLine("░▒░▒░");        // 2


            Console.SetCursorPosition(posX + 5, posY + 3); Console.Write("░░░░░░░░");
            Console.SetCursorPosition(posX + 19, posY + 3); Console.Write("░░░░░░░░░░░");
            Console.SetCursorPosition(posX + 38, posY + 3); Console.Write("░░░░");
            Console.SetCursorPosition(posX + 53, posY + 3); Console.Write("░░░░░");
            Console.SetCursorPosition(posX + 87, posY + 3); Console.WriteLine("░░░░░"); // 3


            Console.SetCursorPosition(posX + 5, posY + 4); Console.Write("░▒░▒▒░░░");
            Console.SetCursorPosition(posX + 19, posY + 4); Console.Write("░▒▒░░▒▒▒▒▒▒▒▒");
            Console.SetCursorPosition(posX + 36, posY + 4); Console.Write("░░");
            Console.SetCursorPosition(posX + 38, posY + 4); Console.Write("░▒▒░");
            Console.SetCursorPosition(posX + 53, posY + 4); Console.Write("░▒░▒░");
            Console.SetCursorPosition(posX + 87, posY + 4); Console.WriteLine("░░░▒░");        // 4     


            Console.SetCursorPosition(posX + 5, posY + 5); Console.Write("░░░░░░░░");
            Console.SetCursorPosition(posX + 19, posY + 5); Console.Write("░░░░░░▒▒▒▒▒▒▒");
            Console.SetCursorPosition(posX + 35, posY + 5); Console.Write("░░░░░░░░");
            Console.SetCursorPosition(posX + 53, posY + 5); Console.Write("░░░░░");
            Console.SetCursorPosition(posX + 79, posY + 5); Console.WriteLine("▒▒▒▒▒▒▒▒▒░░░░");        // 5     


            Console.SetCursorPosition(posX + 5, posY + 6); Console.Write("░▒░░░▒▒▒▒▒▒▒");
            Console.SetCursorPosition(posX + 19, posY + 6); Console.Write("░▒▒░░▒▒▓▓▒▓▓▒");
            Console.SetCursorPosition(posX + 35, posY + 6); Console.Write("░░▒░▒░▒░");
            Console.SetCursorPosition(posX + 53, posY + 6); Console.Write("░▒░░▒▒▒▒▒");
            Console.SetCursorPosition(posX + 67, posY + 6); Console.Write("▒▒▒▒▒▒");
            Console.SetCursorPosition(posX + 79, posY + 6); Console.WriteLine("▒▒▒▒▒▒▒▒▒░░░░░");       // 6     


            Console.SetCursorPosition(posX + 5, posY + 7); Console.Write("░░░░░▒▓▒▓▒▓▒");
            Console.SetCursorPosition(posX + 19, posY + 7); Console.Write("░░░░░░▒▒▒▒▒▒▒");
            Console.SetCursorPosition(posX + 35, posY + 7); Console.Write("░░░░▒▒▒▒▒▒▒");
            Console.SetCursorPosition(posX + 52, posY + 7); Console.Write("░░░░░▒▓▒▒▒");
            Console.SetCursorPosition(posX + 66, posY + 7); Console.Write("░▒█▒▒█▒░░░");
            Console.SetCursorPosition(posX + 79, posY + 7); Console.WriteLine("▒▓▓▓▒▓▓▓▒░░▒░░");  // 7 


            Console.SetCursorPosition(posX + 5, posY + 8); Console.Write("░▒░▒▒▒▒▒▒▒▒▒");
            Console.SetCursorPosition(posX + 19, posY + 8); Console.Write("░░░░░░░░░░▒▒▒");
            Console.SetCursorPosition(posX + 35, posY + 8); Console.Write("░░▒░▒▓▒▓▒▓▒");
            Console.SetCursorPosition(posX + 48, posY + 8); Console.Write("▒▒▒▒▒▒▒░░▒▒▒▒▒");
            Console.SetCursorPosition(posX + 66, posY + 8); Console.Write("░▒▒▒▒▒▒░░░");
            Console.SetCursorPosition(posX + 79, posY + 8); Console.Write("▒▒▒▒▒▒▒▒▒░░░░░░░");     // 8     


            Console.SetCursorPosition(posX, posY + 9); Console.Write("▒▒▒▒▒▒▒░░░▒▓▒▓▒▒▒");
            Console.SetCursorPosition(posX + 19, posY + 9); Console.Write("░░░░█░█░█░▒▓▒");
            Console.SetCursorPosition(posX + 35, posY + 9); Console.Write("░░░░▒▒▒▒▒▒▒");
            Console.SetCursorPosition(posX + 48, posY + 9); Console.Write("▒▒▒▒██▒░░▒▓▒▓▒");
            Console.SetCursorPosition(posX + 66, posY + 9); Console.Write("░▒▒▒▒█▒░░░");
            Console.SetCursorPosition(posX + 79, posY + 9); Console.Write("▒▓▒▓▒▓▒▓▒░▒▒▒▒░░");     // 9     


            Console.SetCursorPosition(posX, posY + 10); Console.Write("▒██▒▒▒▒░░░▒▒▒▒▒▒▒");
            Console.SetCursorPosition(posX + 19, posY + 10); Console.Write("░▒▒░░░░░░░▒▒▒");
            Console.SetCursorPosition(posX + 35, posY + 10); Console.Write("░▒▒░▒▒▒▒▒▓▒");
            Console.SetCursorPosition(posX + 48, posY + 10); Console.Write("▒▒▒▒▒▒▒░▒▒▒▒▒▒▒");
            Console.SetCursorPosition(posX + 66, posY + 10); Console.Write("░▒▒▒▒▒▒░░░");
            Console.SetCursorPosition(posX + 79, posY + 10); Console.Write("▒▒▒▒▒▒▒▒▒░▒▓▓▒░░"); // 0

            Console.SetCursorPosition(posX, posY + 11); Console.Write("▒▒▒▒█▒▒░░░▒▓▒▓▒▓▒");
            Console.SetCursorPosition(posX + 19, posY + 11); Console.Write("░░░░░░█░█░▒▒▒");
            Console.SetCursorPosition(posX + 35, posY + 11); Console.Write("░░░░▒▒▒▒▒▒▒");
            Console.SetCursorPosition(posX + 48, posY + 11); Console.Write("▒██▒██▒░▒▓▓▒▓▓▒");
            Console.SetCursorPosition(posX + 65, posY + 11); Console.Write("▒▒▒▒▒▒▒▒▒░░");
            Console.SetCursorPosition(posX + 79, posY + 11); Console.Write("▒▒▒▓▒▒▒▓▒░▒▒▒▒░░");     // 11

            Console.SetCursorPosition(posX, posY + 12); Console.Write("▒▒▒▒▒▒▒░▒▒▒▒▒▒▒▒▒");
            Console.SetCursorPosition(posX + 19, posY + 12); Console.Write("░░░░░░░░░░▒▓▒");
            Console.SetCursorPosition(posX + 35, posY + 12); Console.Write("░▒░░▒▒▒▓▒▓▒");
            Console.SetCursorPosition(posX + 48, posY + 12); Console.Write("▒▒▒▒▒▒▒░▒▒▒▒▒▒▒");
            Console.SetCursorPosition(posX + 65, posY + 12); Console.Write("▒▒██▒▒█▒▒░░");
            Console.SetCursorPosition(posX + 77, posY + 12); Console.Write("░░░░░░▒▒▒▒▒░▒▒▒▒▒▒▒"); // 12

            Console.SetCursorPosition(posX, posY + 13); Console.Write("▒██▒█▒▒░░░▒▒▒▓▒▒▒");
            Console.SetCursorPosition(posX + 19, posY + 13); Console.Write("░░░░█░█░░░▒▒▒");
            Console.SetCursorPosition(posX + 35, posY + 13); Console.Write("░░░░▒▒▒▒▒▒▒");
            Console.SetCursorPosition(posX + 48, posY + 13); Console.Write("▒██▒▒▒▒░▒▓▓▒▒▒▒");
            Console.SetCursorPosition(posX + 65, posY + 13); Console.Write("▒▒▒▒▒▒▒▒▒░░");
            Console.SetCursorPosition(posX + 77, posY + 13); Console.Write("░█░░░░▒▓▒▒▒░▒▓▒▓▒▓▒");    // 13

            Console.SetCursorPosition(posX, posY + 14); Console.Write("▒▒▒▒▒▒▒░▒▒▒▒▒▒▒▒▒");
            Console.SetCursorPosition(posX + 19, posY + 14); Console.Write("░▒▒░░░░░░░▒▒▒");
            Console.SetCursorPosition(posX + 35, posY + 14); Console.Write("░░▒░▒▓▒▓▒▒▒");
            Console.SetCursorPosition(posX + 48, posY + 14); Console.Write("▒▒▒▒▒▒▒░▒▒▒▒▒▒▒");
            Console.SetCursorPosition(posX + 65, posY + 14); Console.Write("▒▒██▒▒▒▒▒░░");
            Console.SetCursorPosition(posX + 77, posY + 14); Console.Write("░░░░░░▒▒▒▒▒░▒▒▒▒▒▒▒");    // 14

            Console.SetCursorPosition(posX, posY + 15); Console.Write("▒▒▒▒▒█▒░░░▒▓▒▒▒▒▒");
            Console.SetCursorPosition(posX + 19, posY + 15); Console.Write("░░░░░░█░░░▒▒▒▒");
            Console.SetCursorPosition(posX + 35, posY + 15); Console.Write("░░░░▒▒▒▒▒▒▒");
            Console.SetCursorPosition(posX + 48, posY + 15); Console.Write("▒██▒▒▒▒░▒▒▒▒▓▓▒");
            Console.SetCursorPosition(posX + 65, posY + 15); Console.Write("▒▒▒▒▒▒▒▒▒░░");
            Console.SetCursorPosition(posX + 77, posY + 15); Console.Write("░░░░█░▒▓▒▓▒░▒▒▒▒▒▓▒");    // 1

            Console.SetCursorPosition(posX, posY + 16); Console.Write("▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒");
            Console.SetCursorPosition(posX + 19, posY + 16); Console.Write("░░░░░░░░░░▒▒▒▒");
            Console.SetCursorPosition(posX + 35, posY + 16); Console.Write("░▒░▒▒▒▒▓▒▒▒");
            Console.SetCursorPosition(posX + 48, posY + 16); Console.Write("▒▒▒▒▒▒▒░▒▒▒▒▒▒▒");
            Console.SetCursorPosition(posX + 65, posY + 16); Console.Write("▒▒▒▒▒▒█▒▒░░");
            Console.SetCursorPosition(posX + 77, posY + 16); Console.Write("░░░░░░▒▒▒▒▒░▒▒▒▒▒▒▒");    // 16

            Console.SetCursorPosition(posX, posY + 17); Console.Write("▒██▒▒█▒░▒░▒▓▒▒▒▓▒");
            Console.SetCursorPosition(posX + 19, posY + 17); Console.Write("░░░░█░░░█░▒▒▒▒");
            Console.SetCursorPosition(posX + 35, posY + 17); Console.Write("░░░░▒▒▒▒▒▒▒");
            Console.SetCursorPosition(posX + 48, posY + 17); Console.Write("▒▒▒▒██▒░▒▓▓▒▒▒▒");
            Console.SetCursorPosition(posX + 65, posY + 17); Console.Write("▒▒▒▒▒▒▒▒▒░░");
            Console.SetCursorPosition(posX + 77, posY + 17); Console.Write("░█░░█░▒▒▒▓▒░▒▓▒▒▒▓▒");    // 17

        }
        public static void Welcome(int posX, int posY, int pause, int fgColor)
        {
            #region W
            Console.ForegroundColor = (ConsoleColor)fgColor;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(posX, posY);
            Console.Write("░░░░  ░░░░");
            Console.SetCursorPosition(posX, posY + 1);
            Console.Write("░██░  ░██░");
            Console.SetCursorPosition(posX, posY + 2);
            Console.Write("░██░░░░██░");
            Console.SetCursorPosition(posX, posY + 3);
            Console.Write("░██░██░██░");
            Console.SetCursorPosition(posX, posY + 4);
            Console.Write("░████████░");
            Console.SetCursorPosition(posX, posY + 5);
            Console.Write("░███░░███░");
            Console.SetCursorPosition(posX, posY + 6);
            Console.Write("░░░░░░░░░░");
            #endregion
            Thread.Sleep(pause);
            #region E
            Console.ForegroundColor = (ConsoleColor)fgColor;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(posX + 11, posY);
            Console.Write("░░░░░░░░░░");
            Console.SetCursorPosition(posX + 11, posY + 1);
            Console.Write("░░██████░░");
            Console.SetCursorPosition(posX + 11, posY + 2);
            Console.Write("░░██░░░░░░");
            Console.SetCursorPosition(posX + 11, posY + 3);
            Console.Write("░░█████░░░");
            Console.SetCursorPosition(posX + 11, posY + 4);
            Console.Write("░░██░░░░░░");
            Console.SetCursorPosition(posX + 11, posY + 5);
            Console.Write("░░██████░░");
            Console.SetCursorPosition(posX + 11, posY + 6);
            Console.Write("░░░░░░░░░░");
            #endregion 
            Thread.Sleep(pause);
            #region L
            Console.ForegroundColor = (ConsoleColor)fgColor;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(posX + 22, posY);
            Console.Write("░░░░░░    ");
            Console.SetCursorPosition(posX + 22, posY + 1);
            Console.Write("░░██░░    ");
            Console.SetCursorPosition(posX + 22, posY + 2);
            Console.Write("░░██░░    ");
            Console.SetCursorPosition(posX + 22, posY + 3);
            Console.Write("░░██░░    ");
            Console.SetCursorPosition(posX + 22, posY + 4);
            Console.Write("░░██░░░░░░");
            Console.SetCursorPosition(posX + 22, posY + 5);
            Console.Write("░░██████░░");
            Console.SetCursorPosition(posX + 22, posY + 6);
            Console.Write("░░░░░░░░░░");
            #endregion
            Thread.Sleep(pause);
            #region C
            Console.ForegroundColor = (ConsoleColor)fgColor;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(posX + 33, posY);
            Console.Write("░░░░░░░░░░");
            Console.SetCursorPosition(posX + 33, posY + 1);
            Console.Write("░░██████░░");
            Console.SetCursorPosition(posX + 33, posY + 2);
            Console.Write("░░██░░░░░░");
            Console.SetCursorPosition(posX + 33, posY + 3);
            Console.Write("░░██░░    ");
            Console.SetCursorPosition(posX + 33, posY + 4);
            Console.Write("░░██░░░░░░");
            Console.SetCursorPosition(posX + 33, posY + 5);
            Console.Write("░░██████░░");
            Console.SetCursorPosition(posX + 33, posY + 6);
            Console.Write("░░░░░░░░░░");
            #endregion
            Thread.Sleep(pause);
            #region O
            Console.ForegroundColor = (ConsoleColor)fgColor;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(posX + 44, posY);
            Console.Write("░░░░░░░░░░");
            Console.SetCursorPosition(posX + 44, posY + 1);
            Console.Write("░░██████░░");
            Console.SetCursorPosition(posX + 44, posY + 2);
            Console.Write("░░██░░██░░");
            Console.SetCursorPosition(posX + 44, posY + 3);
            Console.Write("░░██░░██░░");
            Console.SetCursorPosition(posX + 44, posY + 4);
            Console.Write("░░██░░██░░");
            Console.SetCursorPosition(posX + 44, posY + 5);
            Console.Write("░░██████░░");
            Console.SetCursorPosition(posX + 44, posY + 6);
            Console.Write("░░░░░░░░░░");
            #endregion
            Thread.Sleep(pause);
            #region M
            Console.ForegroundColor = (ConsoleColor)fgColor;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(posX + 55, posY);
            Console.Write("░░░░  ░░░░");
            Console.SetCursorPosition(posX + 55, posY + 1);
            Console.Write("░███░░███░");
            Console.SetCursorPosition(posX + 55, posY + 2);
            Console.Write("░████████░");
            Console.SetCursorPosition(posX + 55, posY + 3);
            Console.Write("░██░██░██░");
            Console.SetCursorPosition(posX + 55, posY + 4);
            Console.Write("░██░  ░██░");
            Console.SetCursorPosition(posX + 55, posY + 5);
            Console.Write("░██░░░░██░");
            Console.SetCursorPosition(posX + 55, posY + 6);
            Console.Write("░░░░░░░░░░");
            #endregion
            Thread.Sleep(pause);
            #region E
            Console.ForegroundColor = (ConsoleColor)fgColor;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(posX + 66, posY);
            Console.Write("░░░░░░░░░░");
            Console.SetCursorPosition(posX + 66, posY + 1);
            Console.Write("░░██████░░");
            Console.SetCursorPosition(posX + 66, posY + 2);
            Console.Write("░░██░░░░░░");
            Console.SetCursorPosition(posX + 66, posY + 3);
            Console.Write("░░█████░░░");
            Console.SetCursorPosition(posX + 66, posY + 4);
            Console.Write("░░██░░░░░░");
            Console.SetCursorPosition(posX + 66, posY + 5);
            Console.Write("░░██████░░");
            Console.SetCursorPosition(posX + 66, posY + 6);
            Console.Write("░░░░░░░░░░");
            #endregion
            Thread.Sleep(pause);


            #region T
            Console.ForegroundColor = (ConsoleColor)fgColor;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(posX + 81, posY);
            Console.Write("░░░░░░░░░░");
            Console.SetCursorPosition(posX + 81, posY + 1);
            Console.Write("░████████░");
            Console.SetCursorPosition(posX + 81, posY + 2);
            Console.Write("░░░░██░░░░");
            Console.SetCursorPosition(posX + 81, posY + 3);
            Console.Write("  ░░██░░  ");
            Console.SetCursorPosition(posX + 81, posY + 4);
            Console.Write("  ░░██░░  ");
            Console.SetCursorPosition(posX + 81, posY + 5);
            Console.Write("  ░░██░░  ");
            Console.SetCursorPosition(posX + 81, posY + 6);
            Console.Write("  ░░░░░░  ");
            #endregion
            Thread.Sleep(pause);
            #region O
            Console.ForegroundColor = (ConsoleColor)fgColor;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(posX + 92, posY);
            Console.Write("░░░░░░░░░░");
            Console.SetCursorPosition(posX + 92, posY + 1);
            Console.Write("░░██████░░");
            Console.SetCursorPosition(posX + 92, posY + 2);
            Console.Write("░░██░░██░░");
            Console.SetCursorPosition(posX + 92, posY + 3);
            Console.Write("░░██░░██░░");
            Console.SetCursorPosition(posX + 92, posY + 4);
            Console.Write("░░██░░██░░");
            Console.SetCursorPosition(posX + 92, posY + 5);
            Console.Write("░░██████░░");
            Console.SetCursorPosition(posX + 92, posY + 6);
            Console.Write("░░░░░░░░░░");
            #endregion
            Thread.Sleep(pause);
        }
        public static void SinCityLogo(int posX, int posY, int sleep, int FgColor)
        {
            Console.ForegroundColor = (ConsoleColor)FgColor;
            Console.SetCursorPosition(posX + 9, posY);
            Console.Write("▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(posX + 61, posY);
            Console.Write("▓▓▓▓▓▓");//0
            Thread.Sleep(sleep);

            Console.SetCursorPosition(posX + 7, posY + 1);
            Console.Write("▓███▒▒▒▒▒▒▓");
            Console.SetCursorPosition(posX + 58, posY + 1);
            Console.Write("▓▓█▓▒▒▒▒▓▓▓");//1
            Thread.Sleep(sleep);


            Console.SetCursorPosition(posX + 6, posY + 2);
            Console.Write("▓██▒▒");
            Console.SetCursorPosition(posX + 17, posY + 2);
            Console.Write("▒▓");
            Console.SetCursorPosition(posX + 57, posY + 2);
            Console.Write("▓█▓▒▒");
            Console.SetCursorPosition(posX + 67, posY + 2);
            Console.Write("▒▒▒");
            Console.SetCursorPosition(posX + 81, posY + 2);
            Console.Write("▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(posX + 107, posY + 2);
            Console.Write("▓▓▓");//2
            Thread.Sleep(sleep);


            Console.SetCursorPosition(posX + 5, posY + 3);
            Console.Write("▓██▒");
            Console.SetCursorPosition(posX + 56, posY + 3);
            Console.Write("▓█▓▒");
            Console.SetCursorPosition(posX + 74, posY + 3);
            Console.Write("▓▓▓▓▓▓▓█████▓▒▒▒▒▒▒▒");
            Console.SetCursorPosition(posX + 106, posY + 3);
            Console.Write("▓█▓▒");//3
            Thread.Sleep(sleep);


            Console.SetCursorPosition(posX + 5, posY + 4);
            Console.Write("▓██▒");
            Console.SetCursorPosition(posX + 56, posY + 4);
            Console.Write("▓▓▒");
            Console.SetCursorPosition(posX + 73, posY + 4);
            Console.Write("▓▒▒▒▒▒▒▒▒▒▓██▒");
            Console.SetCursorPosition(posX + 105, posY + 4);
            Console.Write("▓██▓▒");//4
            Thread.Sleep(sleep);


            Console.SetCursorPosition(posX + 6, posY + 5);
            Console.Write("▓██▒");
            Console.SetCursorPosition(posX + 28, posY + 5);
            Console.Write("▓▓");
            Console.SetCursorPosition(posX + 42, posY + 5);
            Console.Write("▓▓▓▓");
            Console.SetCursorPosition(posX + 55, posY + 5);
            Console.Write("▓█▒");
            Console.SetCursorPosition(posX + 83, posY + 5);
            Console.Write("▒▒▓▓▒");
            Console.SetCursorPosition(posX + 93, posY + 5);
            Console.Write("▓▓▓");
            Console.SetCursorPosition(posX + 105, posY + 5);
            Console.Write("▓█▓▒");//5
            Thread.Sleep(sleep);


            Console.SetCursorPosition(posX + 7, posY + 6);
            Console.Write("▓▓█▓▓▓▓▓▓▓");
            Console.SetCursorPosition(posX + 27, posY + 6);
            Console.Write("▓██▒");
            Console.SetCursorPosition(posX + 36, posY + 6);
            Console.Write("▓▓▓");
            Console.SetCursorPosition(posX + 40, posY + 6);
            Console.Write("▓█████▓▒");
            Console.SetCursorPosition(posX + 55, posY + 6);
            Console.Write("▓█▒");
            Console.SetCursorPosition(posX + 74, posY + 6);
            Console.Write("▓▓▓");
            Console.SetCursorPosition(posX + 85, posY + 6);
            Console.Write("▓█▓");
            Console.SetCursorPosition(posX + 94, posY + 6);
            Console.Write("▓█▓");
            Console.SetCursorPosition(posX + 104, posY + 6);
            Console.Write("▓█▓▒");//6
            Thread.Sleep(sleep);


            Console.SetCursorPosition(posX + 9, posY + 7);
            Console.Write("▒▒▒▒▓███▓▓▓▓▓");
            Console.SetCursorPosition(posX + 28, posY + 7);
            Console.Write("▓█▓▒");
            Console.SetCursorPosition(posX + 36, posY + 7);
            Console.Write("▓████▓▒▒▒▓█▓▒");
            Console.SetCursorPosition(posX + 55, posY + 7);
            Console.Write("▓█▒");
            Console.SetCursorPosition(posX + 74, posY + 7);
            Console.Write("▓██▒");
            Console.SetCursorPosition(posX + 85, posY + 7);
            Console.Write("▓██▒");
            Console.SetCursorPosition(posX + 95, posY + 7);
            Console.Write("▓█▓");
            Console.SetCursorPosition(posX + 103, posY + 7);
            Console.Write("▓▓▒");//7
            Thread.Sleep(sleep);


            Console.SetCursorPosition(posX + 14, posY + 8);
            Console.Write("▒▒▒▒▓██▓▒");
            Console.SetCursorPosition(posX + 29, posY + 8);
            Console.Write("▓█▓▒");
            Console.SetCursorPosition(posX + 37, posY + 8);
            Console.Write("▓█▓▓▒");
            Console.SetCursorPosition(posX + 45, posY + 8);
            Console.Write("▒▓█▓▒");
            Console.SetCursorPosition(posX + 55, posY + 8);
            Console.Write("▓█▒");
            Console.SetCursorPosition(posX + 75, posY + 8);
            Console.Write("▓█▒");
            Console.SetCursorPosition(posX + 86, posY + 8);
            Console.Write("▓█▓▒");
            Console.SetCursorPosition(posX + 96, posY + 8);
            Console.Write("▓██▓");
            Console.SetCursorPosition(posX + 102, posY + 8);
            Console.Write("▓▓▒");//8
            Thread.Sleep(sleep);


            Console.SetCursorPosition(posX + 18, posY + 9);
            Console.Write("▓███▓▒");
            Console.SetCursorPosition(posX + 29, posY + 9);
            Console.Write("▓██▒");
            Console.SetCursorPosition(posX + 37, posY + 9);
            Console.Write("▓█▒▒");
            Console.SetCursorPosition(posX + 47, posY + 9);
            Console.Write("▓█▓▒");
            Console.SetCursorPosition(posX + 56, posY + 9);
            Console.Write("▓▒");
            Console.SetCursorPosition(posX + 75, posY + 9);
            Console.Write("▓██▒");
            Console.SetCursorPosition(posX + 86, posY + 9);
            Console.Write("▓██▒");
            Console.SetCursorPosition(posX + 97, posY + 9);
            Console.Write("▓████▓▒");//9
            Thread.Sleep(sleep);


            Console.SetCursorPosition(posX + 18, posY + 10);
            Console.Write("▓████▒");
            Console.SetCursorPosition(posX + 29, posY + 10);
            Console.Write("▓██▒");
            Console.SetCursorPosition(posX + 37, posY + 10);
            Console.Write("▓█▒");
            Console.SetCursorPosition(posX + 48, posY + 10);
            Console.Write("▓█▒");
            Console.SetCursorPosition(posX + 56, posY + 10);
            Console.Write("▓▓▒");
            Console.SetCursorPosition(posX + 76, posY + 10);
            Console.Write("▓█▒");
            Console.SetCursorPosition(posX + 86, posY + 10);
            Console.Write("▓██▒");
            Console.SetCursorPosition(posX + 99, posY + 10);
            Console.Write("███▒");//0
            Thread.Sleep(sleep);


            Console.SetCursorPosition(posX + 18, posY + 11);
            Console.Write("▓████▓▒");
            Console.SetCursorPosition(posX + 29, posY + 11);
            Console.Write("▓█▓▒");
            Console.SetCursorPosition(posX + 38, posY + 11);
            Console.Write("▓▓▒");
            Console.SetCursorPosition(posX + 49, posY + 11);
            Console.Write("█▓▒");
            Console.SetCursorPosition(posX + 57, posY + 11);
            Console.Write("▓▓▒");
            Console.SetCursorPosition(posX + 76, posY + 11);
            Console.Write("▓█▒");
            Console.SetCursorPosition(posX + 87, posY + 11);
            Console.Write("▓█▓▒");
            Console.SetCursorPosition(posX + 99, posY + 11);
            Console.Write("▓██▒");//1
            Thread.Sleep(sleep);


            Console.SetCursorPosition(posX + 2, posY + 12);
            Console.Write("▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(posX + 17, posY + 12);
            Console.Write("▓█████▓▒");
            Console.SetCursorPosition(posX + 29, posY + 12);
            Console.Write("▓█▒");
            Console.SetCursorPosition(posX + 38, posY + 12);
            Console.Write("▓█▒");
            Console.SetCursorPosition(posX + 49, posY + 12);
            Console.Write("▓█▒");
            Console.SetCursorPosition(posX + 58, posY + 12);
            Console.Write("▓█▓▒");
            Console.SetCursorPosition(posX + 76, posY + 12);
            Console.Write("▓▒▒");
            Console.SetCursorPosition(posX + 87, posY + 12);
            Console.Write("▓██▒");
            Console.SetCursorPosition(posX + 100, posY + 12);
            Console.Write("▓█▒");//2
            Thread.Sleep(sleep);


            Console.SetCursorPosition(posX + 1, posY + 13);
            Console.Write("▓█▒▒");
            Console.SetCursorPosition(posX + 7, posY + 13);
            Console.Write("▒▒▒▓▓▓▓▓▓▓█████▓▒");
            Console.SetCursorPosition(posX + 29, posY + 13);
            Console.Write("▓█▒");
            Console.SetCursorPosition(posX + 38, posY + 13);
            Console.Write("▓▓▒");
            Console.SetCursorPosition(posX + 50, posY + 13);
            Console.Write("█▓▒");
            Console.SetCursorPosition(posX + 59, posY + 13);
            Console.Write("▓██▓▒");
            Console.SetCursorPosition(posX + 87, posY + 13);
            Console.Write("▓██▒");
            Console.SetCursorPosition(posX + 100, posY + 13);
            Console.Write("▓█▒");//3
            Thread.Sleep(sleep);


            Console.SetCursorPosition(posX + 1, posY + 14);
            Console.Write("▓");
            Console.SetCursorPosition(posX + 10, posY + 14);
            Console.Write("▒▒▒▓██████▓▒");
            Console.SetCursorPosition(posX + 30, posY + 14);
            Console.Write("▓▓▒");
            Console.SetCursorPosition(posX + 38, posY + 14);
            Console.Write("▓▒");
            Console.SetCursorPosition(posX + 50, posY + 14);
            Console.Write("██▒");
            Console.SetCursorPosition(posX + 59, posY + 14);
            Console.Write("▓████▓▒");
            Console.SetCursorPosition(posX + 71, posY + 14);
            Console.Write("▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(posX + 87, posY + 14);
            Console.Write("▓█▓▒");
            Console.SetCursorPosition(posX + 99, posY + 14);
            Console.Write("▓█▓▒");//4
            Thread.Sleep(sleep);


            Console.SetCursorPosition(posX, posY + 15);
            Console.Write("▓");
            Console.SetCursorPosition(posX + 13, posY + 15);
            Console.Write("▒▒▒▒▒▒▒");
            Console.SetCursorPosition(posX + 30, posY + 15);
            Console.Write("▓▒▒");
            Console.SetCursorPosition(posX + 38, posY + 15);
            Console.Write("▓");
            Console.SetCursorPosition(posX + 50, posY + 15);
            Console.Write("▓█▒");
            Console.SetCursorPosition(posX + 61, posY + 15);
            Console.Write("▓▓████████████▓▒▒▒▒▓▓");
            Console.SetCursorPosition(posX + 89, posY + 15);
            Console.Write("▒▒");
            Console.SetCursorPosition(posX + 99, posY + 15);
            Console.Write("▓█▒");//5
            Thread.Sleep(sleep);

            Console.SetCursorPosition(posX + 51, posY + 16);
            Console.Write("█▒");
            Console.SetCursorPosition(posX + 64, posY + 16);
            Console.Write("▓▓████▓▒▒▒▒▒");
            Console.SetCursorPosition(posX + 80, posY + 16);
            Console.Write("▒▒▒▓▓");
            Console.SetCursorPosition(posX + 99, posY + 16);
            Console.Write("▓█▒");//6
            Thread.Sleep(sleep);

            Console.SetCursorPosition(posX + 51, posY + 17);
            Console.Write("▓▒");
            Console.SetCursorPosition(posX + 66, posY + 17);
            Console.Write("▒▒▒▒▒");
            Console.SetCursorPosition(posX + 84, posY + 17);
            Console.Write("▒▓");
            Console.SetCursorPosition(posX + 99, posY + 17);
            Console.Write("▓▓▒");//7
            Thread.Sleep(sleep);

            Console.SetCursorPosition(posX + 52, posY + 18);
            Console.Write("▒");
            Console.SetCursorPosition(posX + 99, posY + 18);
            Console.Write("▓▒");
            Thread.Sleep(sleep);


            Console.SetCursorPosition(posX + 99, posY + 19);
            Console.Write("▓▒");//9
            Thread.Sleep(sleep);


            Console.SetCursorPosition(posX + 99, posY + 20);
            Console.Write("▓");//0
            Thread.Sleep(sleep);


            Console.SetCursorPosition(posX + 99, posY + 21);
            Console.Write("▓");//1
            Thread.Sleep(sleep);


            Console.SetCursorPosition(posX + 99, posY + 22);
            Console.Write("▓");//2
            Thread.Sleep(sleep);




        }
        public static void SinCityBWSunset(int posX, int posY)
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write("                                          ████████████░░░                                        ");
            Console.SetCursorPosition(posX, posY + 1);
            Console.Write("     ░░░░░░░░                    ████▓░░░░██▓████████▓░░░██████                        ░░░░░     ");
            Console.SetCursorPosition(posX, posY + 2);
            Console.Write("     ░▒░▒▒░▒░            █████████████░▒▒░███████▓████░░░█▓████████████                ░▒░▒░     ");
            Console.SetCursorPosition(posX, posY + 3);
            Console.Write("     ░░░░░░░░      ░░░░░░░░░░░█▓███▓██░░░░▓▒▓▓▓▓█▓▓▓▓░░░░░███████▓███▓███████          ░░░░░     ");
            Console.SetCursorPosition(posX, posY + 4);
            Console.Write("     ░▒░▒▒░░░ █████░▒▒░░▒▒▒▒▒▒▒▒▓▓▓█░░░▒▒░▓▓▓▓▓▒▓▓▓▓▒░▒░▒░▒▓▓▓█▓▓▓▓████▓██▓██████      ░░░▒░     ");
            Console.SetCursorPosition(posX, posY + 5);
            Console.Write("     ░░░░░░░░██████░░░░░░▒▒▒▒▒▒▒▒▓▓░░░░░░░░▒▒▓▒▒▒▒▒▒▓░░░░░▓▓▒▓▓▓▓▒▓▓▓█▓█▓█████▓▒▒▒▒▒▒▒▒▒░░░░     ");
            Console.SetCursorPosition(posX, posY + 6);
            Console.Write("     ░▒░░░▒▒▒▒▒▒▒▓█░▒▒░░▒▒▓▓▒▓▓▒▒▒▒░░▒░▒░▒░░▒▒▒▓▒▒░▒▒░▒░░▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▓▓▓▓██▒▒▒▒▒▒▒▒▒░░░░░    ");
            Console.SetCursorPosition(posX, posY + 7);
            Console.Write("     ░░░░░▒▓▒▓▒▓▒▓▓░░░░░░▒▒▒▒▒▒▒▓▒▒░░░░▒▒▒▒▒▒▒▒░░░▒░░░░░░▒▓▒▒▒▒▓▒▒░▒█▒▒█▒░░░█▓▓▒▓▓▓▒▓▓▓▒░░▒░░    ");
            Console.SetCursorPosition(posX, posY + 8);
            Console.Write("     ░▒░▒▒▒▒▒▒▒▒▒█▓░░░░░░░░░░▒▒▒▒░▒░░▒░▒▓▒▓▒▓▒░▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒▒░▒░▒▒▒▒▒▒░░░▓▒▓▒▒▒▒▒▒▒▒▒░░░░░░░  ");
            Console.SetCursorPosition(posX, posY + 9);
            Console.Write("▒▒▒▒▒▒▒░░░▒▓▒▓▒▒▒▒▓░░░░█░█░█░▒▓▒▒▒░░░░░▒▒▒▒▒▒▒░░▒▒▒▒██▒░░▒▓▒▓▒░▒░░░▒▒▒▒█▒░░░▒▒▓▒▓▒▓▒▓▒▓▒░▒▒▒▒░░  ");
            Console.SetCursorPosition(posX, posY + 10);
            Console.Write("▒██▒▒▒▒░░░▒▒▒▒▒▒▒▒▒░▒▒░░░░░░░▒▒▒░░░░▒▒░▒▒▒▒▒▓▒░░▒▒▒▒▒▒▒░▒▒▒▒▒▒▒░░▒░▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒░▒▓▓▒░░  ");
            Console.SetCursorPosition(posX, posY + 11);
            Console.Write("▒▒▒▒█▒▒░░░▒▓▒▓▒▓▒▓▒░░░░░░█░█░▒▒▒░░░░░░░▒▒▒▒▒▒▒░░▒██▒██▒░▒▓▓▒▓▓▒░░▒▒▒▒▒▒▒▒▒░░▒░▓▒▒▒▓▒▒▒▓▒░▒▒▒▒░░  ");
            Console.SetCursorPosition(posX, posY + 12);
            Console.Write("▒▒▒▒▒▒▒░▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░▒▓▒░░░░▒░░▒▒▒▓▒▓▒░░▒▒▒▒▒▒▒░▒▒▒▒▒▒▒░░▒▒██▒▒█▒▒░░░░░░░░░▒▒▒▒▒░▒▒▒▒▒▒▒ ");
            Console.SetCursorPosition(posX, posY + 13);
            Console.Write("▒██▒█▒▒░░░▒▒▒▓▒▒▒▒▒░░░░█░█░░░▒▒▒░░░░░░░▒▒▒▒▒▒▒░░▒██▒▒▒▒░▒▓▓▒▒▒▒░░▒▒▒▒▒▒▒▒▒░░▒░█░░░░▒▓▒▒▒░▒▓▒▓▒▓▒ ");
            Console.SetCursorPosition(posX, posY + 14);
            Console.Write("▒▒▒▒▒▒▒░▒▒▒▒▒▒▒▒▒▒░░▒▒░░░░░░░▒▒▒░░░░░▒░▒▓▒▓▒▒▒░░▒▒▒▒▒▒▒░▒▒▒▒▒▒▒░░▒▒██▒▒▒▒▒░░░░░░░░░▒▒▒▒▒░▒▒▒▒▒▒▒ ");
            Console.SetCursorPosition(posX, posY + 15);
            Console.Write("▒▒▒▒▒█▒░░░▒▓▒▒▒▒▒  ░░░░░░█░░░▒▒▒▒  ░░░░▒▒▒▒▒▒▒  ▒██▒▒▒▒░▒▒▒▒▓▓▒  ▒▒▒▒▒▒▒▒▒░░ ░░░░█░▒▓▒▓▒░▒▒▒▒▒▓▒ ");
            Console.SetCursorPosition(posX, posY + 16);
            Console.Write("▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒  ░░░░░░░░░░▒▒▒▒  ░▒░▒▒▒▒▓▒▒▒  ▒▒▒▒▒▒▒░▒▒▒▒▒▒▒  ▒▒▒▒▒▒█▒▒░░ ░░░░░░▒▒▒▒▒░▒▒▒▒▒▒▒ ");
            Console.SetCursorPosition(posX, posY + 17);
            Console.Write("▒██▒▒█▒░▒░▒▓▒▒▒▓▒  ░░░░█░░░█░▒▒▒▒  ░░░░▒▒▒▒▒▒▒  ▒▒▒▒██▒░▒▓▓▒▒▒▒  ▒▒▒▒▒▒▒▒▒░░ ░█░░█░▒▒▒▓▒░▒▓▒▒▒▓▒ ");
            //Console.SetCursorPosition(posX, posY + 18);
            //Console.Write("                                                                                                 ");
            //Console.SetCursorPosition(posX, posY + 19);
            //Console.Write("                                                                                                 ");
            //Console.SetCursorPosition(posX, posY + 20);
            //Console.Write("░                 █░            ░▒█░▒        ░▒█▒              █           ▒█                   ░");
            //Console.SetCursorPosition(posX, posY + 21);
            //Console.Write("                 ░▒█▒▒         ░ █▒▒░░      ▒ ▒░           ░▓▒░ ▒░           ▓                   ");
            //Console.SetCursorPosition(posX, posY + 22);
            //Console.Write("     ░         ▓                ▒ ▒▒ ▒          ▓             ▓   ▒▒      ▒█  ░ ░                ");
            //Console.SetCursorPosition(posX, posY + 23);
            //Console.Write("             ▒ ▒ ▒░▓░▒░░       ░ ░ ░       ▒▒░▓▒▓▒░          ░▓▒░▒▓      ░ ░▓  ░        ▒        ");
            //Console.SetCursorPosition(posX, posY + 24);
            //Console.Write("              ▒▓█░      ░▒▓░░ ░    ▓░ ░   ▒█ ░    ▓     ░▓▒░               ▓                     ");
            //Console.SetCursorPosition(posX, posY + 25);
            //Console.Write("  ░      ░░   ▓    ░▒ ░        █ ▒▒░          ▒█░▒ ░░          ▒  ░▓░ ░    ▒  ▓   ░░░            ");
            //Console.SetCursorPosition(posX, posY + 26);
            //Console.Write("      ░░    ░░░█   ▓               █▓               ▒ ▒     ▓   ██               █    ░          ");
            //Console.SetCursorPosition(posX, posY + 27);
            //Console.Write("        ░        █    ░░░      ▓        ░▒░    ░█▒▒  ░   ▒▒▒░░██ ▒░ █      ░░▒▒░ █         ░░    ");
            //Console.SetCursorPosition(posX, posY + 28);
            //Console.Write("     ░       █           █       ██▓          ██                █    █  █      █       ░░        ");
            //Console.SetCursorPosition(posX, posY + 29);
            //Console.Write("        ░         █     █       ░░░  ██      ░░░█     ███░░  ░░░ ░░░  ░░    ██     █      ░      ");
            //Console.SetCursorPosition(posX, posY + 30);
            //Console.Write("             ░             ░░            ░        ░░      ░░              ░           ░          ");

        }
    }
}
/*





























 */
