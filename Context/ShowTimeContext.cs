using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyApplication.Entities;

namespace MyApplication.Context
{
    public class ShowTimeContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ShowTimeContext(DbContextOptions<ShowTimeContext> options)
            : base(options)
        {
        
        }
    
        public DbSet<Festival> Festivals { get; set; }
        public DbSet<Band> Bands { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BandFestival> BandFestivals { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure composite key
            modelBuilder.Entity<BandFestival>()
                .HasKey(bf => new { bf.FestivalId, bf.BandId });

            // Configure relationships
            modelBuilder.Entity<BandFestival>()
                .HasOne(bf => bf.Festival)
                .WithMany(f => f.BandFestivals) // Now matches property name
                .HasForeignKey(bf => bf.FestivalId);

            modelBuilder.Entity<BandFestival>()
                .HasOne(bf => bf.Band)
                .WithMany(b => b.BandFestivals) // Now matches property name
                .HasForeignKey(bf => bf.BandId);

            base.OnModelCreating(modelBuilder);
        }
        
    } 
}
