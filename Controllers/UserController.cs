using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodewarsBackend.Models.DTO;
using CodewarsBackend.Models;
using CodewarsBackend.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodewarsBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _data;

        public UserController(UserService dataFromService)
        {
            _data=dataFromService;
        }

        [HttpPost("AddUser")]
          public bool AddUser(CreateAccountDTO UserToAdd)
        {
            return _data.AddUser(UserToAdd);
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginDTO User)
        {
            return _data.Login(User);
        }

          [HttpGet("GetAllUsers")]
        public IEnumerable<UserModel> GetAllUsers()
        {
            return _data.GetAllUsers();
        }

        [HttpPost("DeleteUser/{username}")]

        public bool DeleteUser(string? username)
        {
            return _data.DeleteUser(username);
        }

        [HttpPost("AdminStatus/{username}")]
        public bool ChangeAdminStatus(string?username)
        {
            return _data.ChangeAdminStatus(username);
        }

        [HttpGet("GetUsersByCohort/{cohortName}")]

        public IEnumerable<UserModel> GetUsersByCohort(string? cohortName)      
        {
            return _data.GetUsersByCohort(cohortName);
        }

        [HttpGet("GetUserByUsername/{username}")]
        public UserModel GetUserByUsername(string?username)
        {
            return _data.GetUserByUsername(username);
        }

    }
}