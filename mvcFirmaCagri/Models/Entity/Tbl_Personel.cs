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
    
    public partial class Tbl_Personel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Personel()
        {
            this.Tbl_Gorevler = new HashSet<Tbl_Gorevler>();
            this.Tbl_Gorevler1 = new HashSet<Tbl_Gorevler>();
        }
    
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Gorsel { get; set; }
        public Nullable<int> Departman { get; set; }
        public Nullable<bool> Durum { get; set; }
    
        public virtual Tbl_Departmanlar Tbl_Departmanlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Gorevler> Tbl_Gorevler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Gorevler> Tbl_Gorevler1 { get; set; }
    }
}
