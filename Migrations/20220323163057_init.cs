using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodewarsBackend.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CohortInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CohortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LvlDifficulty = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CohortInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompletedInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CohortId = table.Column<int>(type: "int", nullable: false),
                    CodewarsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KataName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KataSlug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KataLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KataLanguage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletedInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReserveInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CohortId = table.Column<int>(type: "int", nullable: false),
                    KataId = table.Column<int>(type: "int", nullable: false),
                    CodewarsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KataName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KataLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KataLanguage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReserveInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodewarsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CohortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfo", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CohortInfo",
                columns: new[] { "Id", "CohortName", "DateCreated", "IsArchived", "IsDeleted", "LvlDifficulty" },
                values: new object[,]
                {
                    { 1, "Season 1", "3/22/19", true, false, 2 },
                    { 2, "Season 2", "3/22/20", true, false, 3 },
                    { 3, "Season 3", "3/22/21", false, false, 5 },
                    { 4, "Season 4", "3/22/22", false, false, 7 }
                });

            migrationBuilder.InsertData(
                table: "ReserveInfo",
                columns: new[] { "Id", "CodewarsName", "CohortId", "IsCompleted", "IsDeleted", "KataId", "KataLanguage", "KataLink", "KataName" },
                values: new object[] { 1, "", 3, false, false, 0, "", "", "" });

            migrationBuilder.InsertData(
                table: "UserInfo",
                columns: new[] { "Id", "CodewarsName", "CohortName", "Hash", "IsAdmin", "IsDeleted", "Salt" },
                values: new object[,]
                {
                    { 1, "Jateen", "Season 0", "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==", true, false, "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==" },
                    { 2, "Angel", "Season 2", "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==", true, false, "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==" },
                    { 3, "alsalmiw", "Season 4", "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==", false, false, "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==" },
                    { 4, "dylanmcfarlin", "Season 4", "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==", false, false, "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==" },
                    { 5, "sespejo", "Season 4", "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==", false, false, "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==" },
                    { 6, "tbarboza", "Season 3", "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==", false, false, "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==" },
                    { 7, "DannyHT_", "Season 3", "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==", false, false, "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==" },
                    { 8, "D2TheB", "Season 3", "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==", false, false, "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CohortInfo");

            migrationBuilder.DropTable(
                name: "CompletedInfo");

            migrationBuilder.DropTable(
                name: "ReserveInfo");

            migrationBuilder.DropTable(
                name: "UserInfo");
        }
    }
}
