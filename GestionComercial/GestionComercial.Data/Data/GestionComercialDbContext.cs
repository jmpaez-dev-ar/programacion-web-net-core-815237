using System;
using System.Collections.Generic;
using GestionComercial.Data.Entidades;
using Microsoft.EntityFrameworkCore;

namespace GestionComercial.Data.Data;

public partial class GestionComercialDbContext : DbContext
{
    public GestionComercialDbContext()
    {
    }

    public GestionComercialDbContext(DbContextOptions<GestionComercialDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<DetallePedido> DetallesPedido { get; set; }

    public virtual DbSet<Domicilio> Domicilios { get; set; }

    public virtual DbSet<Localidad> Localidades { get; set; }

    public virtual DbSet<Pais> Paises { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Provincia> Provincias { get; set; }

    public virtual DbSet<TipoDocumento> TiposDocumento { get; set; }

    public virtual DbSet<Vendedor> Vendedores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=GestionComercial;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Celular)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CuitCuil)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Domicilio).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.DomicilioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Clientes_Domicilios");

            entity.HasOne(d => d.TipoDocumento).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.TipoDocumentoId)
                .HasConstraintName("FK_Clientes_TiposDocumento");
        });

        modelBuilder.Entity<DetallePedido>(entity =>
        {
            entity.ToTable("DetallesPedido");

            entity.Property(e => e.DescuentoPorcentaje).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Pedido).WithMany(p => p.DetallesPedidos)
                .HasForeignKey(d => d.PedidoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetallesPedido_Pedidos");

            entity.HasOne(d => d.Producto).WithMany(p => p.DetallesPedido)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetallesPedido_Productos");
        });

        modelBuilder.Entity<Domicilio>(entity =>
        {
            entity.Property(e => e.Barrio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Calle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Departamento)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.EntreCalles)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Observacion).HasColumnType("text");
            entity.Property(e => e.Piso)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.HasOne(d => d.Localidad).WithMany(p => p.Domicilios)
                .HasForeignKey(d => d.LocalidadId)
                .HasConstraintName("FK_Domicilios_Localidades");
        });

        modelBuilder.Entity<Localidad>(entity =>
        {
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Provincia).WithMany(p => p.Localidades)
                .HasForeignKey(d => d.ProvinciaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Localidades_Provincias");
        });

        modelBuilder.Entity<Pais>(entity =>
        {
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasOne(d => d.Cliente).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pedido_Clientes");

            entity.HasOne(d => d.DomicilioIdEntregaNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.DomicilioIdEntrega)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pedidos_Domicilios");

            entity.HasOne(d => d.Vendedor).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.VendedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pedido_Vendedor");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Categoria).WithMany(p => p.Productos)
                .HasForeignKey(d => d.CategoriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Productos_Categorias");
        });

        modelBuilder.Entity<Provincia>(entity =>
        {
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Pais).WithMany(p => p.Provincia)
                .HasForeignKey(d => d.PaisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Provincias_Paises");
        });

        modelBuilder.Entity<TipoDocumento>(entity =>
        {
            entity.ToTable("TiposDocumento");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vendedor>(entity =>
        {
            entity.ToTable("Vendedor");

            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Celular)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Domicilio).WithMany(p => p.Vendedors)
                .HasForeignKey(d => d.DomicilioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vendedor_Domicilios");

            entity.HasOne(d => d.TipoDocumento).WithMany(p => p.Vendedors)
                .HasForeignKey(d => d.TipoDocumentoId)
                .HasConstraintName("FK_Vendedor_TiposDocumento");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
