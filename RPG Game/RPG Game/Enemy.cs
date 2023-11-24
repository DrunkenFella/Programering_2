using System.Runtime.CompilerServices;

public class Enemy
{
    public class Sir_Dorkalot_The_Dimwit
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
            Console.WriteLine($"Sir Dorkalot The Dimwit uses {item.Sword} and restores {healthRandom} health.");
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

    public class Sir_Withy_The_Itchy_The_Twitchy
    {
        public string Name { get; set; }

    }
}