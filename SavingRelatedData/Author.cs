using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingRelatedData
{
    public class Author
    {
        public Author()
        {
            Books = new HashSet<BookAuthor>();
        }
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public ICollection<BookAuthor> Books { get; set; }
    }
}
