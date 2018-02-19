using Microsoft.AspNetCore.Mvc;
using System;
using Application.Models;

namespace Application.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return Redirect("/contacts");
        }
    }
}
