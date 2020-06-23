using Microsoft.AspNetCore.Mvc;
using MvcApiCall.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApiCall.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Article> allArticles = Article.GetArticles(EnvironmentVariables.ApiKey);
            return View(allArticles);
        }
    }
}