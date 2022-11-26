using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne
{
    public class Calisan
    {
        public int CalisanId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public CalisanAdresi CalisanAdresi { get; set; }
    }
}
