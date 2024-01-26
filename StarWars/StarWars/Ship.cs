using System.Text.Json.Serialization;
public class Ship
{
    [JsonPropertyName("name")]
    public string name {get; set;}
    [JsonPropertyName("Crew")]
    public int crew { get; set; }
    [JsonPropertyName("model")]
    public string model { get; set; }
    [JsonPropertyName("cost_in_credits")]
    public string starship_class { get; set; }
    [JsonPropertyName("cost_in_credits")]
    public string cost_in_credits { get; set; }
}