using KidsAndMeCommon.Entities;
using Microsoft.EntityFrameworkCore;

namespace KidsAndMeDataAccess;

public class MainDbContext : DbContext
{
    public DbSet<Baby> Babies { get; set; }
    public DbSet<BabyFoodAttempt> BabyFoodAttempts { get; set; }
    public DbSet<BathAttempt> BathAttempts { get; set; }
    public DbSet<MomFoodAttempt> MomFoodAttempts { get; set; }
    public DbSet<SleepAttempt> SleepAttempts { get; set; }
    public DbSet<SleepReminder> SleepReminders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Server=localhost;Database=KidsAndMe;User Id=sa;Password=MyPass@word;TrustServerCertificate=True;");
    }
}