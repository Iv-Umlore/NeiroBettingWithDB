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
    
    public partial class WaitResult
    {
        public decimal id_game { get; set; }
        public decimal Team_A { get; set; }
        public decimal Team_B { get; set; }
        public decimal tournament { get; set; }
        public int replacements_A { get; set; }
        public int replacements_B { get; set; }
        public int important_A { get; set; }
        public int important_B { get; set; }
        public string prediction { get; set; }
        public System.DateTime date { get; set; }
    
        public virtual Comand Comand { get; set; }
        public virtual Tournament Tournament1 { get; set; }
    }
}
