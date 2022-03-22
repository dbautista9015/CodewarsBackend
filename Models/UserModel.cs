using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodewarsBackend.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string? CodewarsName { get; set; }
        public string? CohortName { get; set; }
        public string? Salt { get; set; }
        public string? Hash { get; set; } 
        public bool IsDeleted { get; set; }
        public bool IsAdmin { get; set; }
        public UserModel(){}
    }
}