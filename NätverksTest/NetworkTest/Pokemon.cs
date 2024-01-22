using System.Text.Json.Serialization;

public class Pokemon
{
    [JsonPropertyName("id")]
    public int id { get; set; }
    
    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonPropertyName("weight")]
    public int weight { get; set; }
}