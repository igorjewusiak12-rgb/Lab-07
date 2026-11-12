Player player = new Player("Maciuś", 100, 25);
Player player2 = new Player("Jaca",120,10);
Enemy goblin = new Enemy("Goblin", 30, 8);
Enemy ork = new Enemy("Ork",70,15);

Console.WriteLine("=== POCZATKOWE HP ===");

Console.WriteLine($"{player.Name}: {player.Health}");
Console.WriteLine($"{player2.Name}: {player2.Health}");

Console.WriteLine($"{goblin.Name}: {goblin.Health}");
Console.WriteLine($"{ork.Name}: {ork.Health}");

Console.WriteLine("================");

Console.WriteLine($"{player.Name} spotyka {goblin.Name}.");

goblin.TakeDamage(12);
Console.WriteLine($"{goblin.Name} ma {goblin.Health} HP.");

if (goblin.IsAlive())
{
    player.TakeDamage(goblin.Damage);
    Console.WriteLine($"{player.Name} ma {player.Health} HP.");
}
else
{
    Console.WriteLine("Przeciwnik został pokonany.");
}

List<Enemy> enemies = new List<Enemy>
{
    new Enemy("Goblin", 30, 8),
    new Enemy("Nietoperz", 20, 5),
    new Enemy("Ork", 70, 15)
};

foreach (Enemy enemy in enemies)
{
    Console.WriteLine($"{enemy.Name}: {enemy.Health} HP");
}


