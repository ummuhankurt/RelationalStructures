using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationalStructures
{
    public class Departman
    {
        public int DepartmanId { get; set; }
        public string DepartmanAdi{ get; set; }
        public ICollection<Calisan> Calisanlar { get; set; } // Bir departmanın birden fazla çalışanı olabilir. Navigation property.
    }
}
