﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GigerSportLibrary.DB_Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GigerSportContext : DbContext
    {
        public GigerSportContext()
            : base("name=GigerSportContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<chineseFont> chineseFont { get; set; }
        public virtual DbSet<customer> customer { get; set; }
        public virtual DbSet<department> department { get; set; }
        public virtual DbSet<engilshFont> engilshFont { get; set; }
        public virtual DbSet<fontColor> fontColor { get; set; }
        public virtual DbSet<numberFont> numberFont { get; set; }
        public virtual DbSet<order> order { get; set; }
        public virtual DbSet<orderDetail> orderDetail { get; set; }
        public virtual DbSet<player> player { get; set; }
        public virtual DbSet<size> size { get; set; }
        public virtual DbSet<style> style { get; set; }
        public virtual DbSet<undoneOrder> undoneOrder { get; set; }
    }
}