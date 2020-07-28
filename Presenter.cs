using System;
using System.Linq;
using Newtonsoft.Json;

namespace spacex
{
    class Presenter
    {
        public static void PresentResponse(string body, string[] args) {
            if (args.Contains("-p")) {
                var deserialized = JsonConvert.DeserializeObject(body);
                string json = JsonConvert.SerializeObject(deserialized, Formatting.Indented);
                Console.WriteLine(json);
            } else {
                Console.WriteLine(body);
            }

            
        }
    }
}
