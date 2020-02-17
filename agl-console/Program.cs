using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace agl_console
{
    class Program
    {
         
        private static async  Task<string> ProcessJson()
        {
            var stringTask = client.GetStringAsync("http://agl-developer-test.azurewebsites.net/people.json");

            var msg = await stringTask;
            Console.WriteLine(msg);
            return msg;
            
        }


        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            var processedMsg = await ProcessJson();
            var people = JsonSerializer.Deserialize<Person[]>(processedMsg);

            public override string ToString() { return Person "name:"  Person.name; }


            foreach(Person person in people)
            {
                Console.Write(person);
            }

        }
    }
}
