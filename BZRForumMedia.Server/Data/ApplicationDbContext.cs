namespace BZRForumMedia.Server.Data
{
    using BZRForumMedia.Server.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppUser> AppUsers { get; set; }
        public virtual DbSet<Propis> Propisi { get; set; }
        public virtual DbSet<Rubrika> Rubrike { get; set; }
        public virtual DbSet<Podrubrika> Podrubrike { get; set; }
        public virtual DbSet<VrstaPropisa> VrstePropisa { get; set; }
        public virtual DbSet<PitanjaIOdgovori> PitanjaIOdgovori { get; set; }
        public virtual DbSet<Clanak> Clanci { get; set; }
        public virtual DbSet<TipDokumentacije> TipoviDokumentacije { get; set; }
        public virtual DbSet<Dokumentacija> Dokumentacije { get; set; }
        public virtual DbSet<Vest> Vesti { get; set; }
        public virtual DbSet<Video> Video { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
               .Entity<Propis>()
               .HasOne(p => p.IdRubrikaNavigation)
               .WithMany(u => u.Propisi)
               .HasForeignKey(p => p.IdRubrika)
               .OnDelete(DeleteBehavior.Restrict);
            builder
               .Entity<Propis>()
               .HasOne(p => p.IdPodrubrikaNavigation)
               .WithMany(u => u.Propisi)
               .HasForeignKey(p => p.IdPodrubrika)
               .OnDelete(DeleteBehavior.Restrict);
            builder
               .Entity<Propis>()
               .HasOne(p => p.IdVrstaPropisaNavigation)
               .WithMany(u => u.Propisi)
               .HasForeignKey(p => p.IdVrstaPropis)
               .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(builder);

            builder
              .Entity<Dokumentacija>()
              .HasOne(p => p.IdTipaNavigation)
              .WithMany(u => u.Dokumentacije)
              .HasForeignKey(p => p.IdTipa)
              .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(builder);
        }
    }
}
