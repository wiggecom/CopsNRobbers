using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
        public static string[,,] MovePeeps(string[,,] cityMap, List<Person> personsList, bool pacMan)
        {
            int leftStartCentered = (Console.WindowWidth / 2) - (cityMap.GetLength(1) / 2);
            int topStartCentered = (Console.WindowHeight / 2) - (cityMap.GetLength(0) / 2);
            foreach (Citizen person in personsList.OfType<Citizen>())
            {
                cityMap = MoveDirection(cityMap, person, pacMan);

            }
            foreach (Thief person in personsList.OfType<Thief>())
            {
                cityMap = MoveDirection(cityMap, person, pacMan);
            }
            foreach (Police person in personsList.OfType<Police>())
            {
                cityMap = MoveDirection(cityMap, person, pacMan);
            }

            return cityMap;
        }
        public static string[,,] MoveDirection(string[,,] cityMap, Person person, bool pacMan)
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
            //int leftStartCentered = (Console.WindowWidth / 2) - (cityMap.GetLength(1) / 2);
            // int topStartCentered = (Console.WindowHeight / 2) - (cityMap.GetLength(0) / 2);
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
                        ChangeDirection(cityMap, person, pacMan);
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
                        ChangeDirection(cityMap, person, pacMan);
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
                        ChangeDirection(cityMap, person, pacMan);
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
                        ChangeDirection(cityMap, person, pacMan);
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
                        ChangeDirection(cityMap, person, pacMan);
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
                        ChangeDirection(cityMap, person, pacMan);
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
                        ChangeDirection(cityMap, person, pacMan);
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
                        ChangeDirection(cityMap, person, pacMan);
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

            // Switch comment to change between set position or centered, here, in method Person.PlacePerson and Program.cs
            // int topStartCentered = (Console.WindowHeight / 2) - (cityMap.GetLength(0) / 2);
            int topStartCentered = 7;

            cityMap[person.YPos, person.XPos, person.DPos] = " ";
            Console.SetCursorPosition(person.XPos + leftStartCentered, person.YPos + topStartCentered);
            Console.Write(" ");
            return cityMap;
        }
        public static string[,,] PlacePerson(string[,,] cityMap, Person person)
        {
            int leftStartCentered = (Console.WindowWidth / 2) - (cityMap.GetLength(1) / 2);

            // Switch comment to change between set position or centered, here, in method Person.ClearPerson and Program.cs
            // int topStartCentered = (Console.WindowHeight / 2) - (cityMap.GetLength(0) / 2);
            int topStartCentered = 7;

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
        public static string[,,] ChangeDirection(string[,,] cityMap, Person person, bool pacMan)
        {
            //bool pacMan = true;
            int z = cityMap.GetLength(2) - 1;
            int x = person.XPos;
            int y = person.YPos;
            string[,] surroundings = new string[3, 3];

            surroundings[0, 0] = cityMap[y - 1, x - 1, z];
            surroundings[0, 1] = cityMap[y - 1, x, z];
            surroundings[0, 2] = cityMap[y - 1, x + 1, z];

            surroundings[1, 0] = cityMap[y, x - 1, z];
            surroundings[1, 2] = cityMap[y, x + 1, z];

            surroundings[2, 1] = cityMap[y + 1, x, z];
            surroundings[2, 2] = cityMap[y + 1, x + 1, z];
            surroundings[2, 0] = cityMap[y + 1, x - 1, z];

            surroundings[1, 1] = " "; // person position
            #region Scope
            //                                  --- Scope START --- "█▒▓ "
            int scopePosY = 0;
            int scopePosX = 5;
            Console.SetCursorPosition(0 + scopePosX, 0 + scopePosY);
            Console.Write("╔═════╗");
            Console.SetCursorPosition(0 + scopePosX, 1 + scopePosY);
            Console.Write("║CRASH║");
            Console.SetCursorPosition(0 + scopePosX, 2 + scopePosY);
            Console.Write("║SCOPE║");
            Console.SetCursorPosition(0 + scopePosX, 3 + scopePosY);
            Console.Write("╠═════╣");

            Console.SetCursorPosition(0 + scopePosX, 4 + scopePosY);
            Console.Write("║ "); // Edge
            Console.SetCursorPosition(2 + scopePosX, 4 + scopePosY);
            Console.Write(surroundings[0, 0]); // 1
            Console.SetCursorPosition(3 + scopePosX, 4 + scopePosY);
            Console.Write(surroundings[0, 1]); // 2
            Console.SetCursorPosition(4 + scopePosX, 4 + scopePosY);
            Console.Write(surroundings[0, 2]); // 3
            Console.SetCursorPosition(5 + scopePosX, 4 + scopePosY);
            Console.Write(" ║"); // Edge

            Console.SetCursorPosition(0 + scopePosX, 5 + scopePosY);
            Console.Write("║ "); // Edge
            Console.SetCursorPosition(2 + scopePosX, 5 + scopePosY);
            Console.Write(surroundings[1, 0]);
            Console.SetCursorPosition(3 + scopePosX, 5 + scopePosY);
            Console.Write("+");
            Console.SetCursorPosition(4 + scopePosX, 5 + scopePosY);
            Console.Write(surroundings[1, 2]);
            Console.SetCursorPosition(5 + scopePosX, 5 + scopePosY);
            Console.Write(" ║"); // Edge

            Console.SetCursorPosition(0 + scopePosX, 6 + scopePosY);
            Console.Write("║ "); // Edge
            Console.SetCursorPosition(2 + scopePosX, 6 + scopePosY);
            Console.Write(surroundings[2, 0]);
            Console.SetCursorPosition(3 + scopePosX, 6 + scopePosY);
            Console.Write(surroundings[2, 1]);
            Console.SetCursorPosition(4 + scopePosX, 6 + scopePosY);
            Console.Write(surroundings[2, 2]);
            Console.SetCursorPosition(5 + scopePosX, 6 + scopePosY);
            Console.Write(" ║"); // Edge

            Console.SetCursorPosition(0 + scopePosX, 7 + scopePosY);
            Console.Write("╚═════╝");

            //                                  --- Scope END ---
            #endregion
            int teleportSouth = 25;
            int teleportNorth = 1;
            int teleportWest = 1;
            int teleportEast = 100;
            int povertyNorth = 27;
            int povertySouth = 38;
            int povertyWest = 81;
            int povertyEast = 100;
            int prisonNorth = 27;
            int prisonSouth = 38;
            int prisonWest = 1;
            int prisonEast = 20;
            // int cityWidth = 102;
            // int cityHeight = 40;
            switch (person.Direction)
            {
                case "N":
                    if (pacMan == false) // sinCity.pacMan == false
                    {
                        person.Direction = "S";
                        person.YPos++; // South
                    }
                    else
                    {
                        if (person is Citizen && ((Citizen)person).Woke == true)
                        {
                            person.YPos = povertySouth;
                        }
                        else if (person is Thief && ((Thief)person).IsArrested == true)
                        {
                            person.YPos = prisonSouth;
                        }
                        else
                        {
                            person.YPos = teleportSouth;
                        }
                    }
                    break;
                case "S":
                    if (pacMan == false)
                    {
                        person.Direction = "N";
                        person.YPos--; // North
                    }
                    else
                    {
                        if (person is Citizen && ((Citizen)person).Woke == true)
                        {
                            person.YPos = povertyNorth;
                        }
                        else if (person is Thief && ((Thief)person).IsArrested == true)
                        {
                            person.YPos = prisonNorth;
                        }
                        else
                        {
                            person.YPos = teleportNorth;
                        }
                    }
                    break;
                case "E":
                    if (pacMan == false)
                    {
                        person.Direction = "W";
                        person.XPos--; // West
                    }
                    else
                    {
                        if (person is Citizen && ((Citizen)person).Woke == true)
                        {
                            person.YPos = povertyWest;
                        }
                        else if (person is Thief && ((Thief)person).IsArrested == true)
                        {
                            person.YPos = prisonWest;
                        }
                        else
                        {
                            person.YPos = teleportWest;
                        }
                    }

                    break;
                case "W":
                    if (pacMan == false)
                    {
                        person.Direction = "E";
                        person.XPos++; // East
                    }
                    else
                    {
                        if (person is Citizen && ((Citizen)person).Woke == true)
                        {
                            person.YPos = povertyEast;
                        }
                        else if (person is Thief && ((Thief)person).IsArrested == true)
                        {
                            person.YPos = prisonEast;
                        }
                        else
                        {
                            person.YPos = teleportEast;
                        }
                    }
                    break;

                case "NE":
                    if (pacMan == false)
                    {
                        if ((surroundings[0, 1] != " ") && (surroundings[0, 2] != " ") && (surroundings[1, 2] != " ")) // NE Corner filled 2,3,6
                        {
                            person.Direction = "SW";
                            person.YPos++; // South
                            person.XPos--; // West
                        }
                        else if ((surroundings[0, 1] == " ") && (surroundings[0, 2] != " ") && (surroundings[1, 2] == " ")) // NE Outside Corner filled 3
                        {
                            person.Direction = "SW";
                            person.YPos++; // South
                            person.XPos--; // West
                        }
                        else if ((surroundings[0, 1] != " ") && (surroundings[1, 2] == " ")) // Top filled, right unfilled
                        {
                            person.Direction = "SE";
                            person.YPos++; // South
                            person.XPos++; // East
                        }
                        else if ((surroundings[0, 1] == " ") && (surroundings[1, 2] != " ")) // Top unfilled, right filled
                        {
                            person.Direction = "NW";
                            person.YPos--; // North
                            person.XPos--; // West
                        }

                    }
                    else
                    {
                        if ((surroundings[0, 1] == " ") && (surroundings[0, 2] != " ") && (surroundings[1, 2] == " ")) // NE Corner filled 2,3,6
                        {
                            if (person is Citizen && ((Citizen)person).Woke == true)
                            {
                                person.YPos = povertySouth;
                                person.XPos = povertyWest;
                            }
                            else if (person is Thief && ((Thief)person).IsArrested == true)
                            {
                                person.YPos = prisonSouth;
                                person.XPos = prisonWest;
                            }
                            else
                            {
                                person.YPos = teleportSouth;
                                person.XPos = teleportWest;
                            }

                        }
                        else if ((surroundings[0, 1] != " ") && (surroundings[0, 2] != " ") && (surroundings[1, 2] != " ")) // NE Corner filled 2,3,6
                        {
                            if (person is Citizen && ((Citizen)person).Woke == true)
                            {
                                person.YPos = povertySouth;
                                person.XPos = povertyWest;
                            }
                            else if (person is Thief && ((Thief)person).IsArrested == true)
                            {
                                person.YPos = prisonSouth;
                                person.XPos = prisonWest;
                            }
                            else
                            {
                                person.YPos = teleportSouth;
                                person.XPos = teleportWest;
                            }
                        }
                        else if ((surroundings[0, 1] != " ") && (surroundings[1, 2] == " ")) // North filled, east unfilled
                        {
                            if (person is Citizen && ((Citizen)person).Woke == true)
                            {
                                person.YPos = povertySouth;
                            }
                            else if (person is Thief && ((Thief)person).IsArrested == true)
                            {
                                person.YPos = prisonSouth;
                            }
                            else
                            {
                                person.YPos = teleportSouth;
                            }
                        }
                        else if ((surroundings[0, 1] == " ") && (surroundings[1, 2] != " ")) // North unfilled, east filled
                        {
                            if (person is Citizen && ((Citizen)person).Woke == true)
                            {
                                person.XPos = povertyWest;
                            }
                            else if (person is Thief && ((Thief)person).IsArrested == true)
                            {
                                person.XPos = prisonWest;
                            }
                            else
                            {
                                person.XPos = teleportWest;
                            }
                        }
                    }
                    break; // OK!
                case "SE":
                    if (pacMan == false)
                    {
                        if ((surroundings[2, 1] != " ") && (surroundings[2, 2] != " ") && (surroundings[1, 2] != " ")) // SE Corner filled 8,9,6
                        {
                            person.Direction = "NW";
                            person.YPos--; // North
                            person.XPos--; // West
                        }
                        else if ((surroundings[2, 1] == " ") && (surroundings[2, 2] != " ") && (surroundings[1, 2] == " ")) // SE Outer Corner
                        {
                            person.Direction = "NW";
                            person.YPos--; // North
                            person.XPos--; // West
                        }
                        else if ((surroundings[2, 1] != " ") && (surroundings[1, 2] == " ")) // Bottom filled, right unfilled
                        {
                            person.Direction = "NE";
                            person.YPos--; // North
                            person.XPos++; // East
                        }
                        else if ((surroundings[2, 1] == " ") && (surroundings[1, 2] != " ")) // Bottom unfilled, right filled
                        {
                            person.Direction = "SW";
                            person.YPos++; // South
                            person.XPos--; // West
                        }

                    }
                    else
                    {
                        if ((surroundings[2, 1] != " ") && (surroundings[2, 2] != " ") && (surroundings[1, 2] != " ")) // SE Corner filled 8,9,6
                        {
                            if (person is Citizen && ((Citizen)person).Woke == true)
                            {
                                person.YPos = povertyNorth;
                                person.XPos = povertyWest;
                            }
                            else if (person is Thief && ((Thief)person).IsArrested == true)
                            {
                                person.YPos = prisonNorth;
                                person.XPos = prisonWest;
                            }
                            else
                            {
                                person.YPos = teleportNorth;
                                person.XPos = teleportWest;
                            }
                        }
                        else if ((surroundings[2, 1] == " ") && (surroundings[2, 2] != " ") && (surroundings[1, 2] == " ")) // SE Outer Corner
                        {
                            if (person is Citizen && ((Citizen)person).Woke == true)
                            {
                                person.YPos = povertyNorth;
                                person.XPos = povertyWest;
                            }
                            else if (person is Thief && ((Thief)person).IsArrested == true)
                            {
                                person.YPos = prisonNorth;
                                person.XPos = prisonWest;
                            }
                            else
                            {
                                person.YPos = teleportNorth;
                                person.XPos = teleportWest;
                            }
                        }
                        else if ((surroundings[2, 1] != " ") && (surroundings[1, 2] == " ")) // South filled, East unfilled
                        {
                            if (person is Citizen && ((Citizen)person).Woke == true)
                            {
                                person.YPos = povertyNorth;
                            }
                            else if (person is Thief && ((Thief)person).IsArrested == true)
                            {
                                person.YPos = prisonNorth;
                            }
                            else
                            {
                                person.YPos = teleportNorth;
                            }
                        }
                        else if ((surroundings[2, 1] == " ") && (surroundings[1, 2] != " ")) // South unfilled, East filled
                        {
                            if (person is Citizen && ((Citizen)person).Woke == true)
                            {
                                person.XPos = povertyWest;
                            }
                            else if (person is Thief && ((Thief)person).IsArrested == true)
                            {
                                person.XPos = prisonWest;
                            }
                            else
                            {
                                person.XPos = teleportWest;
                            }
                        }
                    }
                    break; // OK
                case "NW":
                    if (pacMan == false)
                    {
                        if ((surroundings[0, 0] != " ") && (surroundings[0, 1] != " ") && (surroundings[1, 0] != " ")) // NE Corner filled 1,2,4
                        {
                            person.Direction = "SE";
                            person.YPos++; // South
                            person.XPos++; // East
                        }
                        else if ((surroundings[0, 0] != " ") && (surroundings[0, 1] == " ") && (surroundings[1, 0] == " ")) // NE Corner filled 1,2,4
                        {
                            person.Direction = "SE";
                            person.YPos++; // South
                            person.XPos++; // East
                        }
                        else if ((surroundings[0, 1] != " ") && (surroundings[1, 0] == " ")) // North filled, west unfilled
                        {
                            person.Direction = "SW";
                            person.YPos++; // South
                            person.XPos--; // West
                        }
                        else if ((surroundings[0, 1] == " ") && (surroundings[1, 0] != " ")) // North unfilled, west filled
                        {
                            person.Direction = "NE";
                            person.YPos--; // North
                            person.XPos++; // East
                        }

                    }
                    else
                    {
                        if ((surroundings[0, 0] != " ") && (surroundings[0, 1] != " ") && (surroundings[1, 0] != " ")) // NW Corner filled 1,2,4
                        {
                            if (person is Citizen && ((Citizen)person).Woke == true)
                            {
                                person.YPos = povertySouth;
                                person.XPos = povertyEast;
                            }
                            else if (person is Thief && ((Thief)person).IsArrested == true)
                            {
                                person.YPos = prisonSouth;
                                person.XPos = prisonEast;
                            }
                            else
                            {
                                person.YPos = teleportSouth;
                                person.XPos = teleportEast;
                            }
                        }
                        else if ((surroundings[0, 0] != " ") && (surroundings[0, 1] == " ") && (surroundings[1, 0] == " ")) // NW Corner filled 1,2,4
                        {
                            if (person is Citizen && ((Citizen)person).Woke == true)
                            {
                                person.YPos = povertySouth;
                                person.XPos = povertyEast;
                            }
                            else if (person is Thief && ((Thief)person).IsArrested == true)
                            {
                                person.YPos = prisonSouth;
                                person.XPos = prisonEast;
                            }
                            else
                            {
                                person.YPos = teleportSouth;
                                person.XPos = teleportEast;
                            }
                        }
                        else if ((surroundings[0, 1] != " ") && (surroundings[1, 0] == " ")) // North filled, west unfilled
                        {
                            if (person is Citizen && ((Citizen)person).Woke == true)
                            {
                                person.YPos = povertySouth;
                            }
                            else if (person is Thief && ((Thief)person).IsArrested == true)
                            {
                                person.YPos = prisonSouth;
                            }
                            else
                            {
                                person.YPos = teleportSouth;
                            }
                        }
                        else if ((surroundings[0, 1] == " ") && (surroundings[1, 0] != " ")) // North unfilled, west filled
                        {
                            if (person is Citizen && ((Citizen)person).Woke == true)
                            {
                                person.XPos = povertyEast;
                            }
                            else if (person is Thief && ((Thief)person).IsArrested == true)
                            {
                                person.XPos = prisonEast;
                            }
                            else
                            {
                                person.XPos = teleportEast;
                            }
                        }
                    }
                    break;
                case "SW":
                    if (pacMan == false)
                    {
                        if ((surroundings[2, 0] != " ") && (surroundings[2, 1] != " ") && (surroundings[1, 0] != " ")) // SW Corner filled 7,8,4
                        {
                            person.Direction = "NE";
                            person.YPos--; // North
                            person.XPos++; // East
                        }
                        else if ((surroundings[2, 0] != " ") && (surroundings[2, 1] == " ") && (surroundings[1, 0] == " ")) // SW Outer Corner filled 7,8,4
                        {
                            person.Direction = "NE";
                            person.YPos--; // North
                            person.XPos++; // East
                        }
                        else if ((surroundings[2, 1] != " ") && (surroundings[1, 0] == " ")) // South filled, west unfilled
                        {
                            person.Direction = "NW";
                            person.YPos--; // North
                            person.XPos--; // West
                        }
                        else if ((surroundings[2, 1] == " ") && (surroundings[1, 0] != " ")) // South unfilled, west filled
                        {
                            person.Direction = "SE";
                            person.YPos++; // South
                            person.XPos++; // East
                        }

                    }
                    else
                    {
                        if ((surroundings[2, 0] != " ") && (surroundings[2, 1] != " ") && (surroundings[1, 0] != " ")) // SW Corner filled 7,8,4
                        {
                            if (person is Citizen && ((Citizen)person).Woke == true)
                            {
                                person.YPos = povertyNorth;
                                person.XPos = povertyEast;
                            }
                            else if (person is Thief && ((Thief)person).IsArrested == true)
                            {
                                person.YPos = prisonNorth;
                                person.XPos = prisonEast;
                            }
                            else
                            {
                                person.YPos = teleportNorth;
                                person.XPos = teleportEast;
                            }
                        }
                        else if ((surroundings[2, 0] != " ") && (surroundings[2, 1] == " ") && (surroundings[1, 0] == " ")) // SW Outer Corner filled 7,8,4
                        {
                            if (person is Citizen && ((Citizen)person).Woke == true)
                            {
                                person.YPos = povertyNorth;
                                person.XPos = povertyEast;
                            }
                            else if (person is Thief && ((Thief)person).IsArrested == true)
                            {
                                person.YPos = prisonNorth;
                                person.XPos = prisonEast;
                            }
                            else
                            {
                                person.YPos = teleportNorth;
                                person.XPos = teleportEast;
                            }
                        }
                        else if ((surroundings[2, 1] != " ") && (surroundings[1, 0] == " ")) // South filled, west unfilled
                        {
                            if (person is Citizen && ((Citizen)person).Woke == true)
                            {
                                person.YPos = povertyNorth;
                            }
                            else if (person is Thief && ((Thief)person).IsArrested == true)
                            {
                                person.YPos = prisonNorth;
                            }
                            else
                            {
                                person.YPos = teleportNorth;
                            }
                        }
                        else if ((surroundings[2, 1] == " ") && (surroundings[1, 0] != " ")) // South unfilled, west filled
                        {
                            if (person is Citizen && ((Citizen)person).Woke == true)
                            {
                                person.XPos = povertyEast;
                            }
                            else if (person is Thief && ((Thief)person).IsArrested == true)
                            {
                                person.XPos = prisonEast;
                            }
                            else
                            {
                                person.XPos = teleportEast;
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
            return cityMap;
        } // Set pacMan to toggle bounce-style or Pac Man-teleport
    }
}
