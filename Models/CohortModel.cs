using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodewarsBackend.Models
{
    public class CohortModel
    {
        public int Id { get; set; }
        public int LvlDifficulty { get; set; }
        public string DateCreated { get; set; }
        public bool IsArchived { get; set; }

         public CohortModel(){}
    }
}