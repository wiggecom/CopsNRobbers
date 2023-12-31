﻿using System;
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
        public static void CityFrame(int cityWidth, int cityHeight, int cityLeft, int cityTop)
        {
            DrawSinCity(cityTop);
            CityOuterFrame(cityWidth, cityHeight, cityLeft, cityTop);
            LocalPeeps();
        }
        public static void DrawSinCity(int cityTop)
        {
            int topperPosLeft = (Console.WindowWidth / 2) - 44;
            // 87 chars wide, 6 chars high (center - 44)
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(topperPosLeft, cityTop - 7);
            Console.Write("░░░   ▒▒▒▒       ▒▒▒▒ ░░░░     ▒▒▒▒  ▒▒▒▒    ░░░   ▓▓▓▓   ░░░░░  ▒▒▒▒      ▓▓▓▓      ░░░");

            Console.SetCursorPosition(topperPosLeft, cityTop - 6);
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

            Console.SetCursorPosition(topperPosLeft, cityTop - 5);
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

            Console.SetCursorPosition(topperPosLeft, cityTop - 4);
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

            Console.SetCursorPosition(topperPosLeft, cityTop - 3);
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

            Console.SetCursorPosition(topperPosLeft, cityTop - 2);
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
        public static void CityOuterFrame(int cityWidth, int cityHeight, int cityLeft, int cityTop)
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
    }
}
