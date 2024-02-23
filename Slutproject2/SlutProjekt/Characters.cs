namespace SlutProjekt;

public class Characters
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }

    public Characters(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0)
            Health = 0;
    }

    public virtual void Attack(Characters target)
    {
        Console.WriteLine($"{Name} attacks {target.Name} for {Damage} damage!");
        target.TakeDamage(Damage);
        Console.WriteLine($"{target.Name} has {target.Health} health remaining.\n");
    }
}
