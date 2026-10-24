using Microsoft.AspNetCore.Mvc;

   namespace CookieDemo.Controllers
   {
    public class CookieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateCookie()
        {
            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddDays(7);

            Response.Cookies.Append("Username", "Aditya", option);

            return Content("Cookie Created Successfully");
        }

        public IActionResult ReadCookie()
        {
            string? value = Request.Cookies["Username"];

            if (string.IsNullOrEmpty(value))
                return Content("Cookie Not Found");

            return Content("Cookie Value: " + value);
        }

        public IActionResult DeleteCookie()
        {

Response.Cookies.Delete("Username");
            return Content("Cookie Deleted");
        }
    }
}
