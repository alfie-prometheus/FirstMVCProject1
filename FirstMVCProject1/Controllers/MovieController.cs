﻿using Microsoft.AspNetCore.Mvc;

namespace FirstMVCProject1.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
