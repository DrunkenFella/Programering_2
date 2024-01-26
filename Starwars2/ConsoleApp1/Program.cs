using System.Text.Json;
using RestSharp;
using System.IO;

string yn = "y";
while (yn == "yes" || yn == "y")
{
    Console.WriteLine("Say a Star Wars looking number (9-17)");
    string ship = Console.ReadLine().ToLower();
    RestClient client = new("https://swapi.py4e.com/api/");

    RestRequest request = new($"starships/{ship}/");

    RestResponse response = client.GetAsync(request).Result;


    if (response.StatusCode == System.Net.HttpStatusCode.OK)
    {
        Ship s = JsonSerializer.Deserialize<Ship>(response.Content);

        Console.WriteLine($"Crew size {s.Crew}");
        Console.WriteLine($"Model {s.model}");
        Console.WriteLine($"Cost in credits {s.Cost}");
        Console.WriteLine($"Starship class {s.StarshipClass}");
    }
    else
    {
        Console.WriteLine("What?");
    }

    Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine("Do you want to see another Ship? yes/no");
    yn = Console.ReadLine().ToLower();
    Console.Clear();
}

