//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OgrenciNot_NetMvc5.Models.EntitiyFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_OGRENCILER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_OGRENCILER()
        {
            this.TBL_NOTLAR = new HashSet<TBL_NOTLAR>();
        }
    
        public int OGRENCIID { get; set; }
        public string OGRAD { get; set; }
        public string OGRSOYAD { get; set; }
        public string OGRFOTOGRAF { get; set; }
        public string OGRCINSIYET { get; set; }
        public Nullable<byte> OGRKULUP { get; set; }
    
        public virtual TBL_KULUPLER TBL_KULUPLER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_NOTLAR> TBL_NOTLAR { get; set; }
    }
}
