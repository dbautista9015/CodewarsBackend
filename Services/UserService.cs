using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodewarsBackend.Models.DTO;
using CodewarsBackend.Models;
using CodewarsBackend.Services.Context;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace CodewarsBackend.Services
{
    public class UserService: ControllerBase
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context=context;
        }

          public bool DoesUserExists(string? username)
        {
            return _context.UserInfo.SingleOrDefault(user => user.CodewarsName == username) != null;
        }

         public PasswordDTO HashPassword(string? password)
        {
            PasswordDTO newHashedPassword = new PasswordDTO();
            byte[] SaltBytes = new byte[64];
            var provider = RandomNumberGenerator.Create();
            provider.GetNonZeroBytes(SaltBytes);
            var Salt = Convert.ToBase64String(SaltBytes);
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, SaltBytes, 10000);
            var HashPassword = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));
            newHashedPassword.Salt = Salt;
            newHashedPassword.Hash = HashPassword;
            return newHashedPassword;
        }

        public UserModel GetUserByUsername(string username)
        {
            return _context.UserInfo.SingleOrDefault(user => user.CodewarsName == username);
        }

        public bool VerifyUserPassword(string? Password, string? StoredHash, string? StoredSalt)
        {
            var SaltBytes = Convert.FromBase64String(StoredSalt);
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(Password, SaltBytes, 10000);
            var newHash = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));
            return newHash == StoredHash;
        }
         public bool AddUser(CreateAccountDTO UserToAdd)
        {
             bool result = false;
            if (!DoesUserExists(UserToAdd.CodewarsName))
            {
                UserModel newUser = new UserModel();
                newUser.Id = 0;
                newUser.CodewarsName = UserToAdd.CodewarsName;
                newUser.CohortName = UserToAdd.CohortName;
                newUser.IsAdmin = UserToAdd.IsAdmin;
                newUser.IsDeleted = false;

                var hashedPassword = HashPassword(UserToAdd.Password);
                newUser.Salt = hashedPassword.Salt;
                newUser.Hash = hashedPassword.Hash;
                
                _context.Add(newUser);

                result = _context.SaveChanges() != 0;
            }
            return result;
        }

        public IActionResult Login([FromBody] LoginDTO User)
        {
                 IActionResult Result = Unauthorized();
            if (DoesUserExists(User.CodewarsName))
            {
                var foundUser = GetUserByUsername(User.CodewarsName);
                var verifyPass = VerifyUserPassword(User.Password, foundUser.Hash, foundUser.Salt);
                if (verifyPass)
                {
                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ILoveToSolveKatasAllDay@209"));
                    var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                    var tokeOptions = new JwtSecurityToken(
                        issuer: "http://localhost:5000",
                        audience: "http://localhost:5000",
                        claims: new List<Claim>(),
                        expires: DateTime.Now.AddMinutes(30),
                        signingCredentials: signinCredentials
                    );
                   
                    
                        var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                        Result = Ok(new { Token = tokenString });
                    
                }
            }
            return Result;

        }
        public IEnumerable<UserModel> GetAllUsers()
        {
                return _context.UserInfo;
        }

        public bool DeleteUser(string? username)
        {
            UserModel foundUser=GetUserByUsername(username);
            bool result=false;
            if(foundUser!=null)
            {
                foundUser.IsDeleted=true;
                _context.Update<UserModel>(foundUser);
                result = _context.SaveChanges()!=0;
            }
            return result;
        }

        public bool ChangeAdminStatus(string?username)
        {
            bool result=false;
            UserModel foundUser=GetUserByUsername(username);
            if(foundUser!=null)
            {
                foundUser.IsAdmin=!foundUser.IsAdmin;
                _context.Update<UserModel>(foundUser);
                result = _context.SaveChanges()!=0;
            }
            return result;
        }

        public IEnumerable<UserModel> GetUsersByCohort(string? cohortName)      
        {
            return _context.UserInfo.Where(item => item.CohortName == cohortName);
        }

        public bool EditCohortForUser(string? username, string? cohortName)
        {
            bool result=false;
            UserModel foundUser=GetUserByUsername(username);
            if(foundUser!=null)
            {
                foundUser.CohortName=cohortName;
                _context.Update<UserModel>(foundUser);
                result = _context.SaveChanges()!=0;
            }
            return result;
        }

        //   public UserModel GetUserByUsername(string?username)
        // {
        //     return _context.UserInfo.SingleOrDefault(item => item.CodewarsName==username);
        // }
    }
}