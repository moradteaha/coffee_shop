//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace coffee_shop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public int OrderDetails { get; set; }
        public int Orderid { get; set; }
        public string itemid { get; set; }
        public decimal Quantetity { get; set; }
        public decimal Total { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
