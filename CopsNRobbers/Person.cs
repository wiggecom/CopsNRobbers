using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopsNRobbers
{
    public class Person
    {
        public int XPos { get; set; }
        public int YPos { get; set; }
        public int DPos { get; set; }
        public string Direction { get; set; }
        public virtual string Symbol { get; }
        public string Name { get; set; }

        //public string CollidesWith(Person person, Random rnd);
        //public List<string> Inventory { get; set; } = new List<string>();

        public Person(int xPos, int yPos, int dPos, string direction, string name)
        {
            XPos = xPos;
            YPos = yPos;
            DPos = dPos;
            Direction = direction;
            Symbol = "X";
            Name = name;

            //Inventory = new List<string>();

        }
        
        public static string[,,] CheckCollision(string[,,] cityMap, Person person)
        {
                if (cityMap[person.YPos, person.XPos, 1] != " ")
                {
                    // Met robber
                }

                if (cityMap[person.YPos, person.XPos, 0] != " ")
                {
                    // Met police
                }


            return cityMap;
        }
        public static string[,,] MovePeeps(string[,,] cityMap, List<Person> personsList)
        {
            int leftStartCentered = (Console.WindowWidth / 2) - (cityMap.GetLength(1) / 2);
            int topStartCentered = (Console.WindowHeight / 2) - (cityMap.GetLength(0) / 2);
            foreach (Citizen person in personsList.OfType<Citizen>())
            {
                cityMap = MoveDirection(cityMap, person);
                // -------------------------


                // CheckCollision(cityMap,person,personsList)


                // --------------------
            }
            //foreach (Thief person in personsList.OfType<Thief>())
            //{
            //    //foreach (Class1 c1 in AList.OfType<Class1>()) { }
            //    Console.SetCursorPosition(person.XPos + leftStartCentered, person.YPos - 1 + topStartCentered);
            //    Console.Write("#");
            //}
            //foreach (Police person in personsList.OfType<Police>())
            //{
            //    Console.SetCursorPosition(person.XPos + leftStartCentered, person.YPos - 1 + topStartCentered);
            //    Console.Write("+");
            //}

            /*
             * xPos, yPos, dPos, directionX, directionY, name
             * 
            Citizen citizen01 = new Citizen(5, 5, 2, 1, 1, "Greger-Dude");
            cityMap[citizen01.YPos, citizen01.XPos, citizen01.DPos] = citizen01.Symbol;

            Thief thief01 = new Thief(3, 4, 1, 2, 0, "Tjyv-Greger");
            cityMap[thief01.YPos, thief01.XPos, thief01.DPos] = thief01.Symbol;

            Police police01 = new Police(7, 2, 0, 1, 1, "Greger the Cop");
            cityMap[police01.YPos, police01.XPos, police01.DPos] = police01.Symbol;
             */


            return cityMap;
        }
        public static string[,,] MoveDirection(string[,,] cityMap, Person person)
        {
            bool okDir = false;
            int leftStartCentered = (Console.WindowWidth / 2) - (cityMap.GetLength(1) / 2);
            int topStartCentered = (Console.WindowHeight / 2) - (cityMap.GetLength(0) / 2);
            switch (person.Direction)
            {
                case "N":
                    okDir = CheckDirection(cityMap, person, okDir);
                    if (okDir == true)
                    {
                        cityMap[person.YPos, person.XPos, person.DPos] = " ";
                        Console.SetCursorPosition(person.XPos+leftStartCentered, person.YPos+topStartCentered);
                        Console.Write(" ");
                        person.YPos--;
                        cityMap[person.YPos, person.XPos, person.DPos] = person.Symbol;
                        Console.SetCursorPosition(person.XPos + leftStartCentered, person.YPos + topStartCentered);
                        Console.Write(person.Symbol);

                        okDir = false;
                    }
                    else
                    {
                        ChangeDirection(cityMap, person);
                    }
                    break;
                case "S":
                    okDir = CheckDirection(cityMap, person, okDir);
                    if (okDir == true)
                    {
                        cityMap[person.YPos, person.XPos, person.DPos] = " ";
                        Console.SetCursorPosition(person.XPos + leftStartCentered, person.YPos + topStartCentered);
                        Console.Write(" ");
                        person.YPos++;
                        cityMap[person.YPos, person.XPos, person.DPos] = person.Symbol;
                        Console.SetCursorPosition(person.XPos + leftStartCentered, person.YPos + topStartCentered);
                        Console.Write(person.Symbol);
                        okDir = false;
                    }
                    else
                    {
                        ChangeDirection(cityMap, person);
                    }
                    break;
                case "E":
                    break;
                case "W":
                    break;

                case "NE":
                    break;
                case "SE":
                    break;
                case "NW":
                    break;
                case "SW":
                    break;


                default: 
                    break;
            }
            return cityMap;
        }
        public static bool CheckDirection(string[,,] cityMap, Person person, bool okDir)
        {
            switch (person.Direction)
            {
                case "N":
                    if (person.YPos >= 1)
                    {
                        if (cityMap[person.YPos - 1, person.XPos, cityMap.GetLength(2) - 1] == " ")
                        {
                            okDir = true;
                        }
                    }
                    else
                    {

                        okDir=false;
                    }
                    break;
                case "S":
                    if (person.YPos <= cityMap.GetLength(0)-2)
                    {
                        if (cityMap[person.YPos + 1, person.XPos, cityMap.GetLength(2) - 1] == " ")
                        {
                            okDir = true;
                        }
                    }
                    else
                    {
                        okDir = false;
                    }
                    break;
                case "E":
                    break;
                case "W":
                    break;

                case "NE":
                    break;
                case "SE":
                    break;
                case "NW":
                    break;
                case "SW":
                    break;


                default:
                    break;
            }
            return okDir;
        }
        public static string[,,] ChangeDirection(string[,,] cityMap, Person person)
        {

            switch (person.Direction)
            {
                case "N":
                    break;
                case "S":
                    break;
                case "E":
                    break;
                case "W":
                    break;

                case "NE":
                    break;
                case "SE":
                    break;
                case "NW":
                    break;
                case "SW":
                    break;


                default:
                    break;
            }
            return cityMap;
        }

    }
}
