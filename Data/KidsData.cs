using Microsoft.EntityFrameworkCore;

namespace Data;
public class KidsContext : DbContext
{
    public DbSet<Kid> Kids { get; set; }
    public DbSet<Card> Cards { get; set; }
    public DbSet<Bonus> Bonus { get; set; }
    public DbSet<Bonus> WonBonus { get; set; }
    public DbSet<Rule> Rules { get; set; }

    public string DbPath { get; }

    public KidsContext()
    {
        DbPath = "kidsbehavior.db";
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}

public class Kid
{
    public int KidId { get; set; }
    public required string Name { get; set; }
    public List<Card> Cards { get; } = new();
    public List<WonBonus> WonBonus { get; } = new();
}

public class Card
{
    public int CardId { get; set; }
    public CardColor Color { get; set; }
    public DateTime Date { get; set; }
    public int KidId { get; set; }
    public int RuleId { get; set; }
    public string? Comment { get; set; }
}

public enum CardColor
{
    Yellow,
    Red
}

public class Bonus
{
    public int BonusId { get; set; }
    public required string Name { get; set; }
}

public class WonBonus
{
    public int WonBonusId { get; set; }
    public DateTime Expiration { get; set; }
    public bool Used { get; set; }
    public int BonusId { get; set; }
    public int KidId { get; set; }
}

public class Rule
{
    public int RuleId { get; set; }
    public required string Description { get; set; }
}