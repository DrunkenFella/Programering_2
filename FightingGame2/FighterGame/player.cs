public class player
{
    public string Name { get; set; }
    public int Health { get; set; }

    public player(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void Attack(enemy target)
    {
        int damage = new Random().Next(20, 40);
        Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage.");
        target.Health -= damage;
    }

    public void UseItem(Item item)
    {
        int healthRandom = new Random().Next(5, 25);
        Console.WriteLine($"{Name} uses {item.Sword} and restores {healthRandom} health.");
        Health += healthRandom;
    }

    public bool IsAlive()
    {
        return Health > 0;
    }
}