﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mzxxzy.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RDENEntities : DbContext
    {
        public RDENEntities()
            : base("name=RDENEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<@class> classes { get; set; }
        public virtual DbSet<knowledege> knowledeges { get; set; }
        public virtual DbSet<link> links { get; set; }
        public virtual DbSet<relate> relates { get; set; }
        public virtual DbSet<source> sources { get; set; }
        public virtual DbSet<userrank> userranks { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}
