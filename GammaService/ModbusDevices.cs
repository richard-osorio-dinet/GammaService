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
    
    public partial class ModbusDevices
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ModbusDevices()
        {
            this.PlaceRemotePrinters = new HashSet<PlaceRemotePrinters>();
        }
    
        public int ModbusDeviceID { get; set; }
        public int ModbusDeviceTypeID { get; set; }
        public string IPAddress { get; set; }
        public string Name { get; set; }
        public int TimerTick { get; set; }
        public string ServiceAddress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlaceRemotePrinters> PlaceRemotePrinters { get; set; }
    }
}
