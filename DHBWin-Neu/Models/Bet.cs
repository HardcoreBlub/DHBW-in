//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DHBWin_Neu.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bet()
        {
            this.Placement = new HashSet<Placement>();
            this.BetOptions = new HashSet<BetOptions>();
        }
    
        public int BetID { get; set; }
        public int UID_fk2 { get; set; }
        public string Title { get; set; }
        public Nullable<int> ExpPoints { get; set; }
        public Nullable<int> Reward { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Placement> Placement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BetOptions> BetOptions { get; set; }
        public virtual User User { get; set; }
    }
}