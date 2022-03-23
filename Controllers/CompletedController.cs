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
    public class CompletedController : ControllerBase
    {
        private readonly CompletedService _data;

        public CompletedController(CompletedService dataFromService) {
         _data = dataFromService;
        }

        //add to completed table
        [HttpPost("AddCompletedKata")]
        public bool AddCompletedKata(CompletedModel newCompletedModel)
        {
            return _data.AddCompletedKata(newCompletedModel);
        }

        // Get all completedKatas from table
        [HttpGet("GetAllCompletedKatas")]
        public IEnumerable<CompletedModel> GetAllCompletedKatas()
        {
            return _data.GetAllCompletedKatas();
        }

        // Get all Completed Katas by the cohortId
        [HttpGet("GetCompletedKatasByCohortId/{cohortId}")]
        public IEnumerable<CompletedModel> GetCompletedKatasByCohortId(int cohortId)
        {
            return _data.GetCompletedKatasByCohortId();
        }

        // Get all Completed Katas by the codewarsName (codewars username)
        [HttpGet("GetCompletedKatasByCodewarsName/{codewarsName}")]
        public IEnumerable<CompletedModel> GetCompletedKatasByCodewarsName(string codewarsName)
        {
            return _data.GetCompletedKatasByCodewarsName();
        }

    }
}