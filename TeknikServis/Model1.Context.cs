﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeknikServis
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DbTeknikServisEntities : DbContext
    {
        public DbTeknikServisEntities()
            : base("name=DbTeknikServisEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TblAdmin> TblAdmin { get; set; }
        public virtual DbSet<TblArızaDetay> TblArızaDetay { get; set; }
        public virtual DbSet<TblCari> TblCari { get; set; }
        public virtual DbSet<TblDepartman> TblDepartman { get; set; }
        public virtual DbSet<TblFaturaBilgi> TblFaturaBilgi { get; set; }
        public virtual DbSet<TblFaturaDetay> TblFaturaDetay { get; set; }
        public virtual DbSet<TblGider> TblGider { get; set; }
        public virtual DbSet<TblKategori> TblKategori { get; set; }
        public virtual DbSet<TblNotlarım> TblNotlarım { get; set; }
        public virtual DbSet<TblPersonel> TblPersonel { get; set; }
        public virtual DbSet<TblUrun> TblUrun { get; set; }
        public virtual DbSet<TblUrunHareket> TblUrunHareket { get; set; }
        public virtual DbSet<TblUrunKabul> TblUrunKabul { get; set; }
        public virtual DbSet<TblUrunTakip> TblUrunTakip { get; set; }
        public virtual DbSet<TblHakkımızda> TblHakkımızda { get; set; }
        public virtual DbSet<Tblİletisim> Tblİletisim { get; set; }
        public virtual DbSet<TblIlceler> TblIlceler { get; set; }
        public virtual DbSet<TblIller> TblIller { get; set; }
    
        public virtual ObjectResult<urunkategori_Result> urunkategori()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<urunkategori_Result>("urunkategori");
        }
    
        public virtual ObjectResult<string> makskategoriurun()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("makskategoriurun");
        }
    
        public virtual ObjectResult<string> marksurunmarka()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("marksurunmarka");
        }
    }
}