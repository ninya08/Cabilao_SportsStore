using Microsoft.AspNetCore.Mvc;
namespace Cabilao_SportsStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
