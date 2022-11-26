using System;

namespace OneToOne
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default Convention
            //Her iki entity de navigation property ile birbirlerini tekil(birebir) olarak referans ederek fiziksel bir ilişkinin olacağı ifade edilir.
            /*One to One ilişki türünde, dependent entity'nin hangisini default olarak belirleyebilmek pek kolay değildir.Bu durumda fiziksel olarak bağımlı olan classta foreign key tanımlanmalı.
             * Böylece foreign key'e karşılık property tanımlayarak lüzumsuz bir kolon oluşturmuş oluyoruz.
             */
            //Anladığım kadarıyla; sadece default conventionda ForeignKey için ekstra property tanımlaması var. Datada ve fluentte Depent classın id Si hem PK hem FK olarak kullanılıyor.
            #endregion

            #region Data Annotations
            //Navigation propertyler tanımlanmalıdır.
            //Foreign Key kolonunun ismi default convention'un dışında bir kolon olacaksa eğer,ForeignKey attribute'ü ile bunu bildirebiliriz.
            //ForeignKey kolonu oluşturulmak zorunda değil.
            //Bire bir ilişkide bağımlı olan classta ekstradan ForeignKey kolonuna ihtiyaç olmayacağından dolayı bağımlı sınıftaki id kolonunu hem PK hem de FK olarak kullanıyoruz.
            //[Key,ForeignKey(nameof(Calisan))] hem pk hem fk.

            #endregion

            #region Fluent API
            //Navigation propertyler tanımlanır.
            //Fluent API yönteminde entity'ler arasındaki ilişki context sınıfı içerisinde OnModelCreating fonk. ovverride edilerek metotlar aracılığı ile tasarlanması gerekmektedir.
            //Yani tüm sorumluluk bu fonksiyonun içerisindeki çalışmalardadır.
            #endregion
        }
    }
}
