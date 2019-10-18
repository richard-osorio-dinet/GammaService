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
    
    public partial class Places
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Places()
        {
            this.DocProduction = new HashSet<DocProduction>();
            this.Docs = new HashSet<Docs>();
            this.DocWithdrawal = new HashSet<DocWithdrawal>();
            this.ProductionTasks = new HashSet<ProductionTasks>();
            this.LogEvents = new HashSet<LogEvents>();
            this.PlaceRemotePrinters = new HashSet<PlaceRemotePrinters>();
        }
    
        public int PlaceID { get; set; }
        public Nullable<System.Guid> PlaceGuid { get; set; }
        public int BranchID { get; set; }
        public Nullable<int> BranchUnitID { get; set; }
        public string Name { get; set; }
        public string NameEng { get; set; }
        public short DepartmentID { get; set; }
        public short PlaceGroupID { get; set; }
        public Nullable<bool> IsProductionPlace { get; set; }
        public Nullable<bool> IsWarehouse { get; set; }
        public Nullable<bool> IsTransitWarehouse { get; set; }
        public Nullable<bool> IsShipmentWarehouse { get; set; }
        public Nullable<System.Guid> C1CPlaceID { get; set; }
        public Nullable<int> UnwindersCount { get; set; }
        public Nullable<bool> IsRemotePrinting { get; set; }
        public Nullable<bool> UseApplicator { get; set; }
        public string ApplicatorLabelPath { get; set; }
        public Nullable<bool> IsRobot { get; set; }

        public virtual ActiveProductionTasks ActiveProductionTasks { get; set; }
        public virtual CurrentPlaceUsers CurrentPlaceUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocProduction> DocProduction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Docs> Docs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocWithdrawal> DocWithdrawal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductionTasks> ProductionTasks { get; set; }
        public virtual Departments Departments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LogEvents> LogEvents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlaceRemotePrinters> PlaceRemotePrinters { get; set; }
    }
}
