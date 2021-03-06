using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodewarsBackend.Models
{
    public class ReserveModel
    {
        public int Id { get; set; }
        public string? KataId { get; set; }
        public string? CodewarsName { get; set; }
        public string? CohortName { get; set; }
        public string? KataName { get; set; }
        public int KataLevel { get; set; }
        public string? KataLink { get; set; }
        public string? KataLanguage { get; set; }
        public string? DateAdded { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsDeleted { get; set; }

        public ReserveModel(){}
    }
}