//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorldSkills2019.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChangedParts
    {
        public long ID { get; set; }
        public long EmergencyMaintenanceID { get; set; }
        public long PartID { get; set; }
        public decimal Amount { get; set; }
    
        public virtual EmergencyMaintenances EmergencyMaintenances { get; set; }
        public virtual Parts Parts { get; set; }
    }
}
