using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.Controllers
{
    public class ProductController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
