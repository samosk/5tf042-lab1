using Microsoft.EntityFrameworkCore;

public class AnnonsContext : DbContext
{
    public AnnonsContext(DbContextOptions<AnnonsContext> options)
        : base(options) { }

    public DbSet<Annonsor> Annonsorer => Set<Annonsor>();
    public DbSet<Ad> Ads => Set<Ad>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);   // ← add this line

        modelBuilder.Entity<Annonsor>(entity =>
        {
            entity.ToTable("tbl_annonsorer", t =>
                t.HasCheckConstraint("ck_ann_typ", "ann_typ IN ('prenumerant', 'foretag')")
            );
        });

        modelBuilder.Entity<Ad>(entity =>
        {
            entity.HasOne(a => a.Annonsor)
                  .WithMany(an => an.Ads)
                  .HasForeignKey(a => a.AnnonsorId)
                  .OnDelete(DeleteBehavior.Cascade);

            entity.Property(a => a.Varupris).HasPrecision(10, 2);
            entity.Property(a => a.Annonspris).HasPrecision(10, 2).HasDefaultValue(0m);
        });
    }
}