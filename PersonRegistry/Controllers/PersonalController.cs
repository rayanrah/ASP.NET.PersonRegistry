using Microsoft.AspNetCore.Mvc;
using PersonRegistry.Models;

namespace PersonRegistry.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            return View(new PersonalVM());
        }

        [HttpPost]
        public IActionResult ShowPersonal(PersonalVM personalVM)
        {
            return View(personalVM);
        }
    }
}