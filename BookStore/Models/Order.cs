using System;
using System.Collections.Generic;

#nullable disable

namespace BookStore.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderBooks = new HashSet<OrderBook>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime Date { get; set; }
        public int WorkerId { get; set; }
        public int OrderBookId { get; set; }
        public decimal? Total { get; set; }

        public virtual Client Client { get; set; }
        public virtual Worker Worker { get; set; }
        public virtual ICollection<OrderBook> OrderBooks { get; set; }
    }
}
