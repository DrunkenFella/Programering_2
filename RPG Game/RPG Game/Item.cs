public class Item
{
    public string Sword { get; set; }
    public int HealthRestore { get; set; }
    public int Staff { get; set; }
    public int Lute { get; set; }

    public Item(string blunt, int healthRestore, int magic, int music)
    {
        Sword = blunt;
        {
            int damage = new Random().Next(20, 40);
        }

        HealthRestore = healthRestore;
        {
            int healthRandom = new Random().Next(5, 25);
        }

        Staff = magic;
        {
            int damage = new Random().Next(20, 40);
        }

        Lute = music;
        {
            int damage = new Random().Next(20, 40);
        }

    }

}