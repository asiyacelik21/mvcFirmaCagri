//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvcFirmaCagri.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Gorevler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Gorevler()
        {
            this.Tbl_GorevDetaylar = new HashSet<Tbl_GorevDetaylar>();
        }
    
        public int Id { get; set; }
        public Nullable<int> GorevVeren { get; set; }
        public Nullable<int> GorevAlan { get; set; }
        public string Aciklama { get; set; }
        public Nullable<bool> Durum { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_GorevDetaylar> Tbl_GorevDetaylar { get; set; }
        public virtual Tbl_Personel Tbl_Personel { get; set; }
        public virtual Tbl_Personel Tbl_Personel1 { get; set; }
    }
}
