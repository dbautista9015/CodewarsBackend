﻿// <auto-generated />
using CodewarsBackend.Services.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodewarsBackend.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CodewarsBackend.Models.CohortModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CohortName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateCreated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LvlDifficulty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CohortInfo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CohortName = "Season 1",
                            DateCreated = "3/22/19",
                            IsArchived = true,
                            IsDeleted = false,
                            LvlDifficulty = 2
                        },
                        new
                        {
                            Id = 2,
                            CohortName = "Season 2",
                            DateCreated = "3/22/20",
                            IsArchived = true,
                            IsDeleted = false,
                            LvlDifficulty = 3
                        },
                        new
                        {
                            Id = 3,
                            CohortName = "Season 3",
                            DateCreated = "3/22/21",
                            IsArchived = false,
                            IsDeleted = false,
                            LvlDifficulty = 5
                        },
                        new
                        {
                            Id = 4,
                            CohortName = "Season 4",
                            DateCreated = "3/22/22",
                            IsArchived = false,
                            IsDeleted = false,
                            LvlDifficulty = 7
                        });
                });

            modelBuilder.Entity("CodewarsBackend.Models.CompletedModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CodewarsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CohortId")
                        .HasColumnType("int");

                    b.Property<string>("KataId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KataLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KataLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KataName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CompletedInfo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CodewarsName = "sespejo",
                            CohortId = 4,
                            KataId = "511f11d355fe575d2c000001",
                            KataLanguage = "JavaScript",
                            KataLink = "https://www.codewars.com/kata/511f11d355fe575d2c000001",
                            KataName = "Two Oldest Ages"
                        },
                        new
                        {
                            Id = 2,
                            CodewarsName = "tbarboza",
                            CohortId = 4,
                            KataId = "5813d19765d81c592200001a",
                            KataLanguage = "JavaScript",
                            KataLink = "https://www.codewars.com/kata/5813d19765d81c592200001a",
                            KataName = "Don't give me five!"
                        },
                        new
                        {
                            Id = 3,
                            CodewarsName = "Angel",
                            CohortId = 2,
                            KataId = "563cf89eb4747c5fb100001b",
                            KataLanguage = "JavaScript",
                            KataLink = "https://www.codewars.com/kata/563cf89eb4747c5fb100001b",
                            KataName = "Remove the minimum"
                        });
                });

            modelBuilder.Entity("CodewarsBackend.Models.ReserveModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CodewarsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CohortName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateAdded")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("KataId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KataLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KataLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KataLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KataName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ReserveInfo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CodewarsName = "dylanmcfarlin",
                            CohortName = "Season 4",
                            DateAdded = "02-22-2022",
                            IsCompleted = false,
                            IsDeleted = false,
                            KataId = "5921c0bc6b8f072e840000c0",
                            KataLanguage = "javascript",
                            KataLevel = "7 kyu",
                            KataLink = "https://www.codewars.com/kata/5921c0bc6b8f072e840000c0",
                            KataName = "Sequence classifier"
                        },
                        new
                        {
                            Id = 2,
                            CodewarsName = "dylanmcfarlin",
                            CohortName = "Season 4",
                            DateAdded = "02-22-2022",
                            IsCompleted = false,
                            IsDeleted = false,
                            KataId = "541c8630095125aba6000c00",
                            KataLanguage = "javascript",
                            KataLevel = "7 kyu",
                            KataLink = "https://www.codewars.com/kata/541c8630095125aba6000c00",
                            KataName = "Sum of Digits / Digital Root"
                        },
                        new
                        {
                            Id = 3,
                            CodewarsName = "dylanmcfarlin",
                            CohortName = "Season 4",
                            DateAdded = "02-22-2022",
                            IsCompleted = false,
                            IsDeleted = false,
                            KataId = "59922ce23bfe2c10d7000057",
                            KataLanguage = "javascript",
                            KataLevel = "6 kyu",
                            KataLink = "https://www.codewars.com/kata/59922ce23bfe2c10d7000057",
                            KataName = "FIRE and FURY"
                        },
                        new
                        {
                            Id = 4,
                            CodewarsName = "tbarboza",
                            CohortName = "Season 4",
                            DateAdded = "02-22-2022",
                            IsCompleted = false,
                            IsDeleted = false,
                            KataId = "557cd6882bfa3c8a9f0000c1",
                            KataLanguage = "javascript",
                            KataLevel = "6 kyu",
                            KataLink = "https://www.codewars.com/kata/557cd6882bfa3c8a9f0000c1",
                            KataName = "Parse nice int from char problem"
                        },
                        new
                        {
                            Id = 5,
                            CodewarsName = "tbarboza",
                            CohortName = "Season 4",
                            DateAdded = "02-22-2022",
                            IsCompleted = false,
                            IsDeleted = false,
                            KataId = "5779f894ec8832493f00002d",
                            KataLanguage = "javascript",
                            KataLevel = "5 kyu",
                            KataLink = "https://www.codewars.com/kata/5779f894ec8832493f00002d",
                            KataName = "Calculate Fibonacci return count of digit occurrences"
                        },
                        new
                        {
                            Id = 6,
                            CodewarsName = "DannyHT_",
                            CohortName = "Season 4",
                            DateAdded = "02-22-2022",
                            IsCompleted = false,
                            IsDeleted = false,
                            KataId = "5629db57620258aa9d000014",
                            KataLanguage = "javascript",
                            KataLevel = "5 kyu",
                            KataLink = "https://www.codewars.com/kata/5629db57620258aa9d000014",
                            KataName = "Strings Mix"
                        });
                });

            modelBuilder.Entity("CodewarsBackend.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CodewarsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CohortName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserInfo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CodewarsName = "Jateen",
                            CohortName = "Season 0",
                            Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                            IsAdmin = true,
                            IsDeleted = false,
                            Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg=="
                        },
                        new
                        {
                            Id = 2,
                            CodewarsName = "Angel",
                            CohortName = "Season 2",
                            Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                            IsAdmin = true,
                            IsDeleted = false,
                            Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg=="
                        },
                        new
                        {
                            Id = 3,
                            CodewarsName = "alsalmiw",
                            CohortName = "Season 4",
                            Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                            IsAdmin = false,
                            IsDeleted = false,
                            Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg=="
                        },
                        new
                        {
                            Id = 4,
                            CodewarsName = "dylanmcfarlin",
                            CohortName = "Season 4",
                            Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                            IsAdmin = false,
                            IsDeleted = false,
                            Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg=="
                        },
                        new
                        {
                            Id = 5,
                            CodewarsName = "sespejo",
                            CohortName = "Season 4",
                            Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                            IsAdmin = false,
                            IsDeleted = false,
                            Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg=="
                        },
                        new
                        {
                            Id = 6,
                            CodewarsName = "tbarboza",
                            CohortName = "Season 4",
                            Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                            IsAdmin = false,
                            IsDeleted = false,
                            Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg=="
                        },
                        new
                        {
                            Id = 7,
                            CodewarsName = "DannyHT_",
                            CohortName = "Season 4",
                            Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                            IsAdmin = false,
                            IsDeleted = false,
                            Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg=="
                        },
                        new
                        {
                            Id = 8,
                            CodewarsName = "D2TheB",
                            CohortName = "Season 4",
                            Hash = "BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                            IsAdmin = false,
                            IsDeleted = false,
                            Salt = "6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg=="
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
