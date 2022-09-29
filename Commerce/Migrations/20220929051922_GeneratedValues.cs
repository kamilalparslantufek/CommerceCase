using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commerce.Panel.Migrations
{
    public partial class GeneratedValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Product.Feature",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product.Feature",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "AccessLevel", "ConcurrencyStamp", "CreatedById", "CreatedDate", "Name", "NormalizedName", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("3043cb1e-16e1-4753-a9db-483193ab9fb5"), 0, "0dc682ad-c74a-4bf9-98d9-0d1a0a67f020", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer", "Customer", null, null },
                    { new Guid("48923ab3-cc79-4342-b7d9-9fc5036630ef"), 1, "4907d6dc-2986-4e03-8669-a178ab6cc0df", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Admin", null, null },
                    { new Guid("f960f98e-d5bb-49ed-b0c4-acdd214b22c4"), 2, "137c1876-e230-43c2-a673-93dbda627ace", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SysAdmin", "System Admin", null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Company", "ConcurrencyStamp", "CreatedById", "CreatedDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UpdatedById", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { new Guid("01dccae9-031e-4322-8e2b-2c2c71dc995c"), 0, "C2", "48a5d163-09a6-4842-9fab-b6827f866a1b", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email2@email.com", true, false, null, "name", null, null, "AQAAAAEAACcQAAAAEOnI7tNh7Qe5hx8AdXKJbNwUpEkkzCg/qOVo6v3XIrToOqO3vLVFX9mChhmZAe/Z/g==", null, false, null, "surname", false, null, null, "UNAME2" },
                    { new Guid("06bc291c-dcf9-492f-a2ed-4d2f3b6e87d7"), 0, "C3", "5ed00ed8-e99a-4dfe-b60f-cddb3d54d120", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email1@email.com", true, false, null, "name", null, null, "AQAAAAEAACcQAAAAEOnI7tNh7Qe5hx8AdXKJbNwUpEkkzCg/qOVo6v3XIrToOqO3vLVFX9mChhmZAe/Z/g==", null, false, null, "surname", false, null, null, "UNAME3" },
                    { new Guid("b6292ff4-7024-4048-9e8a-08daa1c1b7a6"), 0, "C1", "4b411df5-f4fc-409b-8f58-4172052e0234", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email@email.com", true, false, null, "name", null, null, "AQAAAAEAACcQAAAAEOnI7tNh7Qe5hx8AdXKJbNwUpEkkzCg/qOVo6v3XIrToOqO3vLVFX9mChhmZAe/Z/g==", null, false, null, "surname", false, null, null, "UNAME1" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Name", "Price", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0b891358-3054-4e9f-b3c3-e112143ba19f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P1", 100f, null, null },
                    { new Guid("4e0ddf67-c65b-4ed7-bfce-ff40cab46362"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P3", 25f, null, null },
                    { new Guid("f5a61422-7388-4e40-b8fc-6270988aaf2d"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P2", 1010.52f, null, null }
                });

            migrationBuilder.InsertData(
                table: "Product.Comment",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "ProductId", "Text", "UpdatedById", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("1a33696d-7550-4941-9f7a-f24684f22b25"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f5a61422-7388-4e40-b8fc-6270988aaf2d"), "TEST COMMENT", null, null, new Guid("b6292ff4-7024-4048-9e8a-08daa1c1b7a6") },
                    { new Guid("9246cc83-4f1c-4ca0-be9b-272d96776dcc"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f5a61422-7388-4e40-b8fc-6270988aaf2d"), "TEST COMMENT3", null, null, new Guid("b6292ff4-7024-4048-9e8a-08daa1c1b7a6") },
                    { new Guid("e9746740-d12a-4cae-ad0e-fb2d6b378c1a"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f5a61422-7388-4e40-b8fc-6270988aaf2d"), "TEST COMMENT2", null, null, new Guid("b6292ff4-7024-4048-9e8a-08daa1c1b7a6") }
                });

            migrationBuilder.InsertData(
                table: "Product.Feature",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Name", "ProductId", "UpdatedById", "UpdatedDate", "Value" },
                values: new object[,]
                {
                    { new Guid("0ffc9c8c-e647-4e2a-86aa-73d7d6fd70fa"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Color", new Guid("0b891358-3054-4e9f-b3c3-e112143ba19f"), null, null, "Blue" },
                    { new Guid("46466fb0-5eff-44ca-a93c-9fc3049ed476"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PSU", new Guid("f5a61422-7388-4e40-b8fc-6270988aaf2d"), null, null, "600W" },
                    { new Guid("49fb04e9-face-4cb7-976b-d6f268d5effa"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fan Number", new Guid("f5a61422-7388-4e40-b8fc-6270988aaf2d"), null, null, "4" },
                    { new Guid("7199e74e-9c7b-434c-801f-dbd5632493ec"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Color", new Guid("4e0ddf67-c65b-4ed7-bfce-ff40cab46362"), null, null, "Black" },
                    { new Guid("dc7cdec6-5aff-4df4-a379-6437da8fc580"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wheels", new Guid("0b891358-3054-4e9f-b3c3-e112143ba19f"), null, null, "4" },
                    { new Guid("f776561c-b01a-492f-bbe6-92e301711dee"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Color", new Guid("f5a61422-7388-4e40-b8fc-6270988aaf2d"), null, null, "Red" }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Price", "ProductId", "UpdatedById", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("974a4c34-74f3-4e8c-8e5e-6501e58c3de6"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 81f, new Guid("0b891358-3054-4e9f-b3c3-e112143ba19f"), null, null, new Guid("06bc291c-dcf9-492f-a2ed-4d2f3b6e87d7") });

            migrationBuilder.InsertData(
                table: "User.Role",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "RoleId", "UpdatedById", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("120395fe-5323-4512-afdf-18f4c5ff208b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3043cb1e-16e1-4753-a9db-483193ab9fb5"), null, null, new Guid("06bc291c-dcf9-492f-a2ed-4d2f3b6e87d7") },
                    { new Guid("31a7f0f3-8672-41c0-a3da-c7deff52bf76"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48923ab3-cc79-4342-b7d9-9fc5036630ef"), null, null, new Guid("01dccae9-031e-4322-8e2b-2c2c71dc995c") },
                    { new Guid("5b97efc1-4356-4d0a-b2a3-10ec639ebf33"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f960f98e-d5bb-49ed-b0c4-acdd214b22c4"), null, null, new Guid("b6292ff4-7024-4048-9e8a-08daa1c1b7a6") }
                });

            migrationBuilder.InsertData(
                table: "Product.Sale",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "FeatureId", "IsActive", "ProductId", "SaleEnd", "SalePercent", "SaleStart", "UpdatedById", "UpdatedDate" },
                values: new object[] { new Guid("ae4345e0-c9c6-45a5-b1e8-d0f8a6112cdb"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0ffc9c8c-e647-4e2a-86aa-73d7d6fd70fa"), true, new Guid("0b891358-3054-4e9f-b3c3-e112143ba19f"), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), (short)19, new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Product.Feature_Id_Name_Value",
                table: "Product.Feature",
                columns: new[] { "Id", "Name", "Value" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Product.Feature_Id_Name_Value",
                table: "Product.Feature");

            migrationBuilder.DeleteData(
                table: "Product.Comment",
                keyColumn: "Id",
                keyValue: new Guid("1a33696d-7550-4941-9f7a-f24684f22b25"));

            migrationBuilder.DeleteData(
                table: "Product.Comment",
                keyColumn: "Id",
                keyValue: new Guid("9246cc83-4f1c-4ca0-be9b-272d96776dcc"));

            migrationBuilder.DeleteData(
                table: "Product.Comment",
                keyColumn: "Id",
                keyValue: new Guid("e9746740-d12a-4cae-ad0e-fb2d6b378c1a"));

            migrationBuilder.DeleteData(
                table: "Product.Feature",
                keyColumn: "Id",
                keyValue: new Guid("46466fb0-5eff-44ca-a93c-9fc3049ed476"));

            migrationBuilder.DeleteData(
                table: "Product.Feature",
                keyColumn: "Id",
                keyValue: new Guid("49fb04e9-face-4cb7-976b-d6f268d5effa"));

            migrationBuilder.DeleteData(
                table: "Product.Feature",
                keyColumn: "Id",
                keyValue: new Guid("7199e74e-9c7b-434c-801f-dbd5632493ec"));

            migrationBuilder.DeleteData(
                table: "Product.Feature",
                keyColumn: "Id",
                keyValue: new Guid("dc7cdec6-5aff-4df4-a379-6437da8fc580"));

            migrationBuilder.DeleteData(
                table: "Product.Feature",
                keyColumn: "Id",
                keyValue: new Guid("f776561c-b01a-492f-bbe6-92e301711dee"));

            migrationBuilder.DeleteData(
                table: "Product.Sale",
                keyColumn: "Id",
                keyValue: new Guid("ae4345e0-c9c6-45a5-b1e8-d0f8a6112cdb"));

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "Id",
                keyValue: new Guid("974a4c34-74f3-4e8c-8e5e-6501e58c3de6"));

            migrationBuilder.DeleteData(
                table: "User.Role",
                keyColumn: "Id",
                keyValue: new Guid("120395fe-5323-4512-afdf-18f4c5ff208b"));

            migrationBuilder.DeleteData(
                table: "User.Role",
                keyColumn: "Id",
                keyValue: new Guid("31a7f0f3-8672-41c0-a3da-c7deff52bf76"));

            migrationBuilder.DeleteData(
                table: "User.Role",
                keyColumn: "Id",
                keyValue: new Guid("5b97efc1-4356-4d0a-b2a3-10ec639ebf33"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3043cb1e-16e1-4753-a9db-483193ab9fb5"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("48923ab3-cc79-4342-b7d9-9fc5036630ef"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f960f98e-d5bb-49ed-b0c4-acdd214b22c4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01dccae9-031e-4322-8e2b-2c2c71dc995c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("06bc291c-dcf9-492f-a2ed-4d2f3b6e87d7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6292ff4-7024-4048-9e8a-08daa1c1b7a6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4e0ddf67-c65b-4ed7-bfce-ff40cab46362"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f5a61422-7388-4e40-b8fc-6270988aaf2d"));

            migrationBuilder.DeleteData(
                table: "Product.Feature",
                keyColumn: "Id",
                keyValue: new Guid("0ffc9c8c-e647-4e2a-86aa-73d7d6fd70fa"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0b891358-3054-4e9f-b3c3-e112143ba19f"));

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Product.Feature",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product.Feature",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
