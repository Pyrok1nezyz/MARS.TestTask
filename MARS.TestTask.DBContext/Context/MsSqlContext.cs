using MARS.TestTask.ClassLibrary;
using Microsoft.EntityFrameworkCore;

namespace MARS.TestTask.DBContext;

public class MsSqlContext : DbContext
{
    public MsSqlContext()
    {
    }

    public DbSet<Product> Products;
    public DbSet<Material> Materials;
    public DbSet<Component> Components;

    public MsSqlContext(DbContextOptions<MsSqlContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer($"Server=localhost;Database={ConnectionOptions.DBName};Trusted_Connection=false;User Id={ConnectionOptions.UserId};Password={ConnectionOptions.Password};");


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .HasMany(e => e.Components)
            .WithMany(s => s.Products)
            .UsingEntity(c => c.ToTable("dbo.link_products_to_components"));

        modelBuilder.Entity<Component>()
            .HasMany(e => e.Materials)
            .WithMany(s => s.Components)
            .UsingEntity(s => s.ToTable("dbo.link_components_to_materials"));
    }
}