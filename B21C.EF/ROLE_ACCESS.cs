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
    
    public partial class ROLE_ACCESS
    {
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<long> LastUpdBy { get; set; }
        public Nullable<System.DateTime> LastUpdAt { get; set; }
        public string Status { get; set; }
        public long RoleId { get; set; }
        public string AccessModule { get; set; }
        public Nullable<bool> Viewable { get; set; }
        public Nullable<bool> Editable { get; set; }
        public Nullable<bool> Addable { get; set; }
        public Nullable<bool> Deletable { get; set; }
    
        public virtual ROLE ROLE { get; set; }
    }
}
