using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodewarsBackend.Models.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string? CodewarsName { get; set; }   
        public string? CohortName { get; set; } 
        public bool IsDeleted { get; set; }
        public bool IsAdmin { get; set; }

    }
}