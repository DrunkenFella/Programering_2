bool restart = true;

while (restart)
{
    Console.WriteLine("Enter your character's name: ");
    string playerName = Console.ReadLine();
    player player = new player(playerName, 100);
    Console.WriteLine("Enter your enemy's name: ");
    string enemyName = Console.ReadLine();
    enemy enemy = new enemy(enemyName, 100);

    Item healthPotion = new Item("Health Potion", 30);


    while (player.IsAlive() && enemy.IsAlive())
    {
        int Enemychoice = new Random().Next(0, 10);
        Console.WriteLine($"{player.Name} Health: {player.Health} | {enemy.Name} Health: {enemy.Health}");
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
