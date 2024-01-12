class Wizard : Character
{
    public Wizard(string name) : base(name, 70, 25)
    {
    }

    public void CastSpell(Character target)
    {
        Console.WriteLine($"{Name} casts a magical spell!");
        Attack(target);
    }
}
