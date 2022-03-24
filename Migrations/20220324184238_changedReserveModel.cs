using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodewarsBackend.Migrations
{
    public partial class changedReserveModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CohortId",
                table: "ReserveInfo");

            migrationBuilder.AddColumn<string>(
                name: "CohortName",
                table: "ReserveInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 1,
                column: "CohortName",
                value: "Season 4");

            migrationBuilder.UpdateData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 2,
                column: "CohortName",
                value: "Season 4");

            migrationBuilder.UpdateData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 3,
                column: "CohortName",
                value: "Season 4");

            migrationBuilder.UpdateData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 4,
                column: "CohortName",
                value: "Season 4");

            migrationBuilder.UpdateData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 5,
                column: "CohortName",
                value: "Season 4");

            migrationBuilder.UpdateData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 6,
                column: "CohortName",
                value: "Season 4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CohortName",
                table: "ReserveInfo");

            migrationBuilder.AddColumn<int>(
                name: "CohortId",
                table: "ReserveInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 1,
                column: "CohortId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 2,
                column: "CohortId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 3,
                column: "CohortId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 4,
                column: "CohortId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 5,
                column: "CohortId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 6,
                column: "CohortId",
                value: 4);
        }
    }
}
