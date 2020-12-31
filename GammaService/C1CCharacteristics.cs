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
    
    public partial class C1CCharacteristics
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C1CCharacteristics()
        {
            this.ProductionTasks = new HashSet<ProductionTasks>();
            this.ProductItems = new HashSet<ProductItems>();
            this.C1CCharacteristicProperties = new HashSet<C1CCharacteristicProperties>();
        }
    
        public System.Guid C1CCharacteristicID { get; set; }
        public System.Guid C1CNomenclatureID { get; set; }
        public string C1CCode { get; set; }
        public Nullable<System.Guid> MeasureUnitPackage { get; set; }
        public Nullable<System.Guid> MeasureUnitPallet { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string PrintName { get; set; }
        public string PackageLabelPath { get; set; }
        public Nullable<bool> C1CDeleted { get; set; }
        public Nullable<System.Guid> MeasureUnitIndividualPackage { get; set; }
        public Nullable<System.Guid> C1COldCharacteristicID { get; set; }
    
        public virtual C1CMeasureUnits C1CMeasureUnits { get; set; }
        public virtual C1CMeasureUnits C1CMeasureUnitsPallet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductionTasks> ProductionTasks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductItems> ProductItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C1CCharacteristicProperties> C1CCharacteristicProperties { get; set; }
    }
}
