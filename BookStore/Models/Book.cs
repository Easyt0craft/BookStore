using System;
using System.Collections.Generic;

#nullable disable

namespace BookStore.Models
{
    public partial class Book
    {
        public Book()
        {
            Clients = new HashSet<Client>();
            OrderBooks = new HashSet<OrderBook>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public DateTime DatePublish { get; set; }

        public virtual Author Author { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<OrderBook> OrderBooks { get; set; }
    }
}
