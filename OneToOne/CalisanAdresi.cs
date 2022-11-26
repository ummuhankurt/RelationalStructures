using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne
{
    public class CalisanAdresi
    {
        //[Key,ForeignKey(nameof(Calisan))] // Hem FK'sin hem de PK.
        public int Id { get; set; }
        //Dependent classta, foreign key tanımlanır. Default Covention kullanıyorsan eğer.
        //[ForeignKey(nameof(Calisan))] //Member isimlerini bir yerde metinsel olarak kullanıyorsan nameof() ile kullan.Daha sonra o classta değişiklik olduğunda burası bizi uyarır. 
        //public int CalisanId { get; set; }
        public string Adres { get; set; }
        public Calisan Calisan { get; set; }
    }
}
