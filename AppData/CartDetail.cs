//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderingSystem.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class CartDetail
    {
        public int CartDetailId { get; set; }
        public Nullable<int> CartId { get; set; }
        public int ProductId { get; set; }
        public Nullable<int> ProductQuantity { get; set; }
        public Nullable<decimal> ProductAmount { get; set; }
    
        public virtual Cart Cart { get; set; }
        public virtual Product Product { get; set; }
    }
}
