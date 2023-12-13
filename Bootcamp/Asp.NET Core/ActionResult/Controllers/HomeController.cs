using Microsoft.AspNetCore.Mvc;

namespace ActionResult.Controllers
{
    public class HomeController : Controller
    {
        [Route("book")]
        public IActionResult Index()
        {
            if (!Request.Query.ContainsKey("bookid"))
            {
                //Response.StatusCode = 400;
                //return Content("Book id is not supplied");
                return BadRequest("Book id is not supplied");
            }
            if (string.IsNullOrEmpty(Convert.ToString(Request.Query["bookid"])))
            {
                //Response.StatusCode = 400;
                //return Content("Book id can not be null or empty");
                return BadRequest("Book id can not be null or empty");
            }

            //Book id should be between 1 to 1000
            int bookid = Convert.ToInt32(ControllerContext.HttpContext.Request.Query["bookid"]);
            if (bookid <= 0)
            {
                //Response.StatusCode = 400;
                //return Content("Book id can not be less than 0");
                return NotFound("Book id can not be less than 0");
            }
            if (bookid > 1000)
            {
                //Response.StatusCode = 400;
                //return Content("Book id can not be greater than 1000");
                return NotFound("Book id can not be greater than 1000");
            }
            if (Convert.ToBoolean(Request.Query["isloggedin"]) == false)
            {
                //Response.StatusCode = 401;
                //return Content("User must be authenticated");
                return Unauthorized("User must be authenticated");
            }
            return File("/Sample.pdf", "application/pdf");
        }
    }
}