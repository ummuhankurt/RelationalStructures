using System;

namespace OnetoMany
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default Convention
            //Bire-cok ilişki kurarken foreignkey kolonuna karşılık gelen property'i tanımlamak zorunda değiliz.Eğer tanımlamazsak Ef Core bunu kendisi tanımlayacak. 

            #endregion

            #region Data Annotations
            //Dependent entity'de foreignkey kolonuna karşılık gelen property adını default convention'dan farklı tanımlarsan,[ForeignKey(nameof(Departman))] kullanmalısın.
            #endregion

            #region Fluent API
            /*
             modelBuilder.Entity<Departman>()
                .HasMany(d => d.Calisanlar)
                .WithOne(c => c.Departman);
             */
            //ForeignKey tanımlaması yapmadık.Bire çok ilişkide gerek yok.EfCore kendisi otomatik olarak tanımlar.
            //Eğer farklı bir isimde FK tanımlarsan, HasForeginKey ile konfigürasyonu yapabilirsin.
            #endregion
        }
    }
}
