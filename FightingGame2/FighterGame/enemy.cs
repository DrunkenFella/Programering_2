public class enemy
{
    public string Name { get; set; }
    public int Health { get; set; }

    public enemy(string name, int health)
    {
        Name = name;
        Health = health;
    }
    
    public void Attack(player target)
    {
        int damage = new Random().Next(15, 40);
        Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage.");
        target.Health -= damage;
    }

    public void EnemyUseItem(Item item)
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