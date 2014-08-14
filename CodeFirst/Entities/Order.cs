using System;

namespace CodeFirst.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
    }
}