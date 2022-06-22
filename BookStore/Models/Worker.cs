using System;
using System.Collections.Generic;

#nullable disable

namespace BookStore.Models
{
    public partial class Worker
    {
        public Worker()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public int PositionsId { get; set; }

        public virtual Position Positions { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
