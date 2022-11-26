using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany
{
    public class KitapYazar
    {

        public int KitapId { get; set; }
        public int YazarId { get; set; }
        public Kitap Kitap { get; set; }
        public Yazar Yazar { get; set; }
    }
}
