﻿using Microsoft.AspNetCore.Mvc;

namespace StudentApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return PartialView("_Index");
        }
    }
}
