using System.Text.Json;
using RestSharp;
using System.IO;

Console.WriteLine("Say a Star Wars ship name");
string ship = Console.ReadLine();
RestClient client = new("https://swapi.py4e.com/api/starships/9/");

RestRequest request = new($"{ship}");

RestResponse response = client.GetAsync(request).Result;


if (response.StatusCode == System.Net.HttpStatusCode.OK)
{
    Ship s = JsonSerializer.Deserialize<Ship>(response.Content);

    Console.WriteLine($"Crew size {s.crew}");
    Console.WriteLine($"Model {s.model}");
    Console.WriteLine($"Cost in credits {s.cost_in_credits}");
    Console.WriteLine($"Starship class {s.starship_class}");
}
else
{
    Console.WriteLine("What?");
}

Console.ReadLine();