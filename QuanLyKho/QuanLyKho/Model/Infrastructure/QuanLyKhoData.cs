namespace QuanLyKho.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyKhoData : DbContext
    {
        public QuanLyKhoData()
            : base("name=QuanLyKhoData")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Input> Inputs { get; set; }
        public virtual DbSet<InputInfo> InputInfoes { get; set; }
        public virtual DbSet<Object> Objects { get; set; }
        public virtual DbSet<Output> Outputs { get; set; }
        public virtual DbSet<OutputInfo> OutputInfoes { get; set; }
        public virtual DbSet<Suplier> Supliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.OutputInfoes)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.IdCustomer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Input>()
                .HasMany(e => e.InputInfoes)
                .WithRequired(e => e.Input)
                .HasForeignKey(e => e.IdInput)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InputInfo>()
                .HasMany(e => e.OutputInfoes)
                .WithRequired(e => e.InputInfo)
                .HasForeignKey(e => e.IdOutput)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Object>()
                .HasMany(e => e.InputInfoes)
                .WithRequired(e => e.Object)
                .HasForeignKey(e => e.IdObject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Object>()
                .HasMany(e => e.OutputInfoes)
                .WithRequired(e => e.Object)
                .HasForeignKey(e => e.IdObject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Output>()
                .HasMany(e => e.OutputInfoes)
                .WithRequired(e => e.Output)
                .HasForeignKey(e => e.IdOutput)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Suplier>()
                .HasMany(e => e.Objects)
                .WithRequired(e => e.Suplier)
                .HasForeignKey(e => e.IdSuplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Unit>()
                .HasMany(e => e.Objects)
                .WithRequired(e => e.Unit)
                .HasForeignKey(e => e.IdUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserRole>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.UserRole)
                .HasForeignKey(e => e.IdRole)
                .WillCascadeOnDelete(false);
        }
    }
}
