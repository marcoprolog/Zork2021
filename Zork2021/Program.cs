using System;

namespace Zork2021
{
    class Program
    {
        static void Main(string[] args)
        {
            World world = new World();

            Console.WriteLine("Welcome to Zorkish!");
            while (true)
            {
                Console.WriteLine("You are in " +world.currentArea.name);
                Console.WriteLine("Enter a command");
                string command = Console.ReadLine(); //"go north"
                string[] commands = command.Split(' '); //["go", "north"]
                switch (commands[0])
                {
                    case "go":
                        // move the player to a different area
                        // your second argument is in commands[1]
                        switch (commands[1])
                        {
                            case "north":
                            case "n":
                                world.Go(Directions.North);
                                break;
                            case "east":
                            case "e":
                                world.Go(Directions.East);
                                break;
                            case "west":
                                world.Go(Directions.West);
                                break;
                            case "south":
                                world.Go(Directions.South);
                                break;
                            default:
                                Console.WriteLine("I didn't understand that");
                                break;
                        }
                        break;
                    case "examine":
                        // print the description of the current area
                        world.PrintCurrentAreaDescription();
                        break;
                    case "quit":
                        Environment.Exit(0); //the number is returned to the OS, usually 0 means the program exited without errors, while any other number highlights an error
                        break;
                    default:
                        Console.WriteLine("I didn't understand that");
                        break;
                }
            }
        }
    }
}
