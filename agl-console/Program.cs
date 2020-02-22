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
            return msg;
            
        }

        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            var processedMsg = await ProcessJson();
            var people = JsonSerializer.Deserialize<Person[]>(processedMsg);

            IEnumerable<Person> female = people.Where(people => people.Gender == "Female");
            IEnumerable<Person> male = people.Where(people => people.Gender == "Male");

            List<string> FemCats = new List<string>();
            List<string> MaleCats = new List<string>();


            foreach (Person chick in female)
            {
                if (chick.Pets != null)
                {
                    foreach(Pet pet in chick.Pets)
                    {
                        if(pet.Type == "Cat"){
                            FemCats.Add(pet.Name);
                        }
                    }
                }
            }

            foreach (Person dude in male)
            {
                if (dude.Pets != null)
                {
                    foreach (Pet pet in dude.Pets)
                    {
                        if (pet.Type == "Cat")
                        {
                            MaleCats.Add(pet.Name);
                        }
                    }
                }
            }

            FemCats.Sort();
            MaleCats.Sort();
            Console.WriteLine("The women owned these cats:");
            FemCats.ForEach(i => Console.WriteLine(i));
            Console.WriteLine("The Men owned these cats:");
            MaleCats.ForEach(i => Console.WriteLine(i));

        }
    }
}
