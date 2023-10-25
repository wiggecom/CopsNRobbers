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
        public string[,,] CityArray { get; set; }
        //private List<Person> people = new List<Person>();

        public City(int width, int heigth, int depth)
        {
            Height = heigth;
            Width = width;
            Depth = depth;
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

        public string[,,] FillCity(string[,,] cityMap)
        {
            int xInt = 0;
            for (int heightIndex = 0; heightIndex < Height; heightIndex++)
            {
                for (int widthIndex = 0; widthIndex < Width; widthIndex++)
                {
                    for (int depthIndex = 0; depthIndex < Depth; depthIndex++)
                    {
                        //// - Fill all strings with cell number from 2D array, on every layer of 3D array
                        //string xString = Convert.ToString(xInt);                                      //
                        //cityMap[heightIndex, widthIndex, depthIndex] = xString;                       //
                        //// -----------------------------------------------------------------------------
                        cityMap[heightIndex, widthIndex, depthIndex] = " ";    // nothing
                    }
                    xInt++;
                }
            }
            return cityMap;
        }
        public static void DrawCityFrame(string[,,] cityMap, int cityHeight, int cityWidth, int cityDepth) // To Bottom Layer
        {
            int leftStart = (Console.WindowWidth / 2) - (cityWidth / 2);
            int topStart = (Console.WindowHeight / 2) - (cityHeight / 2);
            int putLayer = cityMap.GetLength(2)-1; // Bottom Layer
            for (int i = 0; i < cityWidth; i++)
            {
                cityMap[0,i,putLayer] = "▒";
                //Console.SetCursorPosition(leftStart -1 + i, 0);
                //Console.Write("▒");
            }
            //for (int i = 0; i < cityHeight + 1; i++)
            //{
            //    Console.SetCursorPosition(0, i);
            //    Console.WriteLine("▒");
            //}

            //for (int i = 0; i < cityHeight + 1; i++)
            //{
            //    Console.SetCursorPosition(leftStart + cityWidth + 1, i);
            //    Console.Write("▒");
            //}
            //for (int i = 0; i < cityHeight; i++)
            //{
            //    cityMap[i, 0, putLayer] = "▒";
            //    //Console.SetCursorPosition(leftStart -1 + i, 0);
            //    //Console.Write("▒");
            //}

            //for (int i = 0; i < cityWidth; i++)
            //{
            //    cityMap[cityHeight, i, putLayer] = "▒";
            //    //Console.SetCursorPosition(leftStart -1 + i, 0);
            //    //Console.Write("▒");
            //}

        }
        public void DrawCity(string[,,] cityMap, int posLeft, int posTop)
        {
            //cityMap[1, 1, 5] = "O";
            //cityMap[2, 3, 3] = "X";
            //cityMap[5, 5, 2] = "O";
            int posLeftReset = posLeft;
            int posTopReset = posTop;
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
                        //for (int depthIndex = Depth-1; depthIndex >= 0; depthIndex--)
                        //{
                        //    //Console.Write(cityMap[heightIndex, widthIndex, depthIndex]);
                        //    //Console.Write(".");
                        //}
                        //Console.Write(cityMap[heightIndex, widthIndex,depthIndex].Remove(1));
                        //Console.Write(depthIndex);

                        if (cityMap[heightIndex, widthIndex, depthIndex] != " ")
                        {
                            Console.SetCursorPosition(widthIndex+posLeftReset, heightIndex + posTopReset);
                            //Console.Write(depthIndex);
                            Console.ForegroundColor = (ConsoleColor)depthIndex+1;
                            Console.Write(cityMap[heightIndex, widthIndex, depthIndex]);
                        }

                    }
                    Console.WriteLine();
                    posTop++;
                }
                //Console.ReadKey();
            }
        }
    }
}


