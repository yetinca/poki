﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace poki
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PokiDBContext : DbContext
    {
        public PokiDBContext()
            : base("name=PokiDBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<group> groups { get; set; }
        public virtual DbSet<participant> participants { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<result> results { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}