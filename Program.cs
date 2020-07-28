using System;
using System.Threading.Tasks;


namespace spacex
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (args.Length < 1) {
                Console.WriteLine("Please specify at least one parameter.");
                Console.WriteLine("Type '-h' or '--help' to view arguments.");
            } else {
                string specifier = Handler.HandleArgs(args);
                if (specifier.Length > 0) {
                    string response = await Requestor.MakeRequest(specifier);
                    Presenter.PresentResponse(response, args);
                }
            }            
        }
    }
}
