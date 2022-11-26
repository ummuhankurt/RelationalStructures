using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne
{
    public class ETicaretDbContext : DbContext
    {
        public DbSet<Calisan> Calisanlar { get; set; }
        public DbSet<CalisanAdresi> CalisanAdresleri { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=UMMUHANKURT;Database=ETicaret;Trusted_Connection=True;");
        }
        // FLUENT API
        //Model'ların(entity) veri tabanında generate edilecek yapıları bu fonksiyonda konfigüre edilir.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Calisan, CalisanAdresine sahip, CalisanAdresi, Calisan'a sahip.
            modelBuilder.Entity<Calisan>()
                .HasOne(c => c.CalisanAdresi)  // buradaki c calisan'i temsil ediyor. Hasone bir. Bir'e ne olacak? WithOne. bire-bir.
                .WithOne(c => c.Calisan)     //  CalisanAdresi referansi ne ise buradaki c ona karşılık gelir.
                .HasForeignKey<CalisanAdresi>(c => c.Id); // Böyle olunca CalisanAdresindeki id FK olur, PK özelliğini kaybeder. PK özelliğini kaybetmemesi icin;

            modelBuilder.Entity<CalisanAdresi>().HasKey(c => c.Id); // PK özelliği korundu.
                
        }
    }
}
