using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SavingRelatedData
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ApplicationDbContext context = new();

            #region One to One İlişkisel Senaryolarda Veri Ekleme

            /*
             
             modelBuilder.Entity<Address>()
                .HasOne(a => a.Person)
                .WithOne(p => p.Address) 
                .HasForeignKey<Address>(a => a.Id); //ForeignKey hangi entity'de tanımlanmışsa, o Dependent Entity'dir.

            modelBuilder.Entity<Address>().HasKey(a => a.Id);
             
             */

            #region 1.Yöntem -> Principal Entity Üzerinden Dependent Entity Verisi Ekleme 

            //Principal entity üzerinden ekleme yaptığında Dependent entity verisi girmek zorunda değilsin.
            //Yani Personel Principal.Personeli adressiz ekleyebilirsin.Personel adres olmadan da var olabilir.

            //Person person = new();
            //person.Name = "Gencay";
            //person.Address = new Address
            //{
            //    PersonAddress = "Ankara"
            //};
            //Görüldüğü gibi adres bilgisi olmadan ekleme yapabiliyoruz;
            //Person person2 = new();
            //person2.Name = "Ali";
            //await context.AddAsync(person2);
            //await context.SaveChangesAsync();
            #endregion

            #region 2.Yöntem -> Dependent Entity Üzerinden Principal Entity Verisi Ekleme

            //Dependent Entity üzerinden ekleme yaparsan Principal Entity'i vermek zorndasın.
            //Yani bir adres eklerken Personel bilgisini vermek zorundasın. Adres kendi başına var olamaz.Personele ihtiyac duyar.

            //Address address = new();
            //address.PersonAddress = "İstanbul";
            //address.Person = new Person
            //{
            //    Name = "Engin"
            //};
            //await context.AddAsync(address);
            //await context.SaveChangesAsync();

            #endregion

            #endregion

            #region One to Many İlişkisel Senaryolarda Veri Ekleme

            //1. ve 2. yöntemler hiç verinin olmadığı durumlarda ilişkisel verileri eklememizi sağlayan yöntemlerken; 3.Yöntem önceden var olan principal entity'e karşılık yeni dependent
            //entity'nin eklenmesini sağlayan yöntemdir.

            #region 1.Yöntem -> Principal Entity Üzerinden Dependent Entity Verisi Ekleme
            //Principal Entity : Blog

            #region Nesne Referansı Üzerinden Ekleme
            //Bu yöntemde Blog ctor'unda Postları oluşturmadıysan patlar.
            //Blog blog = new() { Name = "Gencayyildiz.com Blog" };
            //blog.Posts.Add(new Post { Title = "Linq Sorguları" });
            //blog.Posts.Add(new Post { Title = "ASP .Net Core" });
            //blog.Posts.Add(new Post { Title = "IoC" });
            //await context.AddAsync(blog);
            //await context.SaveChangesAsync();
            #endregion

            #region Object Initiallizer Üzerinden Ekleme
            //Nesne ile erişim olmadığı için ctor'da tanımladığımız HashSete gerek yok.Burdan new'leyip oluşturuyoruz zaten.
            //Blog blog2 = new Blog
            //{
            //    Name = "Sezer Blog",
            //    Posts = new HashSet<Post>() { new Post { Title = ".NET"},new Post { Title = "React"} }
            //};
            //await context.AddAsync(blog2);
            //await context.SaveChangesAsync();
            #endregion

            #endregion

            #region 2.Yöntem -> Dependent Entitiy Üzerinden Principal Entity Verisi Ekleme
            //Dependent Entity : Post,
            //Depent Entity üzerinden veri ekleyeceksen Principal entity'i vermek zorundasın.
            //Post post = new()
            //{
            //    Title = "A postu",
            //    Blog = new Blog { Name = "Alinin Blogu" }
            //};
            //await context.AddAsync(post);
            //await context.SaveChangesAsync();
            #endregion

            #region 3.Yöntem -> Foreign Key Kolonu Üzerinden Veri Ekleme
            //BlogId : Dependent Entityde bulunan foreign key kolonuna karşılık gelen property.
            //Bu yöntemde var olan blog'a post eklemiş oluyorsun.
            //Post post = new()
            //{
            //    Title = "B Postu",
            //    BlogId = 5
            //};
            //await context.AddAsync(post);
            //await context.SaveChangesAsync();
            #endregion

            #endregion

            #region Many to Many ilişkisel Senaryolarda Veri Ekleme
            //#25 40:49
            #endregion
        }
    }
}
