using HeroesMvc.Data.Configurations;
using HeroesMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace HeroesMvc.Data;

public class HeroesDbContext : DbContext
{
    public HeroesDbContext(DbContextOptions<HeroesDbContext> options)
        : base(options)
    {
    }

    public DbSet<Heroe> Heroes => Set<Heroe>();
    public DbSet<Ciudad> Ciudades => Set<Ciudad>();
    public DbSet<Villano> Villanos => Set<Villano>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Heroe>(entity =>
        {
            entity.ToTable("Heroes", "dbo");
            entity.HasKey(h => h.Id);
            entity.Property(h => h.Nombre).HasMaxLength(100).IsRequired();
        });

        modelBuilder.ApplyConfiguration(new CiudadConfiguration());
        modelBuilder.ApplyConfiguration(new VillanoConfiguration());
    }
}