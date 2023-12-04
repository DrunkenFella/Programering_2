bool restart = true;

while (restart)
{
    Console.WriteLine("What do you want to play as? Knight = 1, Wizard = 2, Bard = 3");
    String class = Console.ReadLine();
    if (class = 1)
    {
    Player player = new Knight(1, 100);
    }
    else if (class = 2)
    {
        Player player = new Wizard(1, 100);
    }
    else if (class = 3)
    {
        Player player = new Bard(1, 100);
    }
    else 
    {
        Console.WriteLine("Invalid, try again");
        Console.ReadLine();
    }

    Console.WriteLine("Enter your enemy's name: ");
    string enemyName = Console.ReadLine();
    enemy enemy = new enemy(enemyName, 100);

    Item healthPotion = new Item("Health Potion", 30);


    while (player.IsAlive() && enemy.IsAlive())
    {
        int Enemychoice = new Random().Next(0, 10);
        Console.WriteLine($"{player.} Health: {player.Health} | {enemy.Name} Health: {enemy.Health}");
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Heal");
        Console.WriteLine("2. Fight");

        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.Clear();
            if (choice == 1)
            {
                player.UseItem(healthPotion);
            }
            else if (choice == 2)
            {

                player.Attack(enemy);

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            
            if (Enemychoice >= 5)
            {
                enemy.Attack(player);
            }
            else
            {
                enemy.EnemyUseItem(healthPotion);
            }
        }

    }
    Console.Clear();
    string winner = player.IsAlive() ? player.Name : enemy.Name;

    if (winner == player.Name)
    {
        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.Clear();
        Console.WriteLine($"{winner} wins!");
    }
    else
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
        Console.WriteLine($"{winner} wins!");
    }




    Console.WriteLine("Do you want to restart? (y/n)");
    string restartChoice = Console.ReadLine();
    restart = (restartChoice.ToLower() == "y");

    Console.BackgroundColor = ConsoleColor.Black;
    Console.Clear();
}