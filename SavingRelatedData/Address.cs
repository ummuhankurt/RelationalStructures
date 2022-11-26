using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingRelatedData
{
    public class Address
    {
        public int Id { get; set; } //Bağımlı olan classın id'si fk olarak kullanılır.
        public string PersonAddress { get; set; }
        public Person Person { get; set; }
    }
}
