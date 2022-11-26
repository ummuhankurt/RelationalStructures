using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToMany
{
    public class Calisan
    {
        //Dependent class. Calisanlar toplu olarak 1 departmana BAĞLI.
        public int Id { get; set; }
        public int DId { get; set; }
        public string Adi { get; set; }
        public Departman Departman { get; set; }
    }
}
