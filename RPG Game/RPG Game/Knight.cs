class Knight : Character
{
    public Knight(string name) : base(name, 100, 20)
    {
    }

    public void UseSword(Character target)
    {
        Console.WriteLine($"{Name} swings the sword!");
        Attack(target);
    }
}