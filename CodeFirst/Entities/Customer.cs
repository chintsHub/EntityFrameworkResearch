using System.Collections.Generic;

namespace CodeFirst.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public List<Order> Orders { get; set; }

    }
}