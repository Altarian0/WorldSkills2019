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
    
    public partial class DepartmentLocations
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DepartmentLocations()
        {
            this.Assets = new HashSet<Assets>();
        }
    
        public long ID { get; set; }
        public long DepartmentID { get; set; }
        public long LocationID { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assets> Assets { get; set; }
        public virtual Departments Departments { get; set; }
        public virtual Locations Locations { get; set; }
    }
}
