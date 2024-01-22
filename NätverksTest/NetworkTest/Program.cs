using System.Text.Json;
using RestSharp;
using System.IO;
using Microsoft.Win32.SafeHandles;

Console.WriteLine("Say a pokemon name");
string pokename = Console.ReadLine().ToLower();
RestClient client = new("https://pokeapi.co/api/v2/");


RestRequest request = new($"pokemon/{pokename}");

RestResponse response = client.GetAsync(request).Result;


if(response.StatusCode == System.Net.HttpStatusCode.OK)
{
    Pokemon p = JsonSerializer.Deserialize<Pokemon>(response.Content);

    Console.WriteLine(p.id);
    Console.WriteLine($"Weighs {p.weight}");
}
else
{
    Console.WriteLine("What?");
}

// Console.WriteLine(response.Content);
// File.WriteAllText("pokemon.json", response.Content);

Console.ReadLine();