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
            int[] professionColor = new int[3];
            professionColor[0] = 3;  // DarkCyan - Police
            professionColor[1] = 12; // Red      - Thief
            professionColor[2] = 10; // Green   - Citizen
            switch (person.DPos)
            {
                case 0:
                    Console.ForegroundColor = (ConsoleColor)professionColor[0];
                    break;
                case 1:
                    Console.ForegroundColor = (ConsoleColor)professionColor[1];
                    break;
                case 2:
                    Console.ForegroundColor = (ConsoleColor)professionColor[2];
                    break;
            }

            bool okDir = false;
            int leftStartCentered = (Console.WindowWidth / 2) - (cityMap.GetLength(1) / 2);
            int topStartCentered = (Console.WindowHeight / 2) - (cityMap.GetLength(0) / 2);
            switch (person.Direction)
            {
                case "N":
                    okDir = CheckDirection(cityMap, person, okDir);
                    if (okDir == true)
                    {
                        ClearPerson(cityMap, person);
                        person.YPos--;
                        PlacePerson(cityMap, person);
                        okDir = false;
                    }
                    else
                    {
                        ClearPerson(cityMap, person);
                        ChangeDirection(cityMap, person);
                        PlacePerson(cityMap, person);
                    }
                    break; // OK
                case "S":
                    okDir = CheckDirection(cityMap, person, okDir);
                    if (okDir == true)
                    {
                        ClearPerson(cityMap, person);
                        person.YPos++;
                        PlacePerson(cityMap, person);
                        okDir = false;
                    }
                    else
                    {
                        ClearPerson(cityMap, person);
                        ChangeDirection(cityMap, person);
                        PlacePerson(cityMap, person);
                    }
                    break; // OK
                case "E":
                    okDir = CheckDirection(cityMap, person, okDir);
                    if (okDir == true)
                    {
                        ClearPerson(cityMap, person);
                        person.XPos++;
                        PlacePerson(cityMap, person);
                        okDir = false;
                    }
                    else
                    {
                        ClearPerson(cityMap, person);
                        ChangeDirection(cityMap, person);
                        PlacePerson(cityMap, person);
                    }
                    break; // OK
                case "W":
                    okDir = CheckDirection(cityMap, person, okDir);
                    if (okDir == true)
                    {
                        ClearPerson(cityMap, person);
                        person.XPos--;
                        PlacePerson(cityMap, person);
                        okDir = false;
                    }
                    else
                    {
                        ClearPerson(cityMap, person);
                        ChangeDirection(cityMap, person);
                        PlacePerson(cityMap, person);
                    }
                    break; // OK
                // ------------------------------ DIAGONALS START ----------------------------
                case "NE":
                    okDir = CheckDirection(cityMap, person, okDir);
                    if (okDir == true)
                    {
                        ClearPerson(cityMap, person);
                        person.YPos--; // N
                        person.XPos++; // E

                        PlacePerson(cityMap, person);

                        okDir = false;
                    }
                    else
                    {
                        ClearPerson(cityMap, person);
                        ChangeDirection(cityMap, person);
                        PlacePerson(cityMap, person);
                    }
                    break; // OK
                case "SE":
                    okDir = CheckDirection(cityMap, person, okDir);
                    if (okDir == true)
                    {
                        ClearPerson(cityMap, person);
                        person.YPos++; // S
                        person.XPos++; // E
                        PlacePerson(cityMap, person);

                        okDir = false;
                    }
                    else
                    {
                        ClearPerson(cityMap, person);
                        ChangeDirection(cityMap, person);
                        PlacePerson(cityMap, person);
                    }
                    break; // OK
                case "NW":
                    okDir = CheckDirection(cityMap, person, okDir);
                    if (okDir == true)
                    {
                        ClearPerson(cityMap, person);
                        person.YPos--; // N
                        person.XPos--; // W
                        PlacePerson(cityMap, person);

                        okDir = false;
                    }
                    else
                    {
                        ClearPerson(cityMap, person);
                        ChangeDirection(cityMap, person);
                        PlacePerson(cityMap, person);
                    }
                    break; // OK
                case "SW":
                    okDir = CheckDirection(cityMap, person, okDir);
                    if (okDir == true)
                    {
                        ClearPerson(cityMap, person);
                        person.YPos++; // S
                        person.XPos--; // W

                        PlacePerson(cityMap, person);

                        okDir = false;
                    }
                    else
                    {
                        ClearPerson(cityMap, person);
                        ChangeDirection(cityMap, person);
                        PlacePerson(cityMap, person);

                    }
                    break; // OK
                // ------------------------------ DIAGONALS END ------------------------------

                default:
                    break;
            }
            return cityMap;
        }
        public static string[,,] ClearPerson(string[,,] cityMap, Person person)
        {
            int leftStartCentered = (Console.WindowWidth / 2) - (cityMap.GetLength(1) / 2);
            int topStartCentered = (Console.WindowHeight / 2) - (cityMap.GetLength(0) / 2);
            cityMap[person.YPos, person.XPos, person.DPos] = " ";
            Console.SetCursorPosition(person.XPos + leftStartCentered, person.YPos + topStartCentered);
            Console.Write(" ");
            return cityMap;
        }
        public static string[,,] PlacePerson(string[,,] cityMap, Person person)
        {
            int leftStartCentered = (Console.WindowWidth / 2) - (cityMap.GetLength(1) / 2);
            int topStartCentered = (Console.WindowHeight / 2) - (cityMap.GetLength(0) / 2);
            cityMap[person.YPos, person.XPos, person.DPos] = person.Symbol;
            Console.SetCursorPosition(person.XPos + leftStartCentered, person.YPos + topStartCentered);
            Console.Write(person.Symbol);
            return cityMap;
        }
        public static bool CheckDirection(string[,,] cityMap, Person person, bool okDir)
        {
            switch (person.Direction)
            {
                case "N":
                    if (cityMap[person.YPos - 1, person.XPos, cityMap.GetLength(2) - 1] == " ")
                    {
                        okDir = true;
                    }
                    else
                    {

                        okDir = false;
                    }
                    break; // OK
                case "S":
                    if (cityMap[person.YPos + 1, person.XPos, cityMap.GetLength(2) - 1] == " ")
                    {
                        okDir = true;
                    }
                    else
                    {
                        okDir = false;
                    }
                    break; // OK
                case "E":
                    if (cityMap[person.YPos, person.XPos + 1, cityMap.GetLength(2) - 1] == " ")
                    {
                        okDir = true;
                    }
                    else
                    {
                        okDir = false;
                    }
                    break; // OK
                case "W":
                    if (cityMap[person.YPos, person.XPos - 1, cityMap.GetLength(2) - 1] == " ")
                    {
                        okDir = true;
                    }
                    else
                    {
                        okDir = false;
                    }
                    break; // OK
                case "NE":

                    if (cityMap[person.YPos - 1, person.XPos + 1, cityMap.GetLength(2) - 1] == " ")
                    {
                        okDir = true;
                    }
                    else
                    {
                        okDir = false;
                    }
                    break;
                case "SE":
                    if (cityMap[person.YPos + 1, person.XPos + 1, cityMap.GetLength(2) - 1] == " ")
                    {
                        okDir = true;
                    }
                    else
                    {
                        okDir = false;
                    }
                    break;
                case "NW":
                    if (cityMap[person.YPos - 1, person.XPos - 1, cityMap.GetLength(2) - 1] == " ")
                    {
                        okDir = true;
                    }
                    else
                    {
                        okDir = false;
                    }
                    break;
                case "SW":
                    if (cityMap[person.YPos + 1, person.XPos - 1, cityMap.GetLength(2) - 1] == " ")
                    {
                        okDir = true;
                    }
                    else
                    {
                        okDir = false;
                    }
                    break;
                default:
                    break;
            }
            return okDir;
        }
        public static bool CheckDirectionBackupOnlyBoundary(string[,,] cityMap, Person person, bool okDir)
            {
            //    switch (person.Direction)
            //    {
            //        case "N":
            //            if (person.YPos >= 1)
            //            {
            //                okDir = true;
            //            }
            //            else
            //            {

            //                okDir = false;
            //            }
            //            break; // OK
            //        case "S":
            //            if (cityMap[person.YPos + 1, person.XPos, cityMap.GetLength(2) - 1] == " ")
            //            {
            //                okDir = true;
            //            }
            //            else
            //            {
            //                okDir = false;
            //            }
            //            break; // OK
            //        case "E":
            //            if (cityMap[person.YPos, person.XPos + 1, cityMap.GetLength(2) - 1] == " ")
            //            {
            //                okDir = true;
            //            }
            //            else
            //            {
            //                okDir = false;
            //            }
            //            break; // OK
            //        case "W":
            //            if (person.XPos >= 1)
            //            {
            //                okDir = true;
            //            }
            //            else
            //            {
            //                okDir = false;
            //            }
            //            break; // OK

            //        case "NE":
            //            if ((person.YPos >= 1) && (person.XPos <= cityMap.GetLength(1) - 2))
            //            {
            //                okDir = true;
            //            }
            //            else
            //            {
            //                okDir = false;
            //            }
            //            break;
            //        case "SE":
            //            if ((person.YPos <= cityMap.GetLength(0) - 2) && (person.XPos <= cityMap.GetLength(1) - 2))
            //            {
            //                okDir = true;
            //            }
            //            else
            //            {
            //                okDir = false;
            //            }
            //            break;
            //        case "NW":
            //            if ((person.YPos >= 1) && (person.XPos >= 1))
            //            {
            //                okDir = true;
            //            }
            //            else
            //            {
            //                okDir = false;
            //            }
            //            break;
            //        case "SW":
            //            if ((person.YPos <= cityMap.GetLength(0) - 2) && (person.XPos >= 1))
            //            {
            //                okDir = true;
            //            }
            //            else
            //            {
            //                okDir = false;
            //            }
            //            break;


            //        default:
            //            break;
            //    }
            return okDir;
        }
            public static string[,,] ChangeDirection(string[,,] cityMap, Person person)
        {
            bool pacMan = false; // Toggle to switch between Pac Man-style portal and Bounce
            int z = cityMap.GetLength(2) - 1;
            int x = person.XPos;
            int y = person.YPos;
            string[,] surroundings = new string[3, 3];
            Console.SetCursorPosition(50, 1);
            Console.Write("X: " + x + "   Y: " + y + "   Z: " + z);
            //surroundings[0, 0] = cityMap[x - 1, y - 1, z];
            //surroundings[0, 1] = cityMap[x    , y - 1, z];
            //surroundings[0, 2] = cityMap[x + 1, y - 1, z];

            //surroundings[1, 0] = cityMap[x - 1, y    , z];
            //surroundings[1, 1] =                            " "; // person position
            //surroundings[1, 2] = cityMap[x + 1, y    , z];

            //surroundings[2, 0] = cityMap[x - 1, y + 1, z];
            //surroundings[2, 1] = cityMap[x    , y + 1, z];
            //surroundings[2, 2] = cityMap[x + 1, y + 1, z];

            int teleportDown = cityMap.GetLength(0) - 2;
            int teleportUp = 1;
            int teleportLeft = 1; 
            int teleportRight = cityMap.GetLength(1) - 2;
            switch (person.Direction)
            {
                case "N":
                    if (pacMan == false)
                    {
                        person.Direction = "S";
                    }
                    else
                    {
                        person.YPos = teleportDown;
                    }
                    break;
                case "S":
                    if (pacMan == false)
                    {
                        person.Direction = "N";
                    }
                    else
                    {
                        person.YPos = teleportUp;
                    }
                    break;
                case "E":
                    if (pacMan == false)
                    {
                        person.Direction = "W";
                    }
                    else
                    {
                        person.XPos = teleportLeft;
                    }
                    break;
                case "W":
                    if (pacMan == false)
                    {
                        person.Direction = "E";
                    }
                    else
                    {
                        person.XPos = teleportRight;
                    }
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
