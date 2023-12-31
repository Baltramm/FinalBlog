﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FinalBlog.App.ViewModels;
using System.Diagnostics;

namespace FinalBlog.App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (User.Identity!.IsAuthenticated)
            {
                var user = User;
                ViewData["User"] = user;
            }
            
            return View();
        }

        public IActionResult Privacy() => View();

        [Authorize]
        [Route("AccessDenied")]
        public IActionResult AccessDenied() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}