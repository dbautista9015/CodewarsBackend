using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodewarsBackend.Migrations
{
    public partial class newMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DateAdded",
                table: "ReserveInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KataLevel",
                table: "ReserveInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "KataLevel" },
                values: new object[] { "02-22-2022", "7 kyu" });

            migrationBuilder.UpdateData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "KataLevel" },
                values: new object[] { "02-22-2022", "7 kyu" });

            migrationBuilder.UpdateData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "KataLevel" },
                values: new object[] { "02-22-2022", "6 kyu" });

            migrationBuilder.UpdateData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "KataLevel" },
                values: new object[] { "02-22-2022", "6 kyu" });

            migrationBuilder.UpdateData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "KataLevel" },
                values: new object[] { "02-22-2022", "5 kyu" });

            migrationBuilder.UpdateData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "KataLevel" },
                values: new object[] { "02-22-2022", "5 kyu" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "ReserveInfo");

            migrationBuilder.DropColumn(
                name: "KataLevel",
                table: "ReserveInfo");
        }
    }
}
