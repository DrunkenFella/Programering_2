public class Item
{
    public string Sword { get; set; }
    public int HealthRestore { get; set; }

    public Item(string name, int healthRestore)
    {
        Sword = name;
        HealthRestore = healthRestore;
    }
}