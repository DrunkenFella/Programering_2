using System.Text.Json;
using RestSharp;
using System.IO;

Console.WriteLine("Say a Star Wars ship name");
string ship = Console.ReadLine().ToLower();
RestClient client = new("https://swapi.py4e.com/api/starships/9/");

RestRequest request = new($"ship/{name}");

RestResponse response = client.GetAsync(request).Result;


if (response.StatusCode == System.Net.HttpStatusCode.OK)
{
    Ship s = JsonSerializer.Deserialize<Ship>(response.Content);

    Console.WriteLine(s.crew);
    Console.WriteLine($"model {s.model}");
    Console.WriteLine($"Cost {s.cost}");
    Console.WriteLine($"model {s.model}");
}
else
{
    Console.WriteLine("What?");
}

Console.ReadLine();