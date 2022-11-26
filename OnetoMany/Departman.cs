using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToMany
{
    public class Departman
    {
        public int Id { get; set; }
        public string DepartmanAdi { get; set; }
        public ICollection<Calisan> Calisanlar { get; set; }
    }
}
