using System;
using System.Collections.Generic;
using Demo_entity.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace Demo_entity.Database;

public partial class MydbContext : DbContext
{
    public MydbContext()
    {
    }

    public MydbContext(DbContextOptions<MydbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Specification> Specifications { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;user=root;password=root;database=mydb", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.40-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb3_general_ci")
            .HasCharSet("utf8mb3");

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("customers");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Addres)
                .HasMaxLength(45)
                .HasColumnName("addres");
            entity.Property(e => e.Buyer)
                .HasMaxLength(10)
                .HasColumnName("buyer");
            entity.Property(e => e.Inn)
                .HasMaxLength(40)
                .HasColumnName("inn");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(45)
                .HasColumnName("phone");
            entity.Property(e => e.Salesman)
                .HasMaxLength(10)
                .HasColumnName("salesman");
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("material");

            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Weight).HasColumnName("weight");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.SalesmanId, e.ProductId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("order");

            entity.HasIndex(e => e.SalesmanId, "fk_order_customers1_idx");

            entity.HasIndex(e => e.ProductId, "fk_order_product1_idx");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.SalesmanId).HasColumnName("salesman_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Valueproduct).HasColumnName("valueproduct");

            entity.HasOne(d => d.Product).WithMany(p => p.Orders)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_order_product1");

            entity.HasOne(d => d.Salesman).WithMany(p => p.Orders)
                .HasForeignKey(d => d.SalesmanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_order_customers1");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("product");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
        });

        modelBuilder.Entity<Specification>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.CustomersId, e.ProductId, e.MaterialId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("specification");

            entity.HasIndex(e => e.CustomersId, "fk_specification_customers_idx");

            entity.HasIndex(e => e.MaterialId, "fk_specification_material1_idx");

            entity.HasIndex(e => e.ProductId, "fk_specification_product1_idx");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.CustomersId).HasColumnName("customers_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.MaterialId).HasColumnName("material_Id");

            entity.HasOne(d => d.Customers).WithMany(p => p.Specifications)
                .HasForeignKey(d => d.CustomersId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_specification_customers");

            entity.HasOne(d => d.Material).WithMany(p => p.Specifications)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_specification_material1");

            entity.HasOne(d => d.Product).WithMany(p => p.Specifications)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_specification_product1");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("users");

            entity.HasIndex(e => e.Id, "Id_UNIQUE").IsUnique();

            entity.HasIndex(e => e.Login, "Login_UNIQUE").IsUnique();

            entity.Property(e => e.CaptchaAttempts)
                .HasDefaultValueSql("'3'")
                .HasColumnName("Captcha_attempts");
            entity.Property(e => e.Login).HasMaxLength(120);
            entity.Property(e => e.Password).HasMaxLength(60);
            entity.Property(e => e.Role)
                .HasMaxLength(10)
                .HasDefaultValueSql("'User'");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
