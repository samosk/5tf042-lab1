using Microsoft.EntityFrameworkCore;

public class PrenumerantContext : DbContext
{
    public PrenumerantContext(DbContextOptions<PrenumerantContext> options)
        : base(options) { }

    public DbSet<Prenumerant> Prenumeranter => Set<Prenumerant>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Prenumerant>()
            .HasIndex(p => p.Personnummer)
            .IsUnique();
        modelBuilder.Entity<Prenumerant>()
            .HasIndex(p => p.Prenumerantnummer)
            .IsUnique();
    }
}