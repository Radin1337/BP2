﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjekatBP2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ServisDBMFContainer : DbContext
    {
        public ServisDBMFContainer()
            : base("name=ServisDBMFContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Servis> Servis { get; set; }
        public virtual DbSet<Serviser> Servisers { get; set; }
        public virtual DbSet<Automobil> Automobils { get; set; }
        public virtual DbSet<Pregled> Pregleds { get; set; }
        public virtual DbSet<Deo> Deos { get; set; }
        public virtual DbSet<Pokvaren> Pokvarens { get; set; }
        public virtual DbSet<MajstorZa> MajstorZas { get; set; }
        public virtual DbSet<Popravljen> Popravljens { get; set; }
    }
}