namespace GigerSport.DBModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GigerSportDB : DbContext
    {
        public GigerSportDB()
            : base("name=GigerSportDBContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<customer>()
                .Property(e => e.phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.texId)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.order)
                .WithRequired(e => e.customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<engilshFont>()
                .HasMany(e => e.orderDetail)
                .WithOptional(e => e.engilshFont)
                .HasForeignKey(e => e.englishFontId);

            modelBuilder.Entity<fontColor>()
                .HasMany(e => e.orderDetail)
                .WithRequired(e => e.fontColor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<order>()
                .HasMany(e => e.orderDetail)
                .WithRequired(e => e.order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<order>()
                .HasMany(e => e.undoneOrder)
                .WithRequired(e => e.order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<orderDetail>()
                .Property(e => e.amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<orderDetail>()
                .Property(e => e.img)
                .IsUnicode(false);

            modelBuilder.Entity<orderDetail>()
                .HasMany(e => e.player)
                .WithRequired(e => e.orderDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<player>()
                .Property(e => e.number)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<size>()
                .Property(e => e.sizeName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<size>()
                .HasMany(e => e.player)
                .WithRequired(e => e.size1)
                .HasForeignKey(e => e.size)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<style>()
                .HasMany(e => e.orderDetail)
                .WithRequired(e => e.style)
                .WillCascadeOnDelete(false);
        }
    }
}
