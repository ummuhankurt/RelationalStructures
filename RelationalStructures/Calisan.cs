using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationalStructures
{
    public class Calisan
    {
        public int CalisanId { get; set; }
        public string CalisanAd { get; set; }
        public string CalisanSoyad { get; set; }
        public int DepartmanId { get; set; }
        public Departman departman { get; set; } // Her çalışanın bir departmanı olur. Bu property, Navigation Property'dir.
    }
}
