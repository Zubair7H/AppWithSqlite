// <auto-generated />
using AppWithSqlite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppWithSqlite.Migrations
{
    [DbContext(typeof(ApplicationDBcontext))]
    [Migration("20221212093254_supplier")]
    partial class supplier
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("AppWithSqlite.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Caddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cnumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerId");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("AppWithSqlite.Models.Sellers", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Number")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sallary")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("AppWithSqlite.Models.Supplier", b =>
                {
                    b.Property<int>("supplierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("suppliername")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("supplierphone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("supplierID");

                    b.ToTable("Suppliers");
                });
#pragma warning restore 612, 618
        }
    }
}
