using System;
using System.Collections.Generic;

#nullable disable

namespace BookStore.Models
{
    public partial class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
