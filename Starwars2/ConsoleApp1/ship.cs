using System.Text.Json.Serialization;
public class Ship
{
    [JsonPropertyName("name")]
    public string name { get; set; }
    [JsonPropertyName("crew")]
    public string Crew { get; set; }
    [JsonPropertyName("model")]
    public string model { get; set; }
    [JsonPropertyName("starship_class")]
    public string StarshipClass { get; set; }
    [JsonPropertyName("cost_in_credits")]
    public string Cost { get; set; }
}