using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class BbGamesshopContext : DbContext
{
    public BbGamesshopContext()
    {
    }

    public BbGamesshopContext(DbContextOptions<BbGamesshopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CategoryTbl> CategoryTbls { get; set; }

    public virtual DbSet<KniyaTbl> KniyaTbls { get; set; }

    public virtual DbSet<ProductTbl> ProductTbls { get; set; }

    public virtual DbSet<ProductsOrderTbl> ProductsOrderTbls { get; set; }

    public virtual DbSet<UserTbl> UserTbls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-RHAN6AI\\SQLEXPRESS;Database=BB_GAMESSHOP;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoryTbl>(entity =>
        {
            entity.HasKey(e => e.IdCategory).HasName("PK__Category__CBD747061CD48B9E");

            entity.ToTable("CategoryTbl");

            entity.Property(e => e.NameCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KniyaTbl>(entity =>
        {
            entity.HasKey(e => e.IdKniya).HasName("PK__KniyaTbl__BE8A7AA3E2D3065B");

            entity.ToTable("KniyaTbl");

            entity.Property(e => e.DateKniya).HasColumnType("date");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.KniyaTbls)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK__KniyaTbl__IdUser__173876EA");
        });

        modelBuilder.Entity<ProductTbl>(entity =>
        {
            entity.HasKey(e => e.IdProduct).HasName("PK__ProductT__2E8946D450DA3C00");

            entity.ToTable("ProductTbl");

            entity.Property(e => e.Img)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NameProduct)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdCategoryNavigation).WithMany(p => p.ProductTbls)
                .HasForeignKey(d => d.IdCategory)
                .HasConstraintName("FK__ProductTb__IdCat__1273C1CD");
        });

        modelBuilder.Entity<ProductsOrderTbl>(entity =>
        {
            entity.HasKey(e => e.IdProductsOrder).HasName("PK__Products__B271FBD945B48B00");

            entity.ToTable("ProductsOrderTbl");

            entity.HasOne(d => d.IdKniyaNavigation).WithMany(p => p.ProductsOrderTbls)
                .HasForeignKey(d => d.IdKniya)
                .HasConstraintName("FK__ProductsO__IdKni__1B0907CE");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.ProductsOrderTbls)
                .HasForeignKey(d => d.IdProduct)
                .HasConstraintName("FK__ProductsO__IdPro__1A14E395");
        });

        modelBuilder.Entity<UserTbl>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("PK__UserTbl__B7C926381BDCAE38");

            entity.ToTable("UserTbl");

            entity.Property(e => e.IdUser).ValueGeneratedNever();
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
