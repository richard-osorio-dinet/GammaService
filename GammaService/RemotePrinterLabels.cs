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
    
    public partial class RemotePrinterLabels
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RemotePrinterLabels()
        {
            this.RemotePrinters = new HashSet<RemotePrinters>();
        }
    
        public int RemotePrinterLabelID { get; set; }
        public string LabelName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RemotePrinters> RemotePrinters { get; set; }
    }
}
