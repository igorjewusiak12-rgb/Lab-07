public class Player
{
    public string Name { get; }
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public int Gold { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }

    public Player(string name, int maxHealth, int gold)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        Gold = gold;
    }

    public void TakeDamage(int damage)
    {
       if (damage <= 0)
        {
            Console.WriteLine("Nieprawidlowa wartosc");
            return;
        }
        if (!IsAlive())
        {
            Console.WriteLine("Nie mozesz zadc obrazen pokonanemu graczowi");
            return;
        }

        Health -= damage;
        if (Health < 0)
        {
            Health = 0;
        }

        Console.WriteLine($"Otrzymales {damage} obrazen!");
    }

    public void Heal(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Nieprawidlowa wartosc");
            return;
        }
        if (!IsAlive())
        {
            Console.WriteLine("Nie mozna leczyc pokonanego gracza");
            return;
        }

        Health += amount;

        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }

        Console.WriteLine($"Odzyskales HP! Aktualne HP: {Health}");
    }

    public void GainExperience(int amount)
    {
        Experience += amount;

       while (Experience >= 100)
        {
            Level++;
            MaxHealth += 20;
            Health = MaxHealth;
            Experience -= 100;
            Console.WriteLine($"Awans! Nowy poziom: {Level}");
        }
    }

    public bool IsAlive()
    {
        return Health > 0;
    }
}
