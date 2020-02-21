using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;

namespace agl_console
{
    class Program
    {



        private static async  Task<string> ProcessJson()
        {
            var stringTask = client.GetStringAsync("http://agl-developer-test.azurewebsites.net/people.json");

            var msg = await stringTask;
          //  Console.WriteLine(msg);
            return msg;
            
        }


        private static readonly HttpClient client = new HttpClient();

     

        static async Task Main(string[] args)
        {

            List<Pet> Cats = new List<Pet>();

            var processedMsg = await ProcessJson();
            var people = JsonSerializer.Deserialize<Person[]>(processedMsg);


            foreach(Person person in people)
            {
                if (person.Pets != null)
                {
                    foreach (Pet pet in person.Pets)
                    {
                        if (pet != null && pet.Type == "Cat")
                        {
                        Console.WriteLine(pet.Name);

                        }

                    }
                }
              
                Console.WriteLine(person);
                   
            }

        }
    }
}
