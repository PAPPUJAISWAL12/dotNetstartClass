using Microsoft.AspNetCore.Mvc;

namespace StudentApp.Controllers
{
	public class UserListController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
