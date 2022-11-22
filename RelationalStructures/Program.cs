using System;

namespace RelationalStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Relationships(İlişkiler) Terimleri

            #region Pricipal Entity(Asıl Entity)
            //Kendi başına var olabilen tabloyu modeler.
            //Örneğin çalışan-departman arasındaki ilişki. Departman herhangi bir çalışan olmasa da var olur ancak departmansız bir çalışan olamaz.
            //Buradaki senaryoda Departman asıl entitiydir.
            #endregion

            #region Dependent Entity(Bağımlı Entity)
            //Kendi başına var olamayan, bir başka tabloya bağımlı(ilişkisel olarak bağımlı) olan tabloyu modelleyen entity. Çalışanlar tablosunu modelleyen "Çalışan" entitysi.
            #endregion

            #region Foreign Key
            //Principal entity ile depent entity arasındaki ilişkiyi sağlayan entitiy.
            //Dependent Entity'de tanımlanır.
            //Principal Entity'de ki principal key'i tutar.
            #endregion

            #region Principal Key
            //Principal Entity'de ki id'nin kendisidir.
            //Diğer bir deyişle Principal Entity'in kimliği olan kolonu ifade eden propertydir.
            #endregion

            #endregion

            #region Navigation Property Nedir?
            //İlişkisel tablolar arasındaki fiziksel erişimi entity class'ları üzerinden sağlayan propertylerdir.
            //Bir property'in navigation property olabilmesi için kesinlikle entity türünden olması gerekiyor.
            #endregion

            #region İlişki Türleri

            #region One to One
            //Çalışan ile adresi arasındaki ilişki gibi.Her çalışanın bir adresi olabilir,her adres bir çalışana aittir.
            #endregion

            #region One to Many 
            //Departman ile çalışan arasındaki ilişki.Bir çalışanın bir departmanı olabilir, bir departman birden fazla çalışana sahip olabilir.
            //Her çocuğun bir annesi olabilir, bir annenin birden fazla çocuğu olabilir.
            #endregion

            #region Many to Many
            //Çalışanlar ile proje arasındaki ilişki.Bir projede birden fazla çalışan olabilir, bir çalışan birden fazla projede yer alabilir.
            #endregion

            #endregion

            #region Ef Core'da İlişki Yapılandırma Yöntemleri

            #region Default Conventions
            //Varsayılan entity kurallarını kullanarak yapılan ilişki yapılandırma yöntemleridir.
            //Navigation propertyleri kullanarak ilişki şablonlarını çıkarmaktadır.
            #endregion

            #region Data Annotations Attributes
            //Entity'nin niteliklerine göre ince ayarlar yapmamızı sağlayan attributelardır.
            //[Key], [ForeignKey]
            #endregion

            #region Fluent API
            //Entity modellerindeki ilişkileri yapılandırırken daha detaylı çalışmamızı sağlayan yöntemdir.
            //Eğer Fluent Api kullanacaksan 4 tane fonksiyonu bilmen gerekecek ;

            #region HasOne
            //ilgili entity'in ilişkisel entity'e birebir ya da bire çok olacak şekilde ilişkisini yapılandırmaya başlayan metoddur.
            #endregion

            #region HasMany
            //HasMany ilgili entity'nin ilişkisel entity'e çoka-bir ya da çoka-çok olacak şekilde ilişkisini yapılandırmaya başlayan metottur.
            #endregion

            #region WithOne
            //HasOne ya da HasMany'den sonra bire bir ya da çoka bir olacak şekilde ilişki yapılandırmasını tamamlayan metoddur.
            //ilişkinin sonu 1 ile bitecekse kullanılır.
            #endregion

            #region WithMany
            //HasOne ya da HasMany'den sonra bire çok ya da çoka çok (ilişkinin sonu çok ile bitecek) olacak şekilde ilişki yapılandırmasını tamamlayan metottur.
            #endregion

            #endregion


            #endregion
        }
    }
}
