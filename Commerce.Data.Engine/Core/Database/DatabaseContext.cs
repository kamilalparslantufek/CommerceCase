using Commerce.Data.Engine.Core.Context;
using Commerce.Data.Engine.Entity.Designer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Data.Engine.Core.Database
{
    public class DatabaseContext : IdentityDbContext<Entity.Designer.User, Entity.Designer.Role, Guid>, IDatabaseContext
    {
        new public IEntityContext<User> Users => new Entity.User(this);
        new public IEntityContext<Role> Roles => new Entity.Role(this);
        new public IEntityContext<UserRole> UserRoles => new Entity.UserRole(this);
        public IEntityContext<Product> Products => new Entity.Product(this);
        public IEntityContext<Product.Feature> ProductFeatures => new Entity.Product.Feature(this);
        public IEntityContext<Product.Sale> ProductSales => new Entity.Product.Sale(this);
        public IEntityContext<Transaction> Transactions => new Entity.Transaction(this);

        public DatabaseContext(DbContextOptions options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(e =>
            {
            e.HasKey(d => d.Id);
            e.HasIndex(d => d.PasswordHash);
            e.HasIndex(d => new { d.UserName, d.Email }).IsUnique();
            e.HasMany(d => d.UserRoles).WithOne(d => d.User).HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.NoAction);
            e.HasMany(d => d.Transactions).WithOne(d => d.User).HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.NoAction);

                e.HasData(new List<User>
                {
                new User{
                    Id  = Guid.Parse("b6292ff4-7024-4048-9e8a-08daa1c1b7a6"),
                    AccessFailedCount = 0,
                    Company = "C1",
                    CreatedById = Guid.Empty,
                    CreatedDate = DateTime.MinValue,
                    Email = "email@email.com",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAEAACcQAAAAEOnI7tNh7Qe5hx8AdXKJbNwUpEkkzCg/qOVo6v3XIrToOqO3vLVFX9mChhmZAe/Z/g==", //Asdfg12345-
                    Name = "name",
                    Surname = "surname",
                    UserName = "UNAME1",
                    LockoutEnabled = false,
                },
                new User{
                    Id  = Guid.Parse("01dccae9-031e-4322-8e2b-2c2c71dc995c"),
                    AccessFailedCount = 0,
                    Company = "C2",
                    CreatedById = Guid.Empty,
                    CreatedDate = DateTime.MinValue,
                    Email = "email2@email.com",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAEAACcQAAAAEOnI7tNh7Qe5hx8AdXKJbNwUpEkkzCg/qOVo6v3XIrToOqO3vLVFX9mChhmZAe/Z/g==", //Asdfg12345-
                    Name = "name",
                    Surname = "surname",
                    UserName = "UNAME2",
                    LockoutEnabled = false,
                },
                new User{
                    Id  = Guid.Parse("06bc291c-dcf9-492f-a2ed-4d2f3b6e87d7"),
                    AccessFailedCount = 0,
                    Company = "C3",
                    CreatedById = Guid.Empty,
                    CreatedDate = DateTime.MinValue,
                    Email = "email1@email.com",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAEAACcQAAAAEOnI7tNh7Qe5hx8AdXKJbNwUpEkkzCg/qOVo6v3XIrToOqO3vLVFX9mChhmZAe/Z/g==", //Asdfg12345-
                    Name = "name",
                    Surname = "surname",
                    UserName = "UNAME3",
                    LockoutEnabled = false,
                },
                });
            });
            modelBuilder.Entity<Product>(e =>
            {
                e.HasKey(d => d.Id);
                e.HasMany(d => d.Features).WithOne(d => d.Product).HasForeignKey(d => d.ProductId).OnDelete(DeleteBehavior.NoAction);
                e.HasMany(d => d.Comments).WithOne(d => d.Product).HasForeignKey(d => d.ProductId).OnDelete(DeleteBehavior.NoAction);
                e.HasMany(d => d.Sales).WithOne(d => d.Product).HasForeignKey(d => d.ProductId).OnDelete(DeleteBehavior.NoAction);

                e.HasData(new List<Product> { 
                    new Product
                    {
                        Id = Guid.Parse("0B891358-3054-4E9F-B3C3-E112143BA19F"),
                        Name = "P1",
                        Price = 100,
                        CreatedById = Guid.Empty,
                        CreatedDate = DateTime.MinValue
                    },
                     new Product
                    {
                        Id = Guid.Parse("F5A61422-7388-4E40-B8FC-6270988AAF2D"),
                        Name = "P2",
                        Price = 1010.52f,
                        CreatedById = Guid.Empty,
                        CreatedDate = DateTime.MinValue
                    },
                      new Product
                    {
                        Id = Guid.Parse("4E0DDF67-C65B-4ED7-BFCE-FF40CAB46362"),
                        Name = "P3",
                        Price = 25,
                        CreatedById = Guid.Empty,
                        CreatedDate = DateTime.MinValue
                    }
                    });
            });
            modelBuilder.Entity<Product.Feature>(e =>
            {
                e.HasKey(d => d.Id);
                e.HasMany(d => d.Sales).WithOne(d => d.Feature).HasForeignKey(d => d.FeatureId).OnDelete(DeleteBehavior.NoAction);
                e.HasIndex(e => new { e.Id, e.Name, e.Value });

                e.HasData(new List<Product.Feature>
                {
                    new Product.Feature
                    {
                        Id = Guid.Parse("DC7CDEC6-5AFF-4DF4-A379-6437DA8FC580"),
                        Name = "Wheels",
                        Value = "4",
                        ProductId = Guid.Parse("0B891358-3054-4E9F-B3C3-E112143BA19F"),
                        CreatedById = Guid.Empty,
                        CreatedDate = DateTime.MinValue
                    },
                    new Product.Feature
                    {
                        Id = Guid.Parse("0FFC9C8C-E647-4E2A-86AA-73D7D6FD70FA"),
                        Name = "Color",
                        Value = "Blue",
                        ProductId = Guid.Parse("0B891358-3054-4E9F-B3C3-E112143BA19F"),
                        CreatedById = Guid.Empty,
                        CreatedDate = DateTime.MinValue
                    },
                    new Product.Feature
                    {
                        Id = Guid.Parse("F776561C-B01A-492F-BBE6-92E301711DEE"),
                        Name = "Color",
                        Value = "Red",
                        ProductId = Guid.Parse("F5A61422-7388-4E40-B8FC-6270988AAF2D"),
                        CreatedById = Guid.Empty,
                        CreatedDate = DateTime.MinValue
                    },
                    new Product.Feature
                    {
                        Id = Guid.Parse("46466FB0-5EFF-44CA-A93C-9FC3049ED476"),
                        Name = "PSU",
                        Value = "600W",
                        ProductId = Guid.Parse("F5A61422-7388-4E40-B8FC-6270988AAF2D"),
                        CreatedById = Guid.Empty,
                        CreatedDate = DateTime.MinValue
                    },
                    new Product.Feature
                    {
                        Id = Guid.Parse("49FB04E9-FACE-4CB7-976B-D6F268D5EFFA"),
                        Name = "Fan Number",
                        Value = "4",
                        ProductId = Guid.Parse("F5A61422-7388-4E40-B8FC-6270988AAF2D"),
                        CreatedById = Guid.Empty,
                        CreatedDate = DateTime.MinValue
                    },
                    new Product.Feature
                    {
                        Id = Guid.Parse("7199E74E-9C7B-434C-801F-DBD5632493EC"),
                        Name = "Color",
                        Value = "Black",
                        ProductId = Guid.Parse("4E0DDF67-C65B-4ED7-BFCE-FF40CAB46362"),
                        CreatedById = Guid.Empty,
                        CreatedDate = DateTime.MinValue
                    },
                });
            });
            modelBuilder.Entity<Product.Sale>(e =>
            {
                e.HasKey(d => d.Id);
                e.HasData(new List<Product.Sale>
                {
                    new Product.Sale
                    {
                        Id = Guid.Parse("AE4345E0-C9C6-45A5-B1E8-D0F8A6112CDB"),
                        FeatureId = Guid.Parse("0FFC9C8C-E647-4E2A-86AA-73D7D6FD70FA"),
                        ProductId = Guid.Parse("0B891358-3054-4E9F-B3C3-E112143BA19F"),
                        IsActive = true,
                        SalePercent = 19,
                        SaleStart = new DateTime(2022,09,29),
                        SaleEnd = new DateTime(2022,09,30),
                        CreatedById = Guid.Empty,
                        CreatedDate= DateTime.MinValue
                    }
                }) ;
            });
            modelBuilder.Entity<Product.Comment>(e =>
            {
                e.HasKey(d => d.Id);
                e.HasData(new List<Product.Comment>
                {
                    new Product.Comment
                    {
                        Id = Guid.Parse("1a33696d-7550-4941-9f7a-f24684f22b25"),
                        ProductId = Guid.Parse("F5A61422-7388-4E40-B8FC-6270988AAF2D"),
                        UserId = Guid.Parse("b6292ff4-7024-4048-9e8a-08daa1c1b7a6"),
                        Text = "TEST COMMENT",
                        CreatedDate = DateTime.MinValue,
                        CreatedById = Guid.Empty
                    },
                    new Product.Comment
                    {
                        Id = Guid.Parse("e9746740-d12a-4cae-ad0e-fb2d6b378c1a"),
                        ProductId = Guid.Parse("F5A61422-7388-4E40-B8FC-6270988AAF2D"),
                        UserId = Guid.Parse("b6292ff4-7024-4048-9e8a-08daa1c1b7a6"),
                        Text = "TEST COMMENT2",
                        CreatedDate = DateTime.MinValue,
                        CreatedById = Guid.Empty
                    },
                    new Product.Comment
                    {
                        Id = Guid.Parse("9246cc83-4f1c-4ca0-be9b-272d96776dcc"),
                        ProductId = Guid.Parse("F5A61422-7388-4E40-B8FC-6270988AAF2D"),
                        UserId = Guid.Parse("b6292ff4-7024-4048-9e8a-08daa1c1b7a6"),
                        Text = "TEST COMMENT3",
                        CreatedDate = DateTime.MinValue,
                        CreatedById = Guid.Empty
                    }
                });
            });
            modelBuilder.Entity<Role>(e =>
            {
                e.HasKey(d => d.Id);
                e.HasMany(d => d.UserRoles).WithOne(d => d.Role).HasForeignKey(d => d.RoleId).OnDelete(DeleteBehavior.NoAction);
                e.HasData(new List<Role>
                {
                    new Role
                    {
                        Id = Guid.Parse("3043CB1E-16E1-4753-A9DB-483193AB9FB5"),
                        Name = "Customer",
                        AccessLevel = 0,
                        NormalizedName = "Customer",
                        CreatedById = Guid.Empty,
                        CreatedDate = DateTime.MinValue
                    },
                    new Role
                    {
                        Id = Guid.Parse("48923AB3-CC79-4342-B7D9-9FC5036630EF"),
                        Name = "Admin",
                        AccessLevel = 1,
                        NormalizedName = "Admin",
                        CreatedById = Guid.Empty,
                        CreatedDate = DateTime.MinValue
                    },
                    new Role
                    {
                        Id = Guid.Parse("F960F98E-D5BB-49ED-B0C4-ACDD214B22C4"),
                        Name = "SysAdmin",
                        AccessLevel = 2,
                        NormalizedName = "System Admin",
                        CreatedById = Guid.Empty,
                        CreatedDate = DateTime.MinValue
                    }
                });
            });
            modelBuilder.Entity<UserRole>(e => 
            {   e.HasKey(d => d.Id); 
                e.HasIndex(d => new { d.UserId, d.RoleId }).IsUnique();

                e.HasData(new List<UserRole> { 
                    new UserRole
                    {
                        Id = Guid.Parse("5b97efc1-4356-4d0a-b2a3-10ec639ebf33"),
                        CreatedById = Guid.Empty,
                        CreatedDate = DateTime.MinValue,
                        UserId = Guid.Parse("b6292ff4-7024-4048-9e8a-08daa1c1b7a6"),
                        RoleId = Guid.Parse("F960F98E-D5BB-49ED-B0C4-ACDD214B22C4")
                    },
                    new UserRole
                    {
                        Id = Guid.Parse("31a7f0f3-8672-41c0-a3da-c7deff52bf76"),
                        CreatedById = Guid.Empty,
                        CreatedDate = DateTime.MinValue,
                        UserId = Guid.Parse("01dccae9-031e-4322-8e2b-2c2c71dc995c"),
                        RoleId = Guid.Parse("48923AB3-CC79-4342-B7D9-9FC5036630EF")
                    },
                    new UserRole
                    {
                        Id = Guid.Parse("120395fe-5323-4512-afdf-18f4c5ff208b"),
                        CreatedById = Guid.Empty,
                        CreatedDate = DateTime.MinValue,
                        UserId = Guid.Parse("06bc291c-dcf9-492f-a2ed-4d2f3b6e87d7"),
                        RoleId = Guid.Parse("3043CB1E-16E1-4753-A9DB-483193AB9FB5")
                    }
                });
            });
            modelBuilder.Entity<Transaction>(e =>
            {
                e.HasKey(d => d.Id);
                e.HasIndex(d => new { d.UserId, d.ProductId }).IsUnique();
                e.HasData(new List<Transaction>
                {
                    new Transaction
                    {
                        Id = Guid.Parse("974a4c34-74f3-4e8c-8e5e-6501e58c3de6"),
                        CreatedDate = DateTime.MinValue,
                        CreatedById = Guid.Empty,
                        Price = 81,
                        ProductId = Guid.Parse("0B891358-3054-4E9F-B3C3-E112143BA19F"),
                        UserId = Guid.Parse("06bc291c-dcf9-492f-a2ed-4d2f3b6e87d7")
                    }
                });
            });
            base.OnModelCreating(modelBuilder);
        }

        public async Task Migrate()
        {
            if ((await this.Database.GetPendingMigrationsAsync()).Count() > 0)
                await this.Database.MigrateAsync();
        }
    }
}
