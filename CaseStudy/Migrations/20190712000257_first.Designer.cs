﻿// <auto-generated />
using CaseStudy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CaseStudy.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190712000257_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CaseStudy.Models.Brands", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("CaseStudy.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandsId");

                    b.Property<decimal>("CostPrice")
                        .HasColumnType("money");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<string>("GraphicName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<decimal>("MSRP")
                        .HasColumnType("money");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("QtyOnBackOrder");

                    b.Property<int>("QtyOnHand");

                    b.HasKey("Id");

                    b.HasIndex("BrandsId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CaseStudy.Models.Products", b =>
                {
                    b.HasOne("CaseStudy.Models.Brands", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}