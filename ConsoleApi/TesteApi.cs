using Newtonsoft.Json;
using QuickType;
using System;
using System.Net.Http.Json;
using static QuickType.User;

namespace ConsoleApi
{
    class TesteApi
    {

        static async Task Main(string[] args)
        {

                HttpClient client = new HttpClient {BaseAddress = new Uri("https://jsonplaceholder.typicode.com")};
                var response = await client.GetAsync("todos");    
                var content = await response.Content.ReadAsStringAsync();            
                var users = JsonConvert.DeserializeObject<User[]>(content); 

                foreach (var item in users)
                { 
                    Console.WriteLine(item.Id);

                    Console.WriteLine(item.Title);
                }


         }

    }
}