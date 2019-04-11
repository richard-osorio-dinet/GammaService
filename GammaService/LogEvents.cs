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
    
    public partial class LogEvents
    {
        public System.Guid EventID { get; set; }
        public Nullable<int> PlaceID { get; set; }
        public Nullable<int> DeviceID { get; set; }
        public Nullable<byte> ShiftID { get; set; }
        public Nullable<System.Guid> UserID { get; set; }
        public string PrintName { get; set; }
        public int EventKindID { get; set; }
        public System.DateTime Date { get; set; }
        public string Description { get; set; }
        public Nullable<System.Guid> ParentEventID { get; set; }
        public Nullable<bool> IsSolved { get; set; }
        public Nullable<System.DateTime> DateSolved { get; set; }
        public string Number { get; set; }
        public Nullable<short> DepartmentID { get; set; }
        public Nullable<int> EventStateID { get; set; }
    
        public virtual Departments Departments { get; set; }
        public virtual Places Places { get; set; }
        public virtual Devices Devices { get; set; }
        public virtual EventKinds EventKinds { get; set; }
        public virtual EventStates EventStates { get; set; }
        public virtual Users Users { get; set; }
    }
}
