using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodewarsBackend.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodewarsBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReserveController : ControllerBase
    {
        private readonly ReserveService _data;

        public ReserveController(ReserveService dataFromService)
        {
            _data=dataFromService;
        }
    }
}