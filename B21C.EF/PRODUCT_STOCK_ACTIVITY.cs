//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace B21C.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCT_STOCK_ACTIVITY
    {
        public long Id { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<long> LastUpdBy { get; set; }
        public Nullable<System.DateTime> LastUpdAt { get; set; }
        public long ProductId { get; set; }
        public int StockBefore { get; set; }
        public int StockAfter { get; set; }
        public string Remarks { get; set; }
    
        public virtual PRODUCT PRODUCT { get; set; }
    }
}
