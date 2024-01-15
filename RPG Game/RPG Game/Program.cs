Console.WriteLine("Welcome to the Adventure!");

        while (true)
        {
            Knight kent = new Knight("Kent The Knight");
            Bard brad = new Bard("Brad The Bard");
            Wizard winston = new Wizard("Winston The Wizard");

            //Enemies
            List<Character> enemies = new List<Character>
            { 
                new Enemy("SirDorkalotTheDimwit", 50, 15),
                new Enemy("SirWithyTheItchyTheTwitchy", 60, 20),
                new Enemy("Steffan", 40, 10)
            };

            List<Item> items = new List<Item>
            {
                new Sword(),
                new HealthPotion()
            };

            Random random = new Random();
            int randomEnemyIndex = random.Next(enemies.Count);
            Character currentEnemy = enemies[randomEnemyIndex];

            Console.WriteLine($"\n{currentEnemy.Name} approaches!");
            Console.WriteLine("---------------------------");

            while (currentEnemy.Health > 0 && (kent.Health > 0 || brad.Health > 0 || winston.Health > 0))
            {
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Use Sword\n2. Use Health Potion");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2)
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 2.");
                }

                items[choice - 1].Use(kent, currentEnemy);
                brad.PlayLute(currentEnemy);
                winston.CastSpell(currentEnemy);
                currentEnemy.Mace(kent);
            }

            if (currentEnemy.Health <= 0)
                Console.WriteLine($"{currentEnemy.Name} has been defeated!\n");
            else
                Console.WriteLine("You have been defeated. Game Over!");

            Console.Write("Do you want to play again? (y/n): ");
            string response = Console.ReadLine().ToLower();
            if (response != "y")
                break;

            Console.Clear();
        }

        Console.WriteLine("Thanks for playing!");