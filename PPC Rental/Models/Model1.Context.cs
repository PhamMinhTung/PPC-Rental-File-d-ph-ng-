﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPC_Rental.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class K21T1_Team4Entities : DbContext
    {
        public K21T1_Team4Entities()
            : base("name=K21T1_Team4Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DISTRICT> DISTRICTs { get; set; }
        public virtual DbSet<FEATURE> FEATUREs { get; set; }
        public virtual DbSet<PROJECT_STATUS> PROJECT_STATUS { get; set; }
        public virtual DbSet<PROPERTY> PROPERTies { get; set; }
        public virtual DbSet<PROPERTY_FEATURE> PROPERTY_FEATURE { get; set; }
        public virtual DbSet<PROPERTY_TYPE> PROPERTY_TYPE { get; set; }
        public virtual DbSet<STREET> STREETs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<USER> USERs { get; set; }
        public virtual DbSet<WARD> WARDs { get; set; }
    }
}
