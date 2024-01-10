// Data/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using WebApplicationBextsa.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Pais> Paises { get; set; }
    public DbSet<Departamento> Departamentos { get; set; }
    public DbSet<Ciudad> Ciudades { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pais>().ToTable("Pais", "BEXTSA").HasKey(p => p.id);
        modelBuilder.Entity<Departamento>().ToTable("Departamento", "BEXTSA").HasKey(d => d.id);
        modelBuilder.Entity<Ciudad>().ToTable("Ciudad", "BEXTSA").HasKey(c => c.id);

        base.OnModelCreating(modelBuilder);

    }
}
