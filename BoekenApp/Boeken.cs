//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BoekenApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Boeken
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Boeken()
        {
            this.BoekenAuteurs = new HashSet<BoekenAuteurs>();
        }
    
        public int Id { get; set; }
        public string Titel { get; set; }
        public Nullable<int> AantalPaginas { get; set; }
        public Nullable<int> Score { get; set; }
        public Nullable<System.DateTime> Publicatie { get; set; }
        public int UitgeverId { get; set; }
    
        public virtual Uitgeverijen Uitgeverijen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoekenAuteurs> BoekenAuteurs { get; set; }
        public virtual BoekenGenres BoekenGenres { get; set; }
    }
}