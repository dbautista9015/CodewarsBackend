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

        // Get all cohorts from table
        [HttpGet("GetAllCohorts")]
        public IEnumerable<CohortModel> GetAllCohorts()
        {
            return _data.GetAllCohorts();
        }

        // Get a Cohort by the specific id
        [HttpGet("GetCohortById/{id}")]
        public CohortModel GetCohortById(int id)
        {
            return _data.GetCohortById(id);
        }

        // Get a Cohort by cohortName
        [HttpGet("GetCohortByCohortName/{cohortName}")]
        public CohortModel GetCohortByCohortName(string cohortName)
        {
            return _data.GetCohortByCohortName(cohortName);
        }

        // Get archived cohorts
        [HttpGet("GetArchivedCohorts")]
        public IEnumerable<CohortModel> GetArchivedCohorts()
        {
            return _data.GetArchivedCohorts();
        }
    }
}