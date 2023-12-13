using ExampleWebAPI.Models;
using ExampleWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExampleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //private static List<string> listUsers = new List<string>() { "Nick", "Alex", "Will", "Bob" };

        private readonly IConfiguration configuration;

        public UsersController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        private static List<UserDto> listUsers = new List<UserDto>()
        {
            new UserDto() {FirstName="Bill",LastName="Gates",Email="bill@microsoft.com",Phone="111222333",Address="New York,USA" },
            new UserDto() {FirstName="Steven",LastName="Jobs",Email="steven@apple.com",Phone="44455666",Address="New York,USA" },

        };

        [HttpGet]
        //public List<string> GetUsers()
        public IActionResult GetUsers()
        {
            if (listUsers.Count > 0)
            {
                return Ok(listUsers);
            }
            return NoContent();
        }

        //constraint on route
        [HttpGet("{id:int}")]
        //public string GetUser(int id)
        public IActionResult GetUser(int id)
        {
            if (id >= 0 && id < listUsers.Count)
            {
                return Ok(listUsers[id]);
            }
            return NotFound();
        }
        [HttpGet("{name}")]
        public IActionResult GetUser(string name)
        {
            var user = listUsers.FirstOrDefault((u) => u.FirstName.Contains(name) || u.LastName.Contains(name)
            );
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpGet("info")]
        //optional parameters
        public IActionResult GetInfo(int? id, string? name, int? page, [FromServices] TimeService timeService)
        {
            if (id != null || name != null || page != null)
            {
                //anonymous object
                var response = new
                {
                    Id = id,
                    Name = name,
                    Page = page,
                    ErrorMessage = "The search functionaity is not supported yet"
                };
                return Ok(response);
            }

            List<string> listInfo = new List<string>();

            //from appsettings
            listInfo.Add(configuration["AppName"]);
            listInfo.Add(configuration["Language"]);
            listInfo.Add(configuration["Country"]);
            //from services
            listInfo.Add(timeService.GetDate());
            listInfo.Add(timeService.GetTime());


            return Ok(listInfo);
        }

        [HttpPost]
        //public void PostUser(string user)
        public IActionResult PostUser(UserDto user)
        {
            if (user.Email.Equals("user@example.com"))
            {
                ModelState.AddModelError("Email", "This email address is not authorized...");
                return BadRequest(ModelState);
            }
            listUsers.Add(user);
            return Ok();
        }
        [HttpPut("{id}")]
        //public void UpdateUser(int id, string user)
        public IActionResult UpdateUser(int id, UserDto user)
        {
            if (user.Email.Equals("user@example.com"))
            {
                ModelState.AddModelError("Email", "This email address is not authorized...");
                return BadRequest(ModelState);
            }
            if (id >= 0 && id < listUsers.Count)
            {
                listUsers[id] = user;
                return Ok();
            }
            return NotFound();
        }

        [HttpDelete]
        //public void DeleteUser(int id)
        public IActionResult DeleteUser(int id)
        {
            if (id >= 0 && id < listUsers.Count)
            {
                listUsers.RemoveAt(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
