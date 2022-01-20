using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Data.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public int ServiceId { get; set; }
        public int OrderStatusId { get; set; }
        public int Time { get; set; }

        public virtual OrderStatus OrderStatus { get; set; }
        public virtual Service Service { get; set; }
    }
}
