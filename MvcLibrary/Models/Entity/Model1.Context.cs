﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcLibrary.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBLIBRARYEntities1 : DbContext
    {
        public DBLIBRARYEntities1()
            : base("name=DBLIBRARYEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TBLABOUT> TBLABOUTs { get; set; }
        public virtual DbSet<TBLACTION> TBLACTIONs { get; set; }
        public virtual DbSet<TBLANNOUNCEMENT> TBLANNOUNCEMENTS { get; set; }
        public virtual DbSet<TBLAUTHOR> TBLAUTHORs { get; set; }
        public virtual DbSet<TBLBANK> TBLBANKs { get; set; }
        public virtual DbSet<TBLBOOK> TBLBOOKs { get; set; }
        public virtual DbSet<TBLCATEGORY> TBLCATEGORies { get; set; }
        public virtual DbSet<TBLCONTACT> TBLCONTACTs { get; set; }
        public virtual DbSet<TBLMEMBER> TBLMEMBERS { get; set; }
        public virtual DbSet<TBLMESSAGE> TBLMESSAGES { get; set; }
        public virtual DbSet<TBLPENALTY> TBLPENALTies { get; set; }
        public virtual DbSet<TBLSTAFF> TBLSTAFFs { get; set; }
    }
}
