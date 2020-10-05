using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeInventory.Migrations
{
    public partial class AddCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Item");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "Item",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_CategoryID",
                table: "Item",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Item_LocationID",
                table: "Item",
                column: "LocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Category_CategoryID",
                table: "Item",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Room_LocationID",
                table: "Item",
                column: "LocationID",
                principalTable: "Room",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Category_CategoryID",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Room_LocationID",
                table: "Item");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropIndex(
                name: "IX_Item_CategoryID",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_LocationID",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "Item");

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
