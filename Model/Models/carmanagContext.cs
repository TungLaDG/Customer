using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Model.Models
{
    public partial class carmanagContext : DbContext
    {
        public carmanagContext()
        {
        }

        public carmanagContext(DbContextOptions<carmanagContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Customerinf> Customerinfs { get; set; } = null!;
        public virtual DbSet<Depot> Depots { get; set; } = null!;
        public virtual DbSet<Ordering> Orderings { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=CarManagement;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(e => e.FrameId)
                    .HasName("PK__car__563E43C042C9F4B1");

                entity.ToTable("car");

                entity.Property(e => e.FrameId)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("FrameID");

                entity.Property(e => e.CarName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId).HasColumnName("categoryID");

                entity.Property(e => e.Cc).HasColumnName("cc");

                entity.Property(e => e.Color)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("color");

                entity.Property(e => e.Enginetype)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("enginetype");

                entity.Property(e => e.Gear)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gear");

                entity.Property(e => e.Hp)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("hp");

                entity.Property(e => e.Imageurl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("imageurl");

                entity.Property(e => e.Model).HasColumnName("model");

                entity.Property(e => e.Origin)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("origin");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");

                entity.Property(e => e.Size)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("size");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("fk_cate");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Carbrand)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("carbrand");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("contact");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Name");

                entity.Property(e => e.Content)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Content");


                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Address");

                entity.Property(e => e.ReceivedDate)
                    .HasColumnType("date")
                    .HasColumnName("ReceivedDate");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("notifi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Name");

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Type");

                entity.Property(e => e.CarID)
                   .IsUnicode(false)
                   .HasColumnName("CarID");

                entity.Property(e => e.UserID)
                  .IsUnicode(false)
                  .HasColumnName("UserID");


                entity.Property(e => e.Status)
                     .HasColumnName("Status");

            });

            modelBuilder.Entity<Customerinf>(entity =>
            {
                entity.HasKey(e => e.Phonenumber)
                    .HasName("PK__customer__622BF0C349B23EEA");

                entity.ToTable("customerinf");

                entity.Property(e => e.Phonenumber)
                    .ValueGeneratedNever()
                    .HasColumnName("phonenumber");

                entity.Property(e => e.Addres)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("addres");

                entity.Property(e => e.Customername)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("customername");

                entity.Property(e => e.Sex)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sex");
            });

            modelBuilder.Entity<Depot>(entity =>
            {
                entity.HasKey(e => e.CarId)
                    .HasName("PK__depot__1436F094046FC03D");

                entity.ToTable("depot");

                entity.Property(e => e.CarId).HasColumnName("carID");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CarName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Inputdate)
                    .HasColumnType("date")
                    .HasColumnName("inputdate");

                entity.Property(e => e.Salesdate)
                    .HasColumnType("date")
                    .HasColumnName("salesdate");

                entity.Property(e => e.Sold).HasColumnName("sold");
            });

            modelBuilder.Entity<Ordering>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__ordering__0809337D1C60D838");

                entity.ToTable("ordering");

                entity.Property(e => e.OrderId).HasColumnName("orderID");

                entity.Property(e => e.CarId).HasColumnName("carID");

                entity.Property(e => e.FrameId)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("frameID");

                entity.Property(e => e.Receivedate)
                    .HasColumnType("date")
                    .HasColumnName("receivedate");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.Orderings)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("fk_carID");

                entity.HasOne(d => d.Frame)
                    .WithMany(p => p.Orderings)
                    .HasForeignKey(d => d.FrameId)
                    .HasConstraintName("fk_frameID");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.PayId)
                    .HasName("PK__payment__082E8AE3F577C592");

                entity.ToTable("payment");

                entity.Property(e => e.PayId).HasColumnName("payID");

                entity.Property(e => e.FrameId)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("frameID");

                entity.Property(e => e.Note)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.Paid).HasColumnName("paid");

                entity.Property(e => e.Phonenumber).HasColumnName("phonenumber");

                entity.Property(e => e.Unpaid).HasColumnName("unpaid");

                entity.HasOne(d => d.Frame)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.FrameId)
                    .HasConstraintName("fk_CarName");

                entity.HasOne(d => d.PhonenumberNavigation)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.Phonenumber)
                    .HasConstraintName("fk_phone");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
