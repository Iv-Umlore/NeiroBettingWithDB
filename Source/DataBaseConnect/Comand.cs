//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBaseConnect
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comand
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comand()
        {
            this.PastMatches = new HashSet<PastMatch>();
            this.WaitResults = new HashSet<WaitResult>();
        }
    
        public decimal id_team { get; set; }
        public string abbrevitions { get; set; }
        public string team_name { get; set; }
        public short tier_team { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PastMatch> PastMatches { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WaitResult> WaitResults { get; set; }
    }
}
