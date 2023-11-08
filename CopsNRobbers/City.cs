using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CopsNRobbers
{
    public class City
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Depth { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public bool pacMan { get; set; } = false;
        public string[,,] CityArray { get; set; }
        

        public City(int width, int heigth, int depth)
        {
            Height = heigth;
            Width = width;
            Depth = depth;
            //CityArray = new string[heigth, width, depth];
        }

        public City()
        {
            Height = 25;
            Width = 100;
            Depth = 5;
        }

        public string[,,] MakeCity(City city)
        {
            string[,,] cityArray = new string[city.Height, city.Width, city.Depth];
            return cityArray;

        }
        public string[,,] FillCity(string[,,] cityMap) // Initialize layers
        {
            int xInt = 0;
            for (int heightIndex = 0; heightIndex < Height; heightIndex++)
            {
                for (int widthIndex = 0; widthIndex < Width; widthIndex++)
                {
                    for (int depthIndex = 0; depthIndex < Depth; depthIndex++)
                    {
                        cityMap[heightIndex, widthIndex, depthIndex] = " ";    // nothing
                    }
                    xInt++;
                }
            }
            return cityMap;
        }
        public void DrawCity(string[,,] cityMap, int posLeft, int posTop)
        {
            int posLeftReset = posLeft;
            int posTopReset = posTop;
            int[] layerColor = new int[10];
            layerColor[0] = 3;  // DarkCyan - Police
            layerColor[1] = 12; // Red      - Thief
            layerColor[2] = 10; // Green   - Citizen
            layerColor[3] = 2;  // DarkGreen
            layerColor[4] = 6;  // DarkYellow
            layerColor[5] = 5;  // DarkMagenta
            layerColor[6] = 4;  // DarkRed
            layerColor[7] = 1;  // DarkBlue
            layerColor[8] = 15; // White
            layerColor[9] = 8;  // DarkGray - Background

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
            for (int depthIndex = Depth - 1; depthIndex >= 0; depthIndex--)
            {
                posLeft = posLeftReset;
                posTop = posTopReset;
                for (int heightIndex = 0; heightIndex < Height; heightIndex++)
                {
                    Console.CursorLeft = posLeft;
                    Console.CursorTop = posTop;
                    for (int widthIndex = 0; widthIndex < Width; widthIndex++)
                    {
                        if (cityMap[heightIndex, widthIndex, depthIndex] != " ")
                        {
                            Console.SetCursorPosition(widthIndex + posLeftReset, heightIndex + posTopReset);
                            //Console.Write(depthIndex);
                            Console.ForegroundColor = (ConsoleColor)layerColor[depthIndex];
                            Console.Write(cityMap[heightIndex, widthIndex, depthIndex]);
                        }

                    }
                    Console.WriteLine();
                    posTop++;
                }
                //Console.ReadKey();
            }

            Console.SetCursorPosition(1, 9);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("███████████████████░N░E░W░S░███▓▓▓▓▓▓▓▒▒▒▒▒▒░░░");
            Console.SetCursorPosition(152, 9);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("░░░▒▒▒▒▒▒▓▓▓▓▓▓▓███░S░T░A░T░S░████████████████");
        }
        public static string[,,] PutMapOnLayer(int mapSizeY, int mapSizeX, int mapDepth, string[,,] cityArray, int cityFilled)
        {
            // 
            string mapLayer00 = ""; string mapLayer01 = ""; string mapLayer02 = ""; string mapLayer03 = ""; string mapLayer04 = ""; string mapLayer05 = ""; string mapLayer06 = ""; string mapLayer07 = ""; string mapLayer08 = ""; string mapLayer09 = "";
            string mapLayer10 = ""; string mapLayer11 = ""; string mapLayer12 = ""; string mapLayer13 = ""; string mapLayer14 = ""; string mapLayer15 = ""; string mapLayer16 = ""; string mapLayer17 = ""; string mapLayer18 = ""; string mapLayer19 = "";
            string mapLayer20 = ""; string mapLayer21 = ""; string mapLayer22 = ""; string mapLayer23 = ""; string mapLayer24 = ""; string mapLayer25 = ""; string mapLayer26 = ""; string mapLayer27 = ""; string mapLayer28 = ""; string mapLayer29 = "";
            string mapLayer30 = ""; string mapLayer31 = ""; string mapLayer32 = ""; string mapLayer33 = ""; string mapLayer34 = ""; string mapLayer35 = ""; string mapLayer36 = ""; string mapLayer37 = ""; string mapLayer38 = ""; string mapLayer39 = "";

            //
            if (cityFilled == 1)
            {
                mapLayer00 = "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░S░I░N░▒░C░I░T░Y░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒"; // 00
                mapLayer01 = "▒                                                                                                    ▒"; // 01
                mapLayer02 = "▒                                                                                                    ▒"; // 02
                mapLayer03 = "▒                                                                                                    ▒"; // 03
                mapLayer04 = "▒                                                                                                    ▒"; // 04
                mapLayer05 = "▒                                                                                                    ▒"; // 05
                mapLayer06 = "▒                                                                                                    ▒"; // 06
                mapLayer07 = "▒                                                                                                    ▒"; // 07
                mapLayer08 = "▒                                                                                                    ▒"; // 08
                mapLayer09 = "▒                                                                                                    ▒"; // 09
                mapLayer10 = "▒                                                                                                    ▒"; // 10
                mapLayer11 = "▒                                                                                                    ▒"; // 11
                mapLayer12 = "▒                                                                                                    ▒"; // 12
                mapLayer13 = "▒                                                                                                    ▒"; // 13
                mapLayer14 = "▒                                                                                                    ▒"; // 14
                mapLayer15 = "▒                                                                                                    ▒"; // 15
                mapLayer16 = "▒                                                                                                    ▒"; // 16
                mapLayer17 = "▒                                                                                                    ▒"; // 17
                mapLayer18 = "▒                                                                                                    ▒"; // 18
                mapLayer19 = "▒                                                                                                    ▒"; // 19
                mapLayer20 = "▒                                                                                                    ▒"; // 20
                mapLayer21 = "▒                                                                                                    ▒"; // 21
                mapLayer22 = "▒                                                                                                    ▒"; // 22
                mapLayer23 = "▒                                                                                                    ▒"; // 23
                mapLayer24 = "▒                                                                                                    ▒"; // 24
                mapLayer25 = "▒                                                                                                    ▒"; // 25
                mapLayer26 = "▒▒▒▒▒▒░J░A░I░L░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░P░O░V░E░R░T░Y░▒▒▒▒"; // 26
                mapLayer27 = "▒                    ▒                                                          ▒                    ▒"; // 27
                mapLayer28 = "▒                    ▒                                                          ▒                    ▒"; // 28
                mapLayer29 = "▒                    ▒                                                          ▒                    ▒"; // 29
                mapLayer30 = "▒                    ▒                                                          ▒                    ▒"; // 30
                mapLayer31 = "▒                    ▒                                                          ▒                    ▒"; // 31
                mapLayer32 = "▒                    ▒                                                          ▒                    ▒"; // 32
                mapLayer33 = "▒                    ▒                                                          ▒                    ▒"; // 33
                mapLayer34 = "▒                    ▒                                                          ▒                    ▒"; // 34
                mapLayer35 = "▒                    ▒                                                          ▒                    ▒"; // 35
                mapLayer36 = "▒                    ▒                                                          ▒                    ▒"; // 36
                mapLayer37 = "▒                    ▒                                                          ▒                    ▒"; // 37
                mapLayer38 = "▒                    ▒                                                          ▒                    ▒"; // 38
                mapLayer39 = "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒"; // 39
            }
            if (cityFilled == 2)
            {
                mapLayer00 = "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░S░I░N░▒░C░I░T░Y░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒"; // 00
                mapLayer01 = "▒                                                                                                    ▒"; // 01
                mapLayer02 = "▒                                                                                                    ▒"; // 02
                mapLayer03 = "▒                                                                                                    ▒"; // 03
                mapLayer04 = "▒                                                                                                    ▒"; // 04
                mapLayer05 = "▒                                                                                                    ▒"; // 05
                mapLayer06 = "▒                ▒                                 ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                                  ▒"; // 06
                mapLayer07 = "▒                ▒                                                                                   ▒"; // 07
                mapLayer08 = "▒                ▒                                                                                   ▒"; // 08
                mapLayer10 = "▒                ▒                                                                  ▒                ▒"; // 10
                mapLayer11 = "▒                ▒                                                                  ▒                ▒"; // 11
                mapLayer12 = "▒                ▒                                                                  ▒                ▒"; // 12
                mapLayer13 = "▒                ▒                                                                  ▒                ▒"; // 13
                mapLayer14 = "▒                ▒                                                                  ▒                ▒"; // 14
                mapLayer15 = "▒                ▒                                                                  ▒                ▒"; // 15
                mapLayer09 = "▒                ▒                                                                  ▒                ▒"; // 09
                mapLayer16 = "▒                                                                                   ▒                ▒"; // 16
                mapLayer17 = "▒                                                                                   ▒                ▒"; // 17
                mapLayer18 = "▒                                                                                   ▒                ▒"; // 18
                mapLayer19 = "▒                                                                                                    ▒"; // 19
                mapLayer20 = "▒                                                                                                    ▒"; // 20
                mapLayer21 = "▒                                ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                                                    ▒"; // 21
                mapLayer22 = "▒                                                                                                    ▒"; // 22
                mapLayer23 = "▒                                                                                                    ▒"; // 23
                mapLayer24 = "▒                                                                                                    ▒"; // 24
                mapLayer25 = "▒                                                                                                    ▒"; // 25
                mapLayer26 = "▒▒▒▒▒▒░J░A░I░L░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░P░O░V░E░R░T░Y░▒▒▒▒"; // 26
                mapLayer27 = "▒                    ▒                                                          ▒                    ▒"; // 27
                mapLayer28 = "▒                    ▒                                                          ▒                    ▒"; // 28
                mapLayer29 = "▒                    ▒                                                          ▒                    ▒"; // 29
                mapLayer30 = "▒                    ▒                                                          ▒                    ▒"; // 30
                mapLayer31 = "▒                    ▒                                                          ▒                    ▒"; // 31
                mapLayer32 = "▒                    ▒                                                          ▒                    ▒"; // 32
                mapLayer33 = "▒                    ▒                                                          ▒                    ▒"; // 33
                mapLayer34 = "▒                    ▒                                                          ▒                    ▒"; // 34
                mapLayer35 = "▒                    ▒                                                          ▒                    ▒"; // 35
                mapLayer36 = "▒                    ▒                                                          ▒                    ▒"; // 36
                mapLayer37 = "▒                    ▒                                                          ▒                    ▒"; // 37
                mapLayer38 = "▒                    ▒                                                          ▒                    ▒"; // 38
                mapLayer39 = "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒"; // 39
            }
            //if (cityFilled == 3)
            //{
            //    //             123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 1
            //    mapLayer00 = "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░S░I░N░▒░C░I░T░Y░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒"; // 00
            //    mapLayer01 = "▒                                                                                                    ▒"; // 01
            //    mapLayer02 = "▒                                                                                                    ▒"; // 02
            //    mapLayer03 = "▒                                                                                                    ▒"; // 03
            //    mapLayer04 = "▒        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒                                        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒        ▒"; // 04
            //    mapLayer05 = "▒        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒                                        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒        ▒"; // 05
            //    mapLayer06 = "▒        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒                                        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒        ▒"; // 06
            //    mapLayer07 = "▒        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒                                        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒        ▒"; // 07
            //    mapLayer08 = "▒                                                                                                    ▒"; // 08
            //    mapLayer09 = "▒                                                                                                    ▒"; // 09
            //    mapLayer10 = "▒                                                                                                    ▒"; // 10
            //    mapLayer11 = "▒        ▒▒▒▒▒▒▒                                                                      ▒▒▒▒▒▒▒        ▒"; // 11
            //    mapLayer12 = "▒        ▒▒▒▒▒▒▒                                                                      ▒▒▒▒▒▒▒        ▒"; // 12
            //    mapLayer13 = "▒        ▒▒▒▒▒▒▒                                                                      ▒▒▒▒▒▒▒        ▒"; // 13
            //    mapLayer14 = "▒        ▒▒▒▒▒▒▒                                                                      ▒▒▒▒▒▒▒        ▒"; // 14
            //    mapLayer15 = "▒        ▒▒▒▒▒▒▒                                                                      ▒▒▒▒▒▒▒        ▒"; // 15
            //    mapLayer16 = "▒                                                                                                    ▒"; // 16
            //    mapLayer17 = "▒                                                                                                    ▒"; // 17
            //    mapLayer18 = "▒                                                                                                    ▒"; // 18
            //    mapLayer19 = "▒        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒                                        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒        ▒"; // 19
            //    mapLayer20 = "▒        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒                                        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒        ▒"; // 20
            //    mapLayer21 = "▒        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒                                        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒        ▒"; // 21
            //    mapLayer22 = "▒        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒                                        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒        ▒"; // 22
            //    mapLayer23 = "▒                                                                                                    ▒"; // 23
            //    mapLayer24 = "▒                                                                                                    ▒"; // 24
            //    mapLayer25 = "▒                                                                                                    ▒"; // 25
            //    mapLayer26 = "▒▒▒▒▒▒░J░A░I░L░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░P░O░V░E░R░T░Y░▒▒▒▒"; // 26
            //    mapLayer27 = "▒                    ▒                                                          ▒                    ▒"; // 27
            //    mapLayer28 = "▒                    ▒                                                          ▒                    ▒"; // 28
            //    mapLayer29 = "▒                    ▒                                                          ▒                    ▒"; // 29
            //    mapLayer30 = "▒                    ▒                                                          ▒                    ▒"; // 30
            //    mapLayer31 = "▒                    ▒                                                          ▒                    ▒"; // 31
            //    mapLayer32 = "▒                    ▒                                                          ▒                    ▒"; // 32
            //    mapLayer33 = "▒                    ▒                                                          ▒                    ▒"; // 33
            //    mapLayer34 = "▒                    ▒                                                          ▒                    ▒"; // 34
            //    mapLayer35 = "▒                    ▒                                                          ▒                    ▒"; // 35
            //    mapLayer36 = "▒                    ▒                                                          ▒                    ▒"; // 36
            //    mapLayer37 = "▒                    ▒                                                          ▒                    ▒"; // 37
            //    mapLayer38 = "▒                    ▒                                                          ▒                    ▒"; // 38
            //    mapLayer39 = "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒"; // 39

            //}
            if (cityFilled == 3)
            {
                //             123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 1
                mapLayer00 = "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░S░I░N░▒░C░I░T░Y░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒"; // 00
                mapLayer01 = "▒                                                                                                    ▒"; // 01
                mapLayer02 = "▒                                                                                                    ▒"; // 02
                mapLayer03 = "▒                                                                                                    ▒"; // 03
                mapLayer04 = "▒         ▒▒▒▒▒▒        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒            ▒▒▒▒▒▒        ▒▒▒▒▒▒▒         ▒▒▒▒▒▒        ▒"; // 04
                mapLayer05 = "▒         ▒▒▒▒▒▒        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒            ▒▒▒▒▒▒        ▒▒▒▒▒▒▒         ▒▒▒▒▒▒        ▒"; // 05
                mapLayer06 = "▒         ▒▒▒▒▒▒        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒            ▒▒▒▒▒▒        ▒▒▒▒▒▒▒         ▒▒▒▒▒▒        ▒"; // 06
                mapLayer07 = "▒                       ▒▒▒▒▒▒▒                                        ▒▒▒▒▒▒▒                       ▒"; // 07
                mapLayer08 = "▒                                                                                                    ▒"; // 08
                mapLayer09 = "▒░C░A░S░I░N░O░▒▒                                                                       ▒▒▒▒░B░A░R░▒▒▒▒"; // 09
                mapLayer10 = "▒              ▒                                                                       ▒             ▒"; // 10
                mapLayer11 = "▒  ▒   ▒   ▒   ▒                                                                       ▒             ▒"; // 11
                mapLayer12 = "▒                                                                                                 ▒▒▒▒"; // 12
                mapLayer13 = "▒  ▒   ▒   ▒                                                                                      ▒  ▒"; // 13
                mapLayer14 = "▒                                                                                                 ▒  ▒"; // 14
                mapLayer15 = "▒  ▒   ▒   ▒   ▒                                                                       ▒             ▒"; // 15
                mapLayer16 = "▒              ▒                                                                       ▒             ▒"; // 16
                mapLayer17 = "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                                                                       ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒"; // 17
                mapLayer18 = "▒                                                                                                    ▒"; // 18
                mapLayer19 = "▒                       ▒▒▒▒▒▒▒                                        ▒▒▒▒▒▒▒                       ▒"; // 19
                mapLayer20 = "▒         ▒▒▒▒▒▒        ▒▒▒▒▒▒▒                                        ▒▒▒▒▒▒▒         ▒▒▒▒▒▒        ▒"; // 20
                mapLayer21 = "▒         ▒▒▒▒▒▒        ▒▒▒▒▒▒▒                                        ▒▒▒▒▒▒▒         ▒▒▒▒▒▒        ▒"; // 21
                mapLayer22 = "▒         ▒▒▒▒▒▒        ▒▒▒▒▒▒▒                                        ▒▒▒▒▒▒▒         ▒▒▒▒▒▒        ▒"; // 22
                mapLayer23 = "▒                                                                                                    ▒"; // 23
                mapLayer24 = "▒                                                                                                    ▒"; // 24
                mapLayer25 = "▒                                                                                                    ▒"; // 25
                mapLayer26 = "▒▒▒▒▒▒░J░A░I░L░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░P░O░V░E░R░T░Y░▒▒▒▒"; // 26
                mapLayer27 = "▒                    ▒                                                          ▒                    ▒"; // 27
                mapLayer28 = "▒                    ▒                                                          ▒                    ▒"; // 28
                mapLayer29 = "▒                    ▒                                                          ▒                    ▒"; // 29
                mapLayer30 = "▒                    ▒                                                          ▒                    ▒"; // 30
                mapLayer31 = "▒                    ▒                                                          ▒                    ▒"; // 31
                mapLayer32 = "▒                    ▒                                                          ▒                    ▒"; // 32
                mapLayer33 = "▒                    ▒                                                          ▒                    ▒"; // 33
                mapLayer34 = "▒                    ▒                                                          ▒                    ▒"; // 34
                mapLayer35 = "▒                    ▒                                                          ▒                    ▒"; // 35
                mapLayer36 = "▒                    ▒                                                          ▒                    ▒"; // 36
                mapLayer37 = "▒                    ▒                                                          ▒                    ▒"; // 37
                mapLayer38 = "▒                    ▒                                                          ▒                    ▒"; // 38
                mapLayer39 = "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒"; // 39

            }

            List<string> layerList = new List<string>();
            layerList.Add(mapLayer00);
            layerList.Add(mapLayer01);
            layerList.Add(mapLayer02);
            layerList.Add(mapLayer03);
            layerList.Add(mapLayer04);
            layerList.Add(mapLayer05);
            layerList.Add(mapLayer06);
            layerList.Add(mapLayer07);
            layerList.Add(mapLayer08);
            layerList.Add(mapLayer09);
            layerList.Add(mapLayer10);
            layerList.Add(mapLayer11);
            layerList.Add(mapLayer12);
            layerList.Add(mapLayer13);
            layerList.Add(mapLayer14);
            layerList.Add(mapLayer15);
            layerList.Add(mapLayer16);
            layerList.Add(mapLayer17);
            layerList.Add(mapLayer18);
            layerList.Add(mapLayer19);
            layerList.Add(mapLayer20);
            layerList.Add(mapLayer21);
            layerList.Add(mapLayer22);
            layerList.Add(mapLayer23);
            layerList.Add(mapLayer24);
            layerList.Add(mapLayer25);
            layerList.Add(mapLayer26);
            layerList.Add(mapLayer27);
            layerList.Add(mapLayer28);
            layerList.Add(mapLayer29);
            layerList.Add(mapLayer30);
            layerList.Add(mapLayer31);
            layerList.Add(mapLayer32);
            layerList.Add(mapLayer33);
            layerList.Add(mapLayer34);
            layerList.Add(mapLayer35);
            layerList.Add(mapLayer36);
            layerList.Add(mapLayer37);
            layerList.Add(mapLayer38);
            layerList.Add(mapLayer39);


            int j = 0;
            foreach (var layer in layerList)
            {
                for (int i = 0; i < cityArray.GetLength(1); i++)
                {
                    cityArray[j, i, mapDepth - 1] = layer[i].ToString();
                }
                j++;
            }



            return cityArray;
        }
        //public static string[,,] PutPrisonOnLayer(int mapSizeY, int mapSizeX, int mapDepth, string[,,] prisonArray)
        //{
        //    // 
        //    string mapLayer00 = ""; string mapLayer01 = ""; string mapLayer02 = ""; string mapLayer03 = ""; string mapLayer04 = ""; string mapLayer05 = ""; 
        //    string mapLayer06 = ""; string mapLayer07 = ""; string mapLayer08 = ""; string mapLayer09 = "";
        //    //

        //    int prisonFilled = 0;

        //    if (prisonFilled == 0)
        //    {
        //        //           "123456789012345"
        //        mapLayer00 = "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒"; // 00
        //        mapLayer01 = "▒             ▒"; // 01
        //        mapLayer02 = "▒             ▒"; // 02
        //        mapLayer03 = "▒             ▒"; // 03
        //        mapLayer04 = "▒             ▒"; // 04
        //        mapLayer05 = "▒             ▒"; // 05
        //        mapLayer06 = "▒             ▒"; // 06
        //        mapLayer07 = "▒             ▒"; // 07
        //        mapLayer08 = "▒             ▒"; // 08
        //        mapLayer09 = "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒"; // 26
        //    }
        //    if (prisonFilled == 2)
        //    {
        //    }

        //    List<string> layerList = new List<string>();
        //    layerList.Add(mapLayer00);
        //    layerList.Add(mapLayer01);
        //    layerList.Add(mapLayer02);
        //    layerList.Add(mapLayer03);
        //    layerList.Add(mapLayer04);
        //    layerList.Add(mapLayer05);
        //    layerList.Add(mapLayer06);
        //    layerList.Add(mapLayer07);
        //    layerList.Add(mapLayer08);
        //    layerList.Add(mapLayer09);

        //    int j = 0;
        //    foreach (var layer in layerList)
        //    {
        //        for (int i = 0; i < prisonArray.GetLength(1); i++)
        //        {
        //            prisonArray[j, i, mapDepth - 1] = layer[i].ToString();
        //        }
        //        j++;
        //    }

        //    return prisonArray;
        //} 

         
    }
}


