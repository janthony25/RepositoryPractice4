using Microsoft.AspNetCore.Mvc;

namespace RepositoryPractice4.Controllers
{
    public class CustomerListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
