using System;

namespace ManyToMany
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default Conventiron

            //Navigation property tanımla(ICollection veya List) bitti gitti. Cross tabloyu o oluşturacak.
            //Oluşturulan cross tablonun içinde composite(birleşik) primary key otomatik olarak oluşturulacaktır.

            /*
             
                public class Kitap
                {
                    public int Id { get; set; }
                    public string KitapAd { get; set; }
                    public ICollection<Yazar> Yazarlar { get; set; }
                }

               public class Yazar
               { 
                    public int Id { get; set; }
                    public string YazarAdi { get; set; }
                    public ICollection<Kitap> Kitaplar { get; set; }
                }
             */

            #endregion

            #region Data Annotations
            //Cross tabloyu manuel olarak biz oluşturmak zorundayız.
            //Cross table ile bire-cok ilişki yaparız.
            /*
             
                public class Kitap
                {
                    public int Id { get; set; }
                    public string KitapAd { get; set; }
                    public ICollection<KitapYazar> Yazarlar { get; set; }
                }

               public class Yazar
               { 
                    public int Id { get; set; }
                    public string YazarAdi { get; set; }
                    public ICollection<KitapYazar> Kitaplar { get; set; }
               }

                public class KitapYazar
                {
                    public int KitapId { get; set; } //bunların ismini değiştirirsen başına [ForeignKey(nameof..)] kullan.
                    public int YazarId { get; set; } //bunların ismini değiştirirsen başına [ForeignKey(nameof..)] kullan.
                    public Kitap Kitap { get; set; }
                    public Yazar yazar { get; set; }
                }
             */
            //Cross tabloda composite PK yapabilmen için Fluent API kullanman gerekir.Her ne kadar Data Annotations yöntemi kullansanda.
            //The entity type 'KitapYazar' has multiple properties with the [Key] attribute. Composite primary keys can only be set using 'HasKey' in 'OnModelCreating'.
            /*
                    protected override void OnModelCreating(ModelBuilder modelBuilder)
                    {
                        modelBuilder.Entity<KitapYazar>()
                        .HasKey(ky => new { ky.KitapId, ky.YazarId });
                    }
             */
            //Ayrıca cross table'ı gidipte Context sınıfında DbSet olarak tanımlamana gerek yok.Zorunda değiliz.Ef Core ilişkiler üzerinden onun zaten bir cross table olduğunu anlar.

            #endregion

            #region Fluent API
            //Cross table manuel olarak oluşturulmalı,DbSet olarak eklenmesine gerek yok.
            //Composite Primary Key HasKey metodu ile kurulmalı.

            /*
             
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
             
             */

            #endregion
        }
    }
}
