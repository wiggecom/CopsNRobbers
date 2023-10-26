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
        //private List<Person> people = new List<Person>();

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
        //public static void PutCityFrame(string[,,] cityMap, int cityHeight, int cityWidth, int cityDepth) // To Bottom Layer
        //{
        //    int leftStart = (Console.WindowWidth / 2) - (cityWidth / 2);
        //    int topStart = (Console.WindowHeight / 2) - (cityHeight / 2);
        //    int putLayer = cityMap.GetLength(2) - 1; // Bottom Layer

        //    for (int i = 0; i < cityWidth; i++)
        //    {
        //        cityMap[0, i, putLayer] = "▒";
        //    }
        //    for (int i = 0; i < cityHeight; i++)
        //    {
        //        cityMap[i, 0, putLayer] = "▒";
        //    }
        //    for (int i = 0; i < cityHeight; i++)
        //    {
        //        cityMap[i, cityMap.GetLength(1) - 1, putLayer] = "▒";
        //    }
        //    for (int i = 0; i < cityWidth; i++)
        //    {
        //        cityMap[cityHeight - 1, i, putLayer] = "▒";
        //    }
        //}
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
        }
        public static string[,,] PutMapOnLayer(int mapSizeY, int mapSizeX, int mapDepth, string[,,] cityArray)
        {
            string mapLayer00 = ""; // 00
            string mapLayer01 = ""; // 01
            string mapLayer02 = ""; // 02
            string mapLayer03 = ""; // 03
            string mapLayer04 = ""; // 04
            string mapLayer05 = ""; // 05
            string mapLayer06 = ""; // 06
            string mapLayer07 = ""; // 07
            string mapLayer08 = ""; // 08
            string mapLayer09 = ""; // 09
            string mapLayer10 = ""; // 10
            string mapLayer11 = ""; // 11
            string mapLayer12 = ""; // 12
            string mapLayer13 = ""; // 13
            string mapLayer14 = ""; // 14
            string mapLayer15 = ""; // 15
            string mapLayer16 = ""; // 16
            string mapLayer17 = ""; // 17
            string mapLayer18 = ""; // 18
            string mapLayer19 = ""; // 19
            string mapLayer20 = ""; // 20
            string mapLayer21 = ""; // 21
            string mapLayer22 = ""; // 22
            string mapLayer23 = ""; // 23
            string mapLayer24 = ""; // 24
            string mapLayer25 = ""; // 25
            string mapLayer26 = ""; // 26
            int cityFilled = 1;

            if (cityFilled == 0)
            {
                mapLayer00 = "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒"; // 00
                mapLayer01 = "▒                                                                                                    ▒"; // 01
                mapLayer02 = "▒                                                                                                    ▒"; // 02
                mapLayer03 = "▒                                                                                                    ▒"; // 03
                mapLayer04 = "▒                                                                                                    ▒"; // 04
                mapLayer05 = "▒                                                                                                    ▒"; // 05
                mapLayer06 = "▒                                                  ▒▒▒▒▒▒▒▒                                          ▒"; // 06
                mapLayer07 = "▒                                                                                                    ▒"; // 07
                mapLayer08 = "▒                                                                                                    ▒"; // 08
                mapLayer09 = "▒                                                                                                    ▒"; // 09
                mapLayer10 = "▒                                                                                                    ▒"; // 10
                mapLayer11 = "▒                ▒                                     ▒                                             ▒"; // 11
                mapLayer12 = "▒                ▒                                     ▒                                             ▒"; // 12
                mapLayer13 = "▒                ▒                                     ▒                                             ▒"; // 13
                mapLayer14 = "▒                ▒                                     ▒                                             ▒"; // 14
                mapLayer15 = "▒                ▒                                     ▒                                             ▒"; // 15
                mapLayer16 = "▒                                                                                                    ▒"; // 16
                mapLayer17 = "▒                                                                                                    ▒"; // 17
                mapLayer18 = "▒                                                                                                    ▒"; // 18
                mapLayer19 = "▒                                                                                                    ▒"; // 19
                mapLayer20 = "▒                                      ▒▒▒▒▒▒                                                        ▒"; // 20
                mapLayer21 = "▒                                                                                                    ▒"; // 21
                mapLayer22 = "▒                                                                                                    ▒"; // 22
                mapLayer23 = "▒                                                                                                    ▒"; // 23
                mapLayer24 = "▒                                                                                                    ▒"; // 24
                mapLayer25 = "▒                                                                                                    ▒"; // 25
                mapLayer26 = "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒"; // 26
            }
            if (cityFilled == 1)
            {
                mapLayer00 = "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒POLICE-STATION▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒"; // 00
                mapLayer01 = "▒                                          ▒              ▒                                          ▒"; // 01
                mapLayer02 = "▒                                          ▒              ▒                                          ▒"; // 02
                mapLayer03 = "▒                                          ▒              ▒                                          ▒"; // 03
                mapLayer04 = "▒        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒            ▒              ▒            ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒        ▒"; // 04
                mapLayer05 = "▒        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒            ▒▒▒▒▒▒▒--▒▒▒▒▒▒▒            ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒        ▒"; // 05
                mapLayer06 = "▒        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒                                        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒        ▒"; // 06
                mapLayer07 = "▒        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒                                        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒        ▒"; // 07
                mapLayer08 = "▒                                                                                                    ▒"; // 08
                mapLayer09 = "▒                                                                                                    ▒"; // 09
                mapLayer10 = "▒                                                                                                    ▒"; // 10
                mapLayer11 = "▒        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒                                        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒        ▒"; // 11
                mapLayer12 = "▒        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒                                        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒        ▒"; // 12
                mapLayer13 = "▒        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒                                        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒        ▒"; // 13
                mapLayer14 = "▒        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒                                        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒        ▒"; // 14
                mapLayer15 = "▒        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒                                        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒        ▒"; // 15
                mapLayer16 = "▒                                                                                                    ▒"; // 16
                mapLayer17 = "▒                                                                                                    ▒"; // 17
                mapLayer18 = "▒                                                                                                    ▒"; // 18
                mapLayer19 = "▒        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒         ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒         ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒        ▒"; // 19
                mapLayer20 = "▒        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒         ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒         ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒        ▒"; // 20
                mapLayer21 = "▒        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒         ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒         ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒        ▒"; // 21
                mapLayer22 = "▒        ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒         ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒         ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒        ▒"; // 22
                mapLayer23 = "▒                                                                                                    ▒"; // 23
                mapLayer24 = "▒                                                                                                    ▒"; // 24
                mapLayer25 = "▒                                                                                                    ▒"; // 25
                mapLayer26 = "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒"; // 26
            }

            if (cityFilled == 2)
            {
                mapLayer00 = "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒"; // 00
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
                mapLayer26 = "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒"; // 26
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

            int j = 0;
            foreach (var layer in layerList)
            {
                for (int i = 0; i < cityArray.GetLength(1); i++)
                {
                    cityArray[j, i, mapDepth - 1] = layer[i].ToString();
                }
                j++;
            }


            /*
            "         1         2         3         4         5         6         7         8         9         0", "█▒▓",
            "▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓", // 00
            "▓                                                                                                  ▓", // 01
            "▓                                                                                                  ▓", // 02
            "▓                                                                                                  ▓", // 03
            "▓                                                                                                  ▓", // 04
            "▓                                                                                                  ▓", // 05
            "▓                                                                                                  ▓", // 06
            "▓                                                                                                  ▓", // 07
            "▓                                                                                                  ▓", // 08
            "▓                                                                                                  ▓", // 09
            "▓                                                                                                  ▓", // 10
            "▓                                                                                                  ▓", // 11
            "▓                                                                                                  ▓", // 12
            "▓                                                                                                  ▓", // 13
            "▓                                                                                                  ▓", // 14
            "▓                                                                                                  ▓", // 15
            "▓                                                                                                  ▓", // 10
            "▓                                                                                                  ▓", // 11
            "▓                                                                                                  ▓", // 12
            "▓                                                                                                  ▓", // 13
            "▓                                                                                                  ▓", // 14
            "▓                                                                                                  ▓", // 15
            "▓                                                                                                  ▓", // 16
            "▓                                                                                                  ▓", // 17
            "▓                                                                                                  ▓", // 18
            "▓                                                                                                  ▓", // 19
            "▓                                                                                                  ▓", // 20
            "▓                                                                                                  ▓", // 21
            "▓                                                                                                  ▓", // 22
            "▓                                                                                                  ▓", // 23
            "▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓"  // 24
            */


            return cityArray;
        } // toggle cityFilled to fill or clear map

    }
}


