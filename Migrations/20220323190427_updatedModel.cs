using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodewarsBackend.Migrations
{
    public partial class updatedModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KataSlug",
                table: "CompletedInfo",
                newName: "KataId");

            migrationBuilder.InsertData(
                table: "CompletedInfo",
                columns: new[] { "Id", "CodewarsName", "CohortId", "KataId", "KataLanguage", "KataLink", "KataName" },
                values: new object[,]
                {
                    { 1, "sespejo", 4, "511f11d355fe575d2c000001", "JavaScript", "https://www.codewars.com/kata/511f11d355fe575d2c000001", "Two Oldest Ages" },
                    { 2, "tbarboza", 4, "5813d19765d81c592200001a", "JavaScript", "https://www.codewars.com/kata/5813d19765d81c592200001a", "Don't give me five!" },
                    { 3, "Angel", 2, "563cf89eb4747c5fb100001b", "JavaScript", "https://www.codewars.com/kata/563cf89eb4747c5fb100001b", "Remove the minimum" }
                });

            migrationBuilder.UpdateData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 6,
                column: "CohortName",
                value: "Season 4");

            migrationBuilder.UpdateData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 7,
                column: "CohortName",
                value: "Season 4");

            migrationBuilder.UpdateData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 8,
                column: "CohortName",
                value: "Season 4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompletedInfo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CompletedInfo",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CompletedInfo",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "KataId",
                table: "CompletedInfo",
                newName: "KataSlug");

            migrationBuilder.UpdateData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 6,
                column: "CohortName",
                value: "Season 3");

            migrationBuilder.UpdateData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 7,
                column: "CohortName",
                value: "Season 3");

            migrationBuilder.UpdateData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 8,
                column: "CohortName",
                value: "Season 3");
        }
    }
}
