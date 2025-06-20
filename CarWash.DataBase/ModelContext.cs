using CarWash.Models;
using Microsoft.EntityFrameworkCore;

namespace CarWash.DataBase;

public class ModelContext : DbContext
{
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<SignUp> SignUps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source=PracticalDataBase.db");
    }
}