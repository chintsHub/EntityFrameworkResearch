//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirst.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
        public System.DateTime Date { get; set; }
        public int Customer_CustomerId { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
