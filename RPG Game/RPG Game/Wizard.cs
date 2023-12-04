public class Wizard : Player
{
//Name = Winston The Wizard
public class wizard
{
    public string Name { get; set; }
    public int Health { get; set; }

    public wizard(string Winston_The_Wizard, int health)
    {
        Name = Winston_The_Wizard;
        Health = health;
    }

    public void Attack(enemy target)
    {
        int damage = new Random().Next(20, 40);
        Console.WriteLine($"Winston The Wizard attacks {target.Name} for {damage} damage.");
        target.Health -= damage;
    }

    public void UseItem(Item item)
    {
        int healthRandom = new Random().Next(5, 25);
        Console.WriteLine($"Winston The Wizard  uses {item.Staff} and restores {healthRandom} health.");
        Health += healthRandom;
    }

    public bool IsAlive()
    {
        return Health > 0;
    }
    int hp;
    int damage;
    int resident;

    //resident 
    //Music beats Sword
    //Sword beats Magic
    //Magic beats Music
}
}