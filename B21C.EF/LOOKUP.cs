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
    
    public partial class LOOKUP
    {
        public long Id { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<long> LastUpdBy { get; set; }
        public Nullable<System.DateTime> LastUpdAt { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public Nullable<int> Sequence { get; set; }
        public Nullable<bool> ActiveFlag { get; set; }
    }
}
