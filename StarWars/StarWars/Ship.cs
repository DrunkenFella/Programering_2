using System.Text.Json.Serialization;
public class Ship
{
    [JsonPropertyName("crew")]
    public int crew { get; set; }

    [JsonPropertyName("model")]
    public string model { get; set; }

    [JsonPropertyName("starship class")]
    public int starship_class { get; set; }
    [JsonPropertyName("cost_in_credits")]
    public int cost { get; set; }
}
