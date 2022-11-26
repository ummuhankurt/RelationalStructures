using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany
{
    public class EKutuphaneDbContext : DbContext
    {
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<KitapYazar> KitapYazar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=UMMUHANKURT;Database=EKuputhane;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //KitapYazar ile Kitaplar arasında ilişki kurduğunda ForeignKey hangisi olacak? KitapYazardaki KitapId.

            modelBuilder.Entity<KitapYazar>()
                .HasOne(ky => ky.Kitap)
                .WithMany(k => k.Yazarlar)
                .HasForeignKey(ky => ky.KitapId);

            //KitapYazar ile Yazarlar arasında ilişki kurduğunda ForeignKey hangisi olacak? KitapYazardaki YazarId.
            modelBuilder.Entity<KitapYazar>()
                .HasOne(ky => ky.Yazar)
                .WithMany(y => y.Kitaplar)
                .HasForeignKey(ky => ky.YazarId);

            modelBuilder.Entity<KitapYazar>()
                .HasKey(ky => new { ky.KitapId, ky.YazarId });
        }
    }
}
