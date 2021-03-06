//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppSalesManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale
    {
        public Sale()
        {
            this.SaleDetails = new HashSet<SaleDetail>();
        }
    
        public long ID { get; set; }
        public string SaleNo { get; set; }
        public string Buyer { get; set; }
        public decimal TotalAmont { get; set; }
        public Nullable<decimal> TotalVAT { get; set; }
        public Nullable<decimal> TotalDiscount { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> SaleDate { get; set; }
    
        public virtual ICollection<SaleDetail> SaleDetails { get; set; }
    }
}
