using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingRelatedData
{
    public class Post
    {
        public int Id { get; set; }
        public int BlogId { get; set; } //İstersen oluşturmayadabilirsin.Sen oluşturmazsan Ef Core bunu kendisi otomatik olarak oluşturur.
        public string Title { get; set; }
        public Blog Blog { get; set; }
    }  
}
