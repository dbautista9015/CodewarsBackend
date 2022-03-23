using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodewarsBackend.Migrations
{
    public partial class droppedAndMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "KataId",
                table: "ReserveInfo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CodewarsName", "CohortId", "KataId", "KataLanguage", "KataLink", "KataName" },
                values: new object[] { "dylanmcfarlin", 4, "5921c0bc6b8f072e840000c0", "javascript", "https://www.codewars.com/kata/5921c0bc6b8f072e840000c0", "Sequence classifier" });

            migrationBuilder.InsertData(
                table: "ReserveInfo",
                columns: new[] { "Id", "CodewarsName", "CohortId", "IsCompleted", "IsDeleted", "KataId", "KataLanguage", "KataLink", "KataName" },
                values: new object[,]
                {
                    { 2, "dylanmcfarlin", 4, false, false, "541c8630095125aba6000c00", "javascript", "https://www.codewars.com/kata/541c8630095125aba6000c00", "Sum of Digits / Digital Root" },
                    { 3, "dylanmcfarlin", 4, false, false, "59922ce23bfe2c10d7000057", "javascript", "https://www.codewars.com/kata/59922ce23bfe2c10d7000057", "FIRE and FURY" },
                    { 4, "tbarboza", 4, false, false, "557cd6882bfa3c8a9f0000c1", "javascript", "https://www.codewars.com/kata/557cd6882bfa3c8a9f0000c1", "Parse nice int from char problem" },
                    { 5, "tbarboza", 4, false, false, "5779f894ec8832493f00002d", "javascript", "https://www.codewars.com/kata/5779f894ec8832493f00002d", "Calculate Fibonacci return count of digit occurrences" },
                    { 6, "DannyHT_", 4, false, false, "5629db57620258aa9d000014", "javascript", "https://www.codewars.com/kata/5629db57620258aa9d000014", "Strings Mix" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<int>(
                name: "KataId",
                table: "ReserveInfo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ReserveInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CodewarsName", "CohortId", "KataId", "KataLanguage", "KataLink", "KataName" },
                values: new object[] { "", 3, 0, "", "", "" });
        }
    }
}
