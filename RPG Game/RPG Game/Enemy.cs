using System.Runtime.CompilerServices;

public class enemy
{
    public class Sir_Dorkalot_The_Dimwit : enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Sir_Dorkalot_The_Dimwit(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void Attack(Player target)
        {
            int damage = new Random().Next(15, 40);
            Console.WriteLine($"Sir Dorkalot The Dimwit attacks {target.class} for {damage} damage.");
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
        private void enemySelect
        {

        }

    }

    public class Sir_Withy_The_Itchy_The_Twitchy : enemy
    {
        public string Name { get; set; }

    }
}