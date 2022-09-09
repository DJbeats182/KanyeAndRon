using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanyeAndRon
{
    internal class QuoteGenerator
    {
        public static void KanyeQuote()
        {
            var client = new HttpClient();
            var kanyeResponse = client.GetStringAsync("https://api.kanye.rest/").Result;
            var kanyeQuote = JObject.Parse(kanyeResponse);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Kanye:  '{kanyeQuote["quote"]}'");
            Console.WriteLine("---------------------------------------");

        }

        public static void RonQuote()
        {
            var client = new HttpClient();
            var ronResponse = client.GetStringAsync("https://ron-swanson-quotes.herokuapp.com/v2/quotes").Result;
            var ronQuote = JArray.Parse(ronResponse);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Ron:  '{ronQuote[0]}'");
            Console.WriteLine("---------------------------------------");
        }
    }
}
