//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjekatBP2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pokvaren
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pokvaren()
        {
            this.Popravljeni = new HashSet<Popravljen>();
        }
    
        public long PregledAutomobilSASIJA { get; set; }
        public long PregledDijagnosticarJMBG { get; set; }
        public int DeoDEOID { get; set; }
    
        public virtual Pregled Pregled { get; set; }
        public virtual Deo Deo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Popravljen> Popravljeni { get; set; }
    }
}
