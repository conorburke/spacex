using System;
using System.Linq;

namespace spacex
{
    class Handler
    {   
        private static string specifiers = String.Join(
                        Environment.NewLine,
                        "Capsules",
                        "Company",
                        "Core",
                        "Crew",
                        "Dragons",
                        "Landpads",
                        "Launches",
                        "Launchpads",
                        "Payloads",
                        "Roadster",
                        "Rockets",
                        "Ships",
                        "Starlink"
                    );
        public static string HandleArgs(string[] args) {
            if (args.Contains("-h") || args.Contains("--help")) {
                Console.WriteLine("SpaceX API CLI.");
                Console.WriteLine("You can view info on Capsules, Launches, Rockets and more.");
                Console.WriteLine("Specify which info you would like to see as such:");
                Console.WriteLine("-t capsules");
                Console.WriteLine("This will give a JSON response with all Capsule information");
                Console.WriteLine("Be sure to have the type specified directly after the '-t' flag.");
                Console.WriteLine("Use '-l' to get a list of available type specifiers.");
                Console.WriteLine("Use '-p' to have the JSON response pretty printed");
                return "";
            }

            if (args.Contains("-l")) {
                Console.WriteLine("The availabe types are:");
                Console.WriteLine(specifiers);
                return "";
            }

            if (args.Contains("-t")) {
                int tpos = Array.IndexOf(args, "-t");
                if (args.Length > tpos + 1) {
                    if (args[tpos + 1].Contains("-")) {
                        Console.WriteLine("Please specify one of the following types right after the '-t' flag:");
                        Console.WriteLine(specifiers);
                        return "";
                    }
                    return args[tpos + 1];
                } 
                Console.WriteLine("Please specify one of the following types right after the '-t' flag:");
                Console.WriteLine(specifiers);
            }

            Console.WriteLine("SpaceX API ClI. Type -h or --help for more info.");
            return "";
        }
    }
}
