using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany
{
    public class Kitap
    {
        public int Id { get; set; }
        public string KitapAd { get; set; }
        public ICollection<KitapYazar> Yazarlar { get; set; } // Kitap üzerinden KitapYazar'ı sorguladığımızda yazarları getiriyormuşuz gibi düşünürüz.

    }
}
