﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MatchResult_Entities : DbContext
    {
        public MatchResult_Entities()
            : base("name=MatchResult_Entities")
        {
        }

		public MatchResult_Entities(string connectionString) : 
			base(connectionString) { }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Comand> Comands { get; set; }
        public virtual DbSet<PastMatch> PastMatches { get; set; }
        public virtual DbSet<Tournament> Tournaments { get; set; }
        public virtual DbSet<WaitResult> WaitResults { get; set; }
    }
}
