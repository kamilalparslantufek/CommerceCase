using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commerce.Panel.Migrations
{
    public partial class TableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_UserId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Product_ProductId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Feature_Product_ProductId",
                table: "Feature");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Feature_FeatureId",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Product_ProductId",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_AspNetRoles_RoleId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_AspNetUsers_UserId",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sale",
                table: "Sale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Feature",
                table: "Feature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.RenameTable(
                name: "UserRole",
                newName: "User.Role");

            migrationBuilder.RenameTable(
                name: "Sale",
                newName: "Product.Sale");

            migrationBuilder.RenameTable(
                name: "Feature",
                newName: "Product.Feature");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Product.Comment");

            migrationBuilder.RenameIndex(
                name: "IX_UserRole_UserId_RoleId",
                table: "User.Role",
                newName: "IX_User.Role_UserId_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRole_RoleId",
                table: "User.Role",
                newName: "IX_User.Role_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Sale_ProductId",
                table: "Product.Sale",
                newName: "IX_Product.Sale_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Sale_FeatureId",
                table: "Product.Sale",
                newName: "IX_Product.Sale_FeatureId");

            migrationBuilder.RenameIndex(
                name: "IX_Feature_ProductId",
                table: "Product.Feature",
                newName: "IX_Product.Feature_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_UserId",
                table: "Product.Comment",
                newName: "IX_Product.Comment_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_ProductId",
                table: "Product.Comment",
                newName: "IX_Product.Comment_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User.Role",
                table: "User.Role",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product.Sale",
                table: "Product.Sale",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product.Feature",
                table: "Product.Feature",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product.Comment",
                table: "Product.Comment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product.Comment_AspNetUsers_UserId",
                table: "Product.Comment",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product.Comment_Product_ProductId",
                table: "Product.Comment",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product.Feature_Product_ProductId",
                table: "Product.Feature",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product.Sale_Product_ProductId",
                table: "Product.Sale",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product.Sale_Product.Feature_FeatureId",
                table: "Product.Sale",
                column: "FeatureId",
                principalTable: "Product.Feature",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User.Role_AspNetRoles_RoleId",
                table: "User.Role",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User.Role_AspNetUsers_UserId",
                table: "User.Role",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product.Comment_AspNetUsers_UserId",
                table: "Product.Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Product.Comment_Product_ProductId",
                table: "Product.Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Product.Feature_Product_ProductId",
                table: "Product.Feature");

            migrationBuilder.DropForeignKey(
                name: "FK_Product.Sale_Product_ProductId",
                table: "Product.Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_Product.Sale_Product.Feature_FeatureId",
                table: "Product.Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_User.Role_AspNetRoles_RoleId",
                table: "User.Role");

            migrationBuilder.DropForeignKey(
                name: "FK_User.Role_AspNetUsers_UserId",
                table: "User.Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User.Role",
                table: "User.Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product.Sale",
                table: "Product.Sale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product.Feature",
                table: "Product.Feature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product.Comment",
                table: "Product.Comment");

            migrationBuilder.RenameTable(
                name: "User.Role",
                newName: "UserRole");

            migrationBuilder.RenameTable(
                name: "Product.Sale",
                newName: "Sale");

            migrationBuilder.RenameTable(
                name: "Product.Feature",
                newName: "Feature");

            migrationBuilder.RenameTable(
                name: "Product.Comment",
                newName: "Comment");

            migrationBuilder.RenameIndex(
                name: "IX_User.Role_UserId_RoleId",
                table: "UserRole",
                newName: "IX_UserRole_UserId_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_User.Role_RoleId",
                table: "UserRole",
                newName: "IX_UserRole_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Product.Sale_ProductId",
                table: "Sale",
                newName: "IX_Sale_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Product.Sale_FeatureId",
                table: "Sale",
                newName: "IX_Sale_FeatureId");

            migrationBuilder.RenameIndex(
                name: "IX_Product.Feature_ProductId",
                table: "Feature",
                newName: "IX_Feature_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Product.Comment_UserId",
                table: "Comment",
                newName: "IX_Comment_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Product.Comment_ProductId",
                table: "Comment",
                newName: "IX_Comment_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sale",
                table: "Sale",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Feature",
                table: "Feature",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_UserId",
                table: "Comment",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Product_ProductId",
                table: "Comment",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Feature_Product_ProductId",
                table: "Feature",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Feature_FeatureId",
                table: "Sale",
                column: "FeatureId",
                principalTable: "Feature",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Product_ProductId",
                table: "Sale",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_AspNetRoles_RoleId",
                table: "UserRole",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_AspNetUsers_UserId",
                table: "UserRole",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
