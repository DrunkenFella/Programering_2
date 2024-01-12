class Item
{
    public string Name { get; set; }

    public Item(string name)
    {
        Name = name;
    }

    public virtual void Use(Character user, Character target = null)
    {
        Console.WriteLine($"{user.Name} uses {Name}.");
    }
}
//Sword Class
class Sword : Item
{
    public Sword() : base("Sword")
    {
    }

    public override void Use(Character user, Character target = null)
    {
        int damage = new Random().Next(20, 41); // Random damage between 20 and 40
        Console.WriteLine($"{user.Name} swings the sword and deals {damage} damage.");
        if (target != null)
        {
            target.TakeDamage(damage);
            Console.WriteLine($"{target.Name} has {target.Health} health remaining.\n");
        }
    }
}
//Sword Class enemy
class Mace : Item
{
    public Mace() : base("Mace")
    {
    }

    public override void Use(Character user, Character target = null)
    {
        int damage = new Random().Next(20, 51); // Random damage between 20 and 50
        Console.WriteLine($"{user.Name} swings the sword and deals {damage} damage.");
        if (target != null)
        {
            target.TakeDamage(damage);
            Console.WriteLine($"{target.Name} has {target.Health} health remaining.\n");
        }
    }
}
//Saff Class
class Staff : Item
{
    public Staff() : base("Staff")
    {
    }

    public override void Use(Character user, Character target = null)
    {
        int damage = new Random().Next(20, 41); // Random damage between 20 and 40
        Console.WriteLine($"{user.Name} casts a spell with the staff and deals {damage} damage.");
        if (target != null)
        {
            target.TakeDamage(damage);
            Console.WriteLine($"{target.Name} has {target.Health} health remaining.\n");
        }
    }
}
//Lute Class
class Lute : Item
{
    public Lute() : base("Lute")
    {
    }

    public override void Use(Character user, Character target = null)
    {
        int damage = new Random().Next(20, 41); // Random damage between 20 and 40
        Console.WriteLine($"{user.Name} plays a tune on the lute and deals {damage} damage.");
        if (target != null)
        {
            target.TakeDamage(damage);
            Console.WriteLine($"{target.Name} has {target.Health} health remaining.\n");
        }
    }
}
//Health Class
class HealthPotion : Item
{
    public HealthPotion() : base("Health Potion")
    {
    }

    public override void Use(Character user, Character target = null)
    {
        int healingAmount = new Random().Next(5, 51); // Random healing amount between 5 and 50
        Console.WriteLine($"{user.Name} uses a health potion and heals for {healingAmount} health.");
        user.Health += healingAmount;
        Console.WriteLine($"{user.Name} has {user.Health} health.\n");
    }
}