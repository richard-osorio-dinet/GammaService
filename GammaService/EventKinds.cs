//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GammaService
{
    using System;
    using System.Collections.Generic;
    
    public partial class EventKinds
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EventKinds()
        {
            this.LogEvents = new HashSet<LogEvents>();
        }
    
        public int EventKindID { get; set; }
        public string Name { get; set; }
        public bool IsRemedyRequired { get; set; }
        public Nullable<bool> IsVisible { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LogEvents> LogEvents { get; set; }
    }
}
