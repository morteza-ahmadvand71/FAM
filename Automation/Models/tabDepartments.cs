//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Baran.Ferroalloy.Automation.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tabDepartments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tabDepartments()
        {
            this.tabSubDepartments = new HashSet<tabSubDepartments>();
            this.tabEmployees = new HashSet<tabEmployees>();
            this.tabMaintenances = new HashSet<tabMaintenances>();
        }
    
        public int intID { get; set; }
        public bool bitSelect { get; set; }
        public bool bitIsActual { get; set; }
        public string nvcName { get; set; }
        public int intNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tabSubDepartments> tabSubDepartments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tabEmployees> tabEmployees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tabMaintenances> tabMaintenances { get; set; }
    }
}