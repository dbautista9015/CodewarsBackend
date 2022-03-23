using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodewarsBackend.Models.DTO
{
    public class CreateAccountDTO
    {
        public int Id { get; set; }
        public string? CodewarsName { get; set; }
        public string? Password { get; set; }
        public string? CohortName { get; set; }
    }
}