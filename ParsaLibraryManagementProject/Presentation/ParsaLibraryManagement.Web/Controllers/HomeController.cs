﻿using Microsoft.AspNetCore.Mvc;

namespace ParsaLibraryManagement.Web.Controllers
{
    //todo implement
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}