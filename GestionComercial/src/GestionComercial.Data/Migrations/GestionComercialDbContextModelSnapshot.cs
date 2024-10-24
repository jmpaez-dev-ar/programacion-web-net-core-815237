﻿// <auto-generated />
using System;
using GestionComercial.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestionComercial.Data.Migrations
{
    [DbContext(typeof(GestionComercialDbContext))]
    partial class GestionComercialDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GestionComercial.Data.Entidades.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id")
                        .HasName("PK_Categorias_Id");

                    b.HasIndex(new[] { "Codigo" }, "UQ_Categorias_Codigo")
                        .IsUnique();

                    b.ToTable("Categorias", (string)null);
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Celular")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("CuitCuil")
                        .HasMaxLength(13)
                        .IsUnicode(false)
                        .HasColumnType("varchar(13)");

                    b.Property<int>("DomicilioId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateOnly>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("NumeroDocumento")
                        .HasColumnType("int");

                    b.Property<string>("RazonSocial")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Telefono")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("TipoDocumentoId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_Clientes_Id");

                    b.HasIndex("TipoDocumentoId");

                    b.HasIndex(new[] { "DomicilioId" }, "IX_Clientes_DomicilioId")
                        .IsUnique();

                    b.HasIndex(new[] { "Codigo" }, "UQ_Clientes_Codigo")
                        .IsUnique();

                    b.ToTable("Clientes", (string)null);
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.DetallePedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<decimal>("DescuentoPorcentaje")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_DetallesPedido_Id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProductoId");

                    b.ToTable("DetallesPedido", (string)null);
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.Domicilio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Altura")
                        .HasColumnType("int");

                    b.Property<string>("Barrio")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Calle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CodigoPostal")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Departamento")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)");

                    b.Property<string>("EntreCalles")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("LocalidadId")
                        .HasColumnType("int");

                    b.Property<string>("Observacion")
                        .HasColumnType("text");

                    b.Property<string>("Piso")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)");

                    b.HasKey("Id")
                        .HasName("PK_Domicilios_Id");

                    b.HasIndex("LocalidadId");

                    b.ToTable("Domicilios", (string)null);
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.Localidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("ProvinciaId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_Localidades_Id");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("Localidades", (string)null);
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.Paises", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id")
                        .HasName("PK_Paises_Id");

                    b.ToTable("Paises", (string)null);
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("DomicilioIdEntrega")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("FechaEntrega")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("FechaEnvio")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaPedido")
                        .HasColumnType("date");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int>("VendedorId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_Pedidos_Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("VendedorId");

                    b.HasIndex(new[] { "DomicilioIdEntrega" }, "IX_Pedidos_DomicilioId")
                        .IsUnique();

                    b.HasIndex(new[] { "Numero" }, "IX_Pedidos_Numero")
                        .IsUnique();

                    b.ToTable("Pedidos", (string)null);
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<int?>("NivelNuevoPedido")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int?>("UnidadesEnExistencia")
                        .HasColumnType("int");

                    b.Property<int?>("UnidadesEnPedido")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_Productos_Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex(new[] { "Codigo" }, "UQ_Productos_Codigo")
                        .IsUnique();

                    b.ToTable("Productos", (string)null);
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.Provincia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("PaisId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_Provincias_Id");

                    b.HasIndex("PaisId");

                    b.ToTable("Provincias", (string)null);
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.TipoDocumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id")
                        .HasName("PK_TiposDocumento_Id");

                    b.HasIndex(new[] { "Codigo" }, "UQ_TiposDocumento_Codigo")
                        .IsUnique();

                    b.ToTable("TiposDocumento", (string)null);
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Celular")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("DomicilioId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateOnly?>("FechaContratacion")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("NumeroDocumento")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("TipoDocumentoId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_Vendedor_Id");

                    b.HasIndex("TipoDocumentoId");

                    b.HasIndex(new[] { "DomicilioId" }, "IX_Vendedor_DomicilioId")
                        .IsUnique();

                    b.HasIndex(new[] { "Codigo" }, "UQ_Vendedor_Codigo")
                        .IsUnique();

                    b.ToTable("Vendedores", (string)null);
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.Cliente", b =>
                {
                    b.HasOne("GestionComercial.Data.Entidades.Domicilio", "Domicilio")
                        .WithOne("Cliente")
                        .HasForeignKey("GestionComercial.Data.Entidades.Cliente", "DomicilioId")
                        .IsRequired()
                        .HasConstraintName("FK_Clientes_Domicilios");

                    b.HasOne("GestionComercial.Data.Entidades.TipoDocumento", "TipoDocumento")
                        .WithMany("Clientes")
                        .HasForeignKey("TipoDocumentoId")
                        .HasConstraintName("FK_Clientes_TiposDocumento");

                    b.Navigation("Domicilio");

                    b.Navigation("TipoDocumento");
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.DetallePedido", b =>
                {
                    b.HasOne("GestionComercial.Data.Entidades.Pedido", "Pedido")
                        .WithMany("DetallesPedidos")
                        .HasForeignKey("PedidoId")
                        .IsRequired()
                        .HasConstraintName("FK_DetallesPedido_Pedidos");

                    b.HasOne("GestionComercial.Data.Entidades.Producto", "Producto")
                        .WithMany("DetallesPedido")
                        .HasForeignKey("ProductoId")
                        .IsRequired()
                        .HasConstraintName("FK_DetallesPedido_Productos");

                    b.Navigation("Pedido");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.Domicilio", b =>
                {
                    b.HasOne("GestionComercial.Data.Entidades.Localidad", "Localidad")
                        .WithMany("Domicilios")
                        .HasForeignKey("LocalidadId")
                        .HasConstraintName("FK_Domicilios_Localidades");

                    b.Navigation("Localidad");
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.Localidad", b =>
                {
                    b.HasOne("GestionComercial.Data.Entidades.Provincia", "Provincia")
                        .WithMany("Localidades")
                        .HasForeignKey("ProvinciaId")
                        .IsRequired()
                        .HasConstraintName("FK_Localidades_Provincias");

                    b.Navigation("Provincia");
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.Pedido", b =>
                {
                    b.HasOne("GestionComercial.Data.Entidades.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("ClienteId")
                        .IsRequired()
                        .HasConstraintName("FK_Pedidos_Clientes");

                    b.HasOne("GestionComercial.Data.Entidades.Domicilio", "DomicilioIdEntregaNavigation")
                        .WithOne("Pedido")
                        .HasForeignKey("GestionComercial.Data.Entidades.Pedido", "DomicilioIdEntrega")
                        .IsRequired()
                        .HasConstraintName("FK_Pedidos_Domicilios");

                    b.HasOne("GestionComercial.Data.Entidades.Vendedor", "Vendedor")
                        .WithMany("Pedidos")
                        .HasForeignKey("VendedorId")
                        .IsRequired()
                        .HasConstraintName("FK_Pedidos_Vendedores");

                    b.Navigation("Cliente");

                    b.Navigation("DomicilioIdEntregaNavigation");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.Producto", b =>
                {
                    b.HasOne("GestionComercial.Data.Entidades.Categoria", "Categoria")
                        .WithMany("Productos")
                        .HasForeignKey("CategoriaId")
                        .IsRequired()
                        .HasConstraintName("FK_Productos_Categorias");

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.Provincia", b =>
                {
                    b.HasOne("GestionComercial.Data.Entidades.Paises", "Pais")
                        .WithMany("Provincia")
                        .HasForeignKey("PaisId")
                        .IsRequired()
                        .HasConstraintName("FK_Provincias_Paises");

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.Vendedor", b =>
                {
                    b.HasOne("GestionComercial.Data.Entidades.Domicilio", "Domicilio")
                        .WithOne("Vendedore")
                        .HasForeignKey("GestionComercial.Data.Entidades.Vendedor", "DomicilioId")
                        .IsRequired()
                        .HasConstraintName("FK_Vendedores_Domicilios");

                    b.HasOne("GestionComercial.Data.Entidades.TipoDocumento", "TipoDocumento")
                        .WithMany("Vendedores")
                        .HasForeignKey("TipoDocumentoId")
                        .HasConstraintName("FK_Vendedores_TiposDocumento");

                    b.Navigation("Domicilio");

                    b.Navigation("TipoDocumento");
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.Categoria", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.Domicilio", b =>
                {
                    b.Navigation("Cliente");

                    b.Navigation("Pedido");

                    b.Navigation("Vendedore");
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.Localidad", b =>
                {
                    b.Navigation("Domicilios");
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.Paises", b =>
                {
                    b.Navigation("Provincia");
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.Pedido", b =>
                {
                    b.Navigation("DetallesPedidos");
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.Producto", b =>
                {
                    b.Navigation("DetallesPedido");
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.Provincia", b =>
                {
                    b.Navigation("Localidades");
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.TipoDocumento", b =>
                {
                    b.Navigation("Clientes");

                    b.Navigation("Vendedores");
                });

            modelBuilder.Entity("GestionComercial.Data.Entidades.Vendedor", b =>
                {
                    b.Navigation("Pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
