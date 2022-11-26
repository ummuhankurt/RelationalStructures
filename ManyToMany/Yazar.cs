using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany
{
    public class Yazar
    {
        public int Id { get; set; }
        public string YazarAdi { get; set; }
        public ICollection<KitapYazar> Kitaplar { get; set; } // Yazarlar üzerinden KitapYazar'ı sorguladığımızda kitapları getiriyormuşuz gibi düşünürüz.
    }
}
