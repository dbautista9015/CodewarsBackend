using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodewarsBackend.Models;
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

        protected override void onModelCreating(ModuleBuilder builder)
        {
            base.onModelCreating(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            var UserData = new List<UserModel>()
             {
                     new UserModel(){
                         Id = 1,
                        CodewarsName = "Jateen",
                        CohortName ="",
                        Salt ="6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                        Hash  ="BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                        IsDeleted = false,
                        IsAdmin = true,
                    }, 
                     new UserModel(){
                         Id = 2,
                        CodewarsName = "Angel",
                        CohortName ="",
                        Salt ="6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                        Hash  ="BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                        IsDeleted = false,
                        IsAdmin = true,
                    }, 
                     new UserModel(){
                         Id = 3,
                        CodewarsName = "alsalmiw",
                        CohortName ="",
                        Salt ="6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                        Hash  ="BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                        IsDeleted = false,
                        IsAdmin = false,
                    }, 
                     new UserModel(){
                         Id = 4,
                        CodewarsName = "",
                        CohortName ="",
                        Salt ="6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                        Hash  ="BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                        IsDeleted = false,
                        IsAdmin = false,
                    }, 
                     new UserModel(){
                         Id = 5,
                        CodewarsName = "",
                        CohortName ="",
                        Salt ="6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                        Hash  ="BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                        IsDeleted = false,
                        IsAdmin = false,
                    }, 
                     new UserModel(){
                         Id = 6,
                        CodewarsName = "",
                        CohortName ="",
                        Salt ="6oyIFN+J/zb3uaje2+GP98c/WdMgNb9Rwbn3Wyi51i+OUta55QsZFkrTqbJy9hiothKp95mleCPySEZOIOcPIg==",
                        Hash  ="BBvCTG4MF3e0YvDBW7mPkimgpAOpbP7HUkNb8YRmHjM8KdNBKFRRgctlBZV/WZ0GfasEBS8qJCuPB0Z4rOalX0UuAxkqmoBznghkV+lmxmIod+25vzFPjuSYhN7QvWsfPvGf7Ze1w/qG3xQ6KBTgjTc+yKe9bcaQPFBjiYPVnM1RYsUPC3RG47Q27K2xqCOQTtdvaAUEhoDgaCLi3zyi+e750FEZ6e9y1HObs4Zsnl2Yk4AwkFZ8IZBnHlXoDyy1b1ICIG7+CggJdDkiNJxv57BRlNqijDwfE+6vBujqvr7a5kgzWgGoEMBsqLpFNv7j7sIJVBjevmyV3X8eDAY68g==",
                        IsDeleted = false,
                        IsAdmin = false,
                    }, 





                };

            builder.Entity<UserModel>().HasData(UserData);

            var CohortData = new List<CohortModel>()
             {
                     new CohortModel(){
                        Id = 1,
                        CohortName = "Season 1",
                        LvlDifficulty = 2,
                        DateCreated  ="3/22/19",
                        IsArchived = false,
                    }, 
                     new CohortModel(){
                        Id = 2,
                        CohortName = "Season 2",
                        LvlDifficulty = 3,
                        DateCreated  ="3/22/20",
                        IsArchived = false,
                    }, 
                     new CohortModel(){
                        Id = 3,
                        CohortName = "Season 3",
                        LvlDifficulty = 5,
                        DateCreated  ="3/22/21",
                        IsArchived = false,
                    }, 
                    new CohortModel(){
                        Id = 3,
                        CohortName = "Season 4",
                        LvlDifficulty = 7,
                        DateCreated  ="3/22/22",
                        IsArchived = false,
                    },
            };
            builder.Entity<CohortModel>().HasData(CohortData);






        }
            
    }
    
}