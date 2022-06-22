using System;
using System.Collections.Generic;

#nullable disable

namespace BookStore.Models
{
    public partial class Client
    {
        public Client()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int Discount { get; set; }
        public int BookId { get; set; }

        public virtual Book Book { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
