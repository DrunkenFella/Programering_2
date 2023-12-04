public class Bard : Player
{
//Name = Brad The Bard 
public class bard
{
    public string Name { get; set; }
    public int Health { get; set; }

    public bard(string Brad_The_Bard, int health)
    {
        Name = Brad_The_Bard;
        Health = health;
    }

    public void Attack(enemy target)
    {
        int damage = new Random().Next(20, 40);
        Console.WriteLine($"Brad The Bard attacks {target.Name} for {damage} damage.");
        target.Health -= damage;
    }

    public void UseItem(Item item)
    {
        int healthRandom = new Random().Next(5, 25);
        Console.WriteLine($"Brad The Bard  uses {item.Sword} and restores {healthRandom} health.");
        Health += healthRandom;
    }

    public bool IsAlive()
    {
        return Health > 0;
    }
}
}