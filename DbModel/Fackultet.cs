//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Study_Kamalov_wpf_320P.DbModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fackultet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fackultet()
        {
            this.Kafedra = new HashSet<Kafedra>();
        }
    
        public string Abbriveatura_fackul { get; set; }
        public string Name_fackul { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kafedra> Kafedra { get; set; }
    }
}