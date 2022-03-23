using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodewarsBackend.Models;
using CodewarsBackend.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace CodewarsBackend.Services.Context
{
    public class DataContext: DbContext
    {
        public DbSet<UserModel> UserInfo { get; set; }

        public DbSet<CohortModel> CohortInfo { get; set; }
        public DbSet<ReserveModel> ReserveInfo { get; set; }
        public DbSet<CompletedModel> CompletedInfo { get; set; }

        public DataContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
           base.OnModelCreating(builder);
            SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            var UserData = new List<UserModel>()
             {
                     new UserModel(){
                         Id = 1,
                        CodewarsName = "Jateen",
                        CohortName ="Season 0",
                        Salt ="6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                        Hash  ="BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                        IsDeleted = false,
                        IsAdmin = true,
                    }, 
                     new UserModel(){
                         Id = 2,
                        CodewarsName = "Angel",
                        CohortName ="Season 2",
                        Salt ="6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                        Hash  ="BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                        IsDeleted = false,
                        IsAdmin = true,
                    }, 
                     new UserModel(){
                         Id = 3,
                        CodewarsName = "alsalmiw",
                        CohortName ="Season 4",
                        Salt ="6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                        Hash  ="BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                        IsDeleted = false,
                        IsAdmin = false,
                    }, 
                     new UserModel(){
                         Id = 4,
                        CodewarsName = "dylanmcfarlin",
                        CohortName ="Season 4",
                        Salt ="6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                        Hash  ="BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                        IsDeleted = false,
                        IsAdmin = false,
                    }, 
                     new UserModel(){
                         Id = 5,
                        CodewarsName = "sespejo",
                        CohortName ="Season 4",
                        Salt ="6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                        Hash  ="BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                        IsDeleted = false,
                        IsAdmin = false,
                    }, 
                     new UserModel(){
                         Id = 6,
                        CodewarsName = "tbarboza",
                        CohortName ="Season 4",
                        Salt ="6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                        Hash  ="BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                        IsDeleted = false,
                        IsAdmin = false,
                    }, 
                    new UserModel(){
                         Id = 7,
                        CodewarsName = "DannyHT_",
                        CohortName ="Season 4",
                        Salt ="6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                        Hash  ="BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                        IsDeleted = false,
                        IsAdmin = false,
                    }, 
                    new UserModel(){
                         Id = 8,
                        CodewarsName = "D2TheB",
                        CohortName ="Season 4",
                        Salt ="6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                        Hash  ="BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                        IsDeleted = false,
                        IsAdmin = false,
                    }

                };

            builder.Entity<UserModel>().HasData(UserData);

            var ReserveData = new List<ReserveModel>()
             {
                     new ReserveModel(){
                         Id = 1,
                        CohortId=4,
                        KataId="5921c0bc6b8f072e840000c0",
                        CodewarsName ="dylanmcfarlin",
                        KataName ="Sequence classifier",
                        KataLink ="https://www.codewars.com/kata/5921c0bc6b8f072e840000c0",
                        KataLanguage ="javascript",
                        IsCompleted =false,
                        IsDeleted =false
                    },
                    new ReserveModel(){
                         Id = 2,
                        CohortId=4,
                        KataId="541c8630095125aba6000c00",
                        CodewarsName ="dylanmcfarlin",
                        KataName ="Sum of Digits / Digital Root",
                        KataLink ="https://www.codewars.com/kata/541c8630095125aba6000c00",
                        KataLanguage ="javascript",
                        IsCompleted =false,
                        IsDeleted =false
                    },
                    new ReserveModel(){
                         Id = 3,
                        CohortId=4,
                        KataId="59922ce23bfe2c10d7000057",
                        CodewarsName ="dylanmcfarlin",
                        KataName ="FIRE and FURY",
                        KataLink ="https://www.codewars.com/kata/59922ce23bfe2c10d7000057",
                        KataLanguage ="javascript",
                        IsCompleted =false,
                        IsDeleted =false
                    },
                    new ReserveModel(){
                         Id = 4,
                        CohortId=4,
                        KataId="557cd6882bfa3c8a9f0000c1",
                        CodewarsName ="tbarboza",
                        KataName ="Parse nice int from char problem",
                        KataLink ="https://www.codewars.com/kata/557cd6882bfa3c8a9f0000c1",
                        KataLanguage ="javascript",
                        IsCompleted =false,
                        IsDeleted =false
                    },
                    new ReserveModel(){
                         Id = 5,
                        CohortId=4,
                        KataId="5779f894ec8832493f00002d",
                        CodewarsName ="tbarboza",
                        KataName ="Calculate Fibonacci return count of digit occurrences",
                        KataLink ="https://www.codewars.com/kata/5779f894ec8832493f00002d",
                        KataLanguage ="javascript",
                        IsCompleted =false,
                        IsDeleted =false
                    },
                    new ReserveModel(){
                         Id = 6,
                        CohortId=4,
                        KataId="5629db57620258aa9d000014",
                        CodewarsName ="DannyHT_",
                        KataName ="Strings Mix",
                        KataLink ="https://www.codewars.com/kata/5629db57620258aa9d000014",
                        KataLanguage ="javascript",
                        IsCompleted =false,
                        IsDeleted =false
                    }
            };

           builder.Entity<ReserveModel>().HasData(ReserveData);

            var CohortData = new List<CohortModel>()
             {
                     new CohortModel(){
                        Id = 1,
                        CohortName = "Season 1",
                        LvlDifficulty = 2,
                        DateCreated  ="3/22/19",
                        IsArchived = true,
                    }, 
                     new CohortModel(){
                        Id = 2,
                        CohortName = "Season 2",
                        LvlDifficulty = 3,
                        DateCreated  ="3/22/20",
                        IsArchived = true,
                    }, 
                     new CohortModel(){
                        Id = 3,
                        CohortName = "Season 3",
                        LvlDifficulty = 5,
                        DateCreated  ="3/22/21",
                        IsArchived = false,
                    }, 
                    new CohortModel(){
                        Id = 4,
                        CohortName = "Season 4",
                        LvlDifficulty = 7,
                        DateCreated  ="3/22/22",
                        IsArchived = false,
                    },
            };
            builder.Entity<CohortModel>().HasData(CohortData);

                        var CompletedData = new List<CompletedModel>()
             {
                     new CompletedModel(){
                        Id = 1,
                        CohortId = 4,
                        CodewarsName = "sespejo",
                        KataId = "511f11d355fe575d2c000001",
                        KataName  ="Two Oldest Ages",
                        KataLink = "https://www.codewars.com/kata/511f11d355fe575d2c000001",
                        KataLanguage = "JavaScript"
                    }, 
                     new CompletedModel(){
                        Id = 2,
                        CohortId = 4,
                        CodewarsName = "tbarboza",
                        KataId = "5813d19765d81c592200001a",
                        KataName  ="Don't give me five!",
                        KataLink = "https://www.codewars.com/kata/5813d19765d81c592200001a",
                        KataLanguage = "JavaScript"
                    }, 
                     new CompletedModel(){
                        Id = 3,
                        CohortId = 2,
                        CodewarsName = "Angel",
                        KataId = "563cf89eb4747c5fb100001b",
                        KataName  ="Remove the minimum",
                        KataLink = "https://www.codewars.com/kata/563cf89eb4747c5fb100001b",
                        KataLanguage = "JavaScript"
                    }, 
            };
            builder.Entity<CompletedModel>().HasData(CompletedData);

        }








    }
            
}
    
