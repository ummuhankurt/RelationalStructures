using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingRelatedData
{
    public class Book
    {
        public Book()
        {
            Authors = new HashSet<BookAuthor>();
        }
        public int Id { get; set; }
        public string BookName { get; set; }
        public ICollection<BookAuthor> Authors { get; set; }
    }
}
