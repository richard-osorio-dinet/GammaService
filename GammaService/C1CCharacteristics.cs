//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
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
            this.ProductPalletItems = new HashSet<ProductPalletItems>();
        }
    
        public System.Guid C1CCharacteristicID { get; set; }
        public Nullable<System.Guid> C1CNomenclatureID { get; set; }
        public string C1CCode { get; set; }
        public Nullable<System.Guid> MeasureUnitPackage { get; set; }
        public Nullable<System.Guid> MeasureUnitPallet { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductionTasks> ProductionTasks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductPalletItems> ProductPalletItems { get; set; }
        public virtual C1CMeasureUnits C1CMeasureUnits { get; set; }
        public virtual C1CMeasureUnits C1CMeasureUnitsPallet { get; set; }
    }
}