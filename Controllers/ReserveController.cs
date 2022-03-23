using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodewarsBackend.Models;
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

        [HttpPost("CreateReservation")]

        public bool CreateReservation(ReserveModel newReservation)
        {
            return _data.CreateReservation(newReservation);
        }

        [HttpPost("ChangeReservationCompletedStatus/{id}")]
        public bool ChangeReservationCompletedStatus(int id)
        {
            return _data.ChangeReservationCompletedStatus(id);
        }

        [HttpGet("GetAllReservations")]
        public IEnumerable<ReserveModel>GetAllReservations()
        {
            return _data.GetAllReservations();
        }

        [HttpGet("GetReservationById/{id}")]
        public ReserveModel GetReservationById(int id)
        {
            return _data.GetReservationById(id);
        }

        [HttpGet("GetReservationByUsername/{username}")]
        public IEnumerable<ReserveModel> GetReservationsByUsername(string username)
        {
            return _data.GetReservationsByUsername(username);
        }

        [HttpGet("GetAllCompletedKataReservations")]
        public IEnumerable<ReserveModel> GetAllCompletedKataReservations()
        {
            return _data.GetAllCompletedKataReservations();
        }

        [HttpGet("GetAllCompletedKatasByCohortId/{id}")]
        public IEnumerable<ReserveModel> GetAllCompletedKatasByCohortId(int id)
        {
            return _data.GetAllCompletedKatasByCohortId(id);
        }

        [HttpGet("GetReservedKatasByCohortId/{id}")]
        public IEnumerable<ReserveModel>GetReservedKatasByCohortId(int id)
        {
            return _data.GetReservedKatasByCohortId(id);
        }

        [HttpGet("GetReservedKatasByKataLanguage/{kataLanguage}")]
        public IEnumerable<ReserveModel>GetReservedKatasByKataLanguage(string? kataLanguage)
        {
            return _data.GetReservedKatasByKataLanguage(kataLanguage);
        }

    }
}