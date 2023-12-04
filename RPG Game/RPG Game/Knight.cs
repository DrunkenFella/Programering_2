public class Knight : Player
{
    public class knight
    {

        public string Name { get; set; }
        public int Health { get; set; }

        public knight(string Kent_The_Knight, int health)
        {
            Name = Kent_The_Knight;
            Health = health;
        }

        public void Attack(enemy target)
        {
            int damage = new Random().Next(20, 40);
            Console.WriteLine($"Kent The Knight attacks {target.Name} for {damage} damage.");
            target.Health -= damage;
        }

        public void UseItem(Item item)
        {
            int healthRandom = new Random().Next(5, 25);
            Console.WriteLine($"Kent The Knight uses {item.Sword} and restores {healthRandom} health.");
            Health += healthRandom;
        }

        public bool IsAlive()
        {
            return Health > 0;
        }
    }
}