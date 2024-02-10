using Microsoft.EntityFrameworkCore;
using zamagni.davide._5i.Models;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.Extensions.Options;

public class dbContext : DbContext 
{
    private readonly DbContextOptions? _options;
    public dbContext(){}

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=database.db");

    public DbSet<Prodotto> Prodottis {get; set;}
    public DbSet<Prenotazione> Prenotaziones {get; set;}
    
}