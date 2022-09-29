﻿// <auto-generated />
using System;
using Commerce.Data.Engine.Core.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Commerce.Panel.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Commerce.Data.Engine.Entity.Designer.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<Guid?>("UpdatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0b891358-3054-4e9f-b3c3-e112143ba19f"),
                            CreatedById = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "P1",
                            Price = 100f
                        },
                        new
                        {
                            Id = new Guid("f5a61422-7388-4e40-b8fc-6270988aaf2d"),
                            CreatedById = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "P2",
                            Price = 1010.52f
                        },
                        new
                        {
                            Id = new Guid("4e0ddf67-c65b-4ed7-bfce-ff40cab46362"),
                            CreatedById = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "P3",
                            Price = 25f
                        });
                });

            modelBuilder.Entity("Commerce.Data.Engine.Entity.Designer.Product+Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UpdatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Product.Comment");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1a33696d-7550-4941-9f7a-f24684f22b25"),
                            CreatedById = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("f5a61422-7388-4e40-b8fc-6270988aaf2d"),
                            Text = "TEST COMMENT",
                            UserId = new Guid("b6292ff4-7024-4048-9e8a-08daa1c1b7a6")
                        },
                        new
                        {
                            Id = new Guid("e9746740-d12a-4cae-ad0e-fb2d6b378c1a"),
                            CreatedById = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("f5a61422-7388-4e40-b8fc-6270988aaf2d"),
                            Text = "TEST COMMENT2",
                            UserId = new Guid("b6292ff4-7024-4048-9e8a-08daa1c1b7a6")
                        },
                        new
                        {
                            Id = new Guid("9246cc83-4f1c-4ca0-be9b-272d96776dcc"),
                            CreatedById = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("f5a61422-7388-4e40-b8fc-6270988aaf2d"),
                            Text = "TEST COMMENT3",
                            UserId = new Guid("b6292ff4-7024-4048-9e8a-08daa1c1b7a6")
                        });
                });

            modelBuilder.Entity("Commerce.Data.Engine.Entity.Designer.Product+Feature", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UpdatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("Id", "Name", "Value");

                    b.ToTable("Product.Feature");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dc7cdec6-5aff-4df4-a379-6437da8fc580"),
                            CreatedById = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Wheels",
                            ProductId = new Guid("0b891358-3054-4e9f-b3c3-e112143ba19f"),
                            Value = "4"
                        },
                        new
                        {
                            Id = new Guid("0ffc9c8c-e647-4e2a-86aa-73d7d6fd70fa"),
                            CreatedById = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Color",
                            ProductId = new Guid("0b891358-3054-4e9f-b3c3-e112143ba19f"),
                            Value = "Blue"
                        },
                        new
                        {
                            Id = new Guid("f776561c-b01a-492f-bbe6-92e301711dee"),
                            CreatedById = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Color",
                            ProductId = new Guid("f5a61422-7388-4e40-b8fc-6270988aaf2d"),
                            Value = "Red"
                        },
                        new
                        {
                            Id = new Guid("46466fb0-5eff-44ca-a93c-9fc3049ed476"),
                            CreatedById = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "PSU",
                            ProductId = new Guid("f5a61422-7388-4e40-b8fc-6270988aaf2d"),
                            Value = "600W"
                        },
                        new
                        {
                            Id = new Guid("49fb04e9-face-4cb7-976b-d6f268d5effa"),
                            CreatedById = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Fan Number",
                            ProductId = new Guid("f5a61422-7388-4e40-b8fc-6270988aaf2d"),
                            Value = "4"
                        },
                        new
                        {
                            Id = new Guid("7199e74e-9c7b-434c-801f-dbd5632493ec"),
                            CreatedById = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Color",
                            ProductId = new Guid("4e0ddf67-c65b-4ed7-bfce-ff40cab46362"),
                            Value = "Black"
                        });
                });

            modelBuilder.Entity("Commerce.Data.Engine.Entity.Designer.Product+Sale", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("FeatureId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("SaleEnd")
                        .HasColumnType("datetime2");

                    b.Property<short>("SalePercent")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("SaleStart")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FeatureId");

                    b.HasIndex("ProductId");

                    b.ToTable("Product.Sale");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ae4345e0-c9c6-45a5-b1e8-d0f8a6112cdb"),
                            CreatedById = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FeatureId = new Guid("0ffc9c8c-e647-4e2a-86aa-73d7d6fd70fa"),
                            IsActive = true,
                            ProductId = new Guid("0b891358-3054-4e9f-b3c3-e112143ba19f"),
                            SaleEnd = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SalePercent = (short)19,
                            SaleStart = new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Commerce.Data.Engine.Entity.Designer.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessLevel")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<Guid?>("UpdatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("3043cb1e-16e1-4753-a9db-483193ab9fb5"),
                            AccessLevel = 0,
                            ConcurrencyStamp = "0dc682ad-c74a-4bf9-98d9-0d1a0a67f020",
                            CreatedById = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Customer",
                            NormalizedName = "Customer"
                        },
                        new
                        {
                            Id = new Guid("48923ab3-cc79-4342-b7d9-9fc5036630ef"),
                            AccessLevel = 1,
                            ConcurrencyStamp = "4907d6dc-2986-4e03-8669-a178ab6cc0df",
                            CreatedById = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Admin",
                            NormalizedName = "Admin"
                        },
                        new
                        {
                            Id = new Guid("f960f98e-d5bb-49ed-b0c4-acdd214b22c4"),
                            AccessLevel = 2,
                            ConcurrencyStamp = "137c1876-e230-43c2-a673-93dbda627ace",
                            CreatedById = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "SysAdmin",
                            NormalizedName = "System Admin"
                        });
                });

            modelBuilder.Entity("Commerce.Data.Engine.Entity.Designer.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UpdatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId", "ProductId")
                        .IsUnique();

                    b.ToTable("Transaction");

                    b.HasData(
                        new
                        {
                            Id = new Guid("974a4c34-74f3-4e8c-8e5e-6501e58c3de6"),
                            CreatedById = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 81f,
                            ProductId = new Guid("0b891358-3054-4e9f-b3c3-e112143ba19f"),
                            UserId = new Guid("06bc291c-dcf9-492f-a2ed-4d2f3b6e87d7")
                        });
                });

            modelBuilder.Entity("Commerce.Data.Engine.Entity.Designer.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<Guid?>("UpdatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("PasswordHash");

                    b.HasIndex("UserName", "Email")
                        .IsUnique()
                        .HasFilter("[UserName] IS NOT NULL AND [Email] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("b6292ff4-7024-4048-9e8a-08daa1c1b7a6"),
                            AccessFailedCount = 0,
                            Company = "C1",
                            ConcurrencyStamp = "4b411df5-f4fc-409b-8f58-4172052e0234",
                            CreatedById = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "email@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "name",
                            PasswordHash = "AQAAAAEAACcQAAAAEOnI7tNh7Qe5hx8AdXKJbNwUpEkkzCg/qOVo6v3XIrToOqO3vLVFX9mChhmZAe/Z/g==",
                            PhoneNumberConfirmed = false,
                            Surname = "surname",
                            TwoFactorEnabled = false,
                            UserName = "UNAME1"
                        },
                        new
                        {
                            Id = new Guid("01dccae9-031e-4322-8e2b-2c2c71dc995c"),
                            AccessFailedCount = 0,
                            Company = "C2",
                            ConcurrencyStamp = "48a5d163-09a6-4842-9fab-b6827f866a1b",
                            CreatedById = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "email2@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "name",
                            PasswordHash = "AQAAAAEAACcQAAAAEOnI7tNh7Qe5hx8AdXKJbNwUpEkkzCg/qOVo6v3XIrToOqO3vLVFX9mChhmZAe/Z/g==",
                            PhoneNumberConfirmed = false,
                            Surname = "surname",
                            TwoFactorEnabled = false,
                            UserName = "UNAME2"
                        },
                        new
                        {
                            Id = new Guid("06bc291c-dcf9-492f-a2ed-4d2f3b6e87d7"),
                            AccessFailedCount = 0,
                            Company = "C3",
                            ConcurrencyStamp = "5ed00ed8-e99a-4dfe-b60f-cddb3d54d120",
                            CreatedById = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "email1@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "name",
                            PasswordHash = "AQAAAAEAACcQAAAAEOnI7tNh7Qe5hx8AdXKJbNwUpEkkzCg/qOVo6v3XIrToOqO3vLVFX9mChhmZAe/Z/g==",
                            PhoneNumberConfirmed = false,
                            Surname = "surname",
                            TwoFactorEnabled = false,
                            UserName = "UNAME3"
                        });
                });

            modelBuilder.Entity("Commerce.Data.Engine.Entity.Designer.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UpdatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId", "RoleId")
                        .IsUnique();

                    b.ToTable("User.Role");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5b97efc1-4356-4d0a-b2a3-10ec639ebf33"),
                            CreatedById = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = new Guid("f960f98e-d5bb-49ed-b0c4-acdd214b22c4"),
                            UserId = new Guid("b6292ff4-7024-4048-9e8a-08daa1c1b7a6")
                        },
                        new
                        {
                            Id = new Guid("31a7f0f3-8672-41c0-a3da-c7deff52bf76"),
                            CreatedById = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = new Guid("48923ab3-cc79-4342-b7d9-9fc5036630ef"),
                            UserId = new Guid("01dccae9-031e-4322-8e2b-2c2c71dc995c")
                        },
                        new
                        {
                            Id = new Guid("120395fe-5323-4512-afdf-18f4c5ff208b"),
                            CreatedById = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = new Guid("3043cb1e-16e1-4753-a9db-483193ab9fb5"),
                            UserId = new Guid("06bc291c-dcf9-492f-a2ed-4d2f3b6e87d7")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Commerce.Data.Engine.Entity.Designer.Product+Comment", b =>
                {
                    b.HasOne("Commerce.Data.Engine.Entity.Designer.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Commerce.Data.Engine.Entity.Designer.User", "User")
                        .WithMany("UserComments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Commerce.Data.Engine.Entity.Designer.Product+Feature", b =>
                {
                    b.HasOne("Commerce.Data.Engine.Entity.Designer.Product", "Product")
                        .WithMany("Features")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Commerce.Data.Engine.Entity.Designer.Product+Sale", b =>
                {
                    b.HasOne("Commerce.Data.Engine.Entity.Designer.Product+Feature", "Feature")
                        .WithMany("Sales")
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Commerce.Data.Engine.Entity.Designer.Product", "Product")
                        .WithMany("Sales")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Feature");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Commerce.Data.Engine.Entity.Designer.Transaction", b =>
                {
                    b.HasOne("Commerce.Data.Engine.Entity.Designer.Product", "Product")
                        .WithMany("Transactions")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Commerce.Data.Engine.Entity.Designer.User", "User")
                        .WithMany("Transactions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Commerce.Data.Engine.Entity.Designer.UserRole", b =>
                {
                    b.HasOne("Commerce.Data.Engine.Entity.Designer.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Commerce.Data.Engine.Entity.Designer.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Commerce.Data.Engine.Entity.Designer.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Commerce.Data.Engine.Entity.Designer.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Commerce.Data.Engine.Entity.Designer.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Commerce.Data.Engine.Entity.Designer.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Commerce.Data.Engine.Entity.Designer.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Commerce.Data.Engine.Entity.Designer.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Commerce.Data.Engine.Entity.Designer.Product", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Features");

                    b.Navigation("Sales");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("Commerce.Data.Engine.Entity.Designer.Product+Feature", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("Commerce.Data.Engine.Entity.Designer.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Commerce.Data.Engine.Entity.Designer.User", b =>
                {
                    b.Navigation("Transactions");

                    b.Navigation("UserComments");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
