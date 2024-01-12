class Bard : Character
{
    public Bard(string name) : base(name, 80, 15)
    {
    }

    public void PlayLute(Character target)
    {
        Console.WriteLine($"{Name} plays a soothing tune on the lute.");
        // Bard can also heal allies, for simplicity, just increase own health
        Health += 10;
        Console.WriteLine($"{Name} heals for 10 health.");
        Console.WriteLine($"{Name} has {Health} health.\n");
    }
}   