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
    
    public partial class SURVEY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SURVEY()
        {
            this.USER_SURVEY = new HashSet<USER_SURVEY>();
        }
    
        public long Id { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<long> LastUpdBy { get; set; }
        public Nullable<System.DateTime> LastUpdAt { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public string Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_SURVEY> USER_SURVEY { get; set; }
    }
}
