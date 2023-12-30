using BestStoreApi.Models;
using BestStoreApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace BestStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly ApplicationDbContext context;

        public AccountsController(IConfiguration configuration, ApplicationDbContext context)
        {
            this.configuration = configuration;
            this.context = context;
        }

        [HttpPost("Register")]
        public IActionResult Register(UserDto userDto)
        {
            var emailCount = context.Users.Count(u => u.Email == userDto.Email);
            if (emailCount > 0)
            {
                ModelState.AddModelError("Email", "This email address is already in use.");
                return BadRequest(ModelState);
            }

            //encrypt the password
            var passwordHasher = new PasswordHasher<User>();

            var encryptedPassword = passwordHasher.HashPassword(new User(), userDto.Password);

            User user = new User()
            {
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Email = userDto.Email,
                Address = userDto.Address,
                Phone = userDto.Phone ?? "",
                Password = encryptedPassword,
                CreatedAt = DateTime.Now,
                Role = "client"

            };

            context.Users.Add(user);
            context.SaveChanges();

            var jwt = CreateJWToken(user);

            UserProfileDto userProfileDto = new UserProfileDto()
            {
                Id = user.Id,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Email = userDto.Email,
                Address = userDto.Address,
                Phone = userDto.Phone ?? "",
                Role = user.Role,
                CreatedAt = user.CreatedAt
            };

            var response = new
            {
                Token = jwt,
                User = userProfileDto
            };

            return Ok(response);

        }

        [HttpPost("Login")]
        public IActionResult Login(string email, string password)
        {
            var user = context.Users.FirstOrDefault(x => x.Email == email);
            if (user == null)
            {
                ModelState.AddModelError("Error", "There is no account with this email address");
                return BadRequest(ModelState);
            }
            //verify the password
            var passwordHasher = new PasswordHasher<User>();

            var result = passwordHasher.VerifyHashedPassword(new User(), user.Password, password);
            if (result == PasswordVerificationResult.Failed)
            {
                ModelState.AddModelError("Error", "The email and password combination is wrong");
                return BadRequest(ModelState);
            }
            var jwt = CreateJWToken(user);
            var userProfileDto = new UserProfileDto()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Address = user.Address,
                Role = user.Role,
                CreatedAt = user.CreatedAt,
                Phone = user.Phone ?? ""
            };

            var response = new { Token = jwt, User = userProfileDto };

            return Ok(response);
        }
        [Authorize]
        [HttpGet("AuthorizeAuthenticateUsers")]
        public IActionResult AuthorizeAuthenticateUsers()
        {
            return Ok("You are authorized Client");
        }
        [Authorize(Roles = "admin")]
        [HttpGet("AuthorizeAdmin")]
        public IActionResult AuthorizeAdmin()
        {
            return Ok("You are authorized Admin");
        }

        private string CreateJWToken(User user)
        {
            List<Claim> claims = new List<Claim>()
            {
                new Claim("id",user.Id.ToString()),
                new Claim("role",user.Role)
            };

            string? strKey = configuration["JwtSettings:Key"];

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(strKey));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: configuration["JwtSettings:Issuer"],
                audience: configuration["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }

        //[HttpGet("TestToken")]
        //public IActionResult TestToken()
        //{
        //    User user = new User() { Id = "2", Role = "Admin" };
        //    string jwt = CreateJWToken(user);
        //    var response = new { JWToken = jwt };
        //    return Ok(response);
        //}

    }
}
