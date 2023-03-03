using Microsoft.AspNetCore.Mvc;

namespace Taboada_SportsStore.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index() => View();
    }
}
