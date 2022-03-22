using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodewarsBackend.Models;
using CodewarsBackend.Services;

namespace CodewarsBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CohortController : ControllerBase
    {
        private readonly CohortService _data;

        public CohortController(CohortService dataFromService) {
         _data = dataFromService;
        }

        //add a new cohort
        [HttpPost("AddCohort")]
        public bool AddCohort(CohortModel newCohortModel)
        {
            return _data.AddCohort(newCohortModel);
        }
    }
}