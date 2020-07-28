using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace spacex
{
    class Requestor
    {
        static readonly HttpClient client = new HttpClient();
        
        public static async Task<string> MakeRequest(string specifier) {
            try {
                HttpResponseMessage res = await client.GetAsync($"https://api.spacexdata.com/v4/{specifier}");
                res.EnsureSuccessStatusCode();
                string body = await res.Content.ReadAsStringAsync();
                return body;
            }
            catch (HttpRequestException e) {
                string errorString = $"Error processing request with error {e.Message}";
                Console.WriteLine(errorString);
                return "{}";
            }
        }
    }
}
