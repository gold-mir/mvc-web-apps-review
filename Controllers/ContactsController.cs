using Microsoft.AspNetCore.Mvc;
using System;
using Application.Models;

namespace Application.Controllers
{
    public class ContactsController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/contacts")]
        public ActionResult Create()
        {
            return View("Index");
        }

        [HttpPost("/contacts/clear")]
        public ActionResult Clear()
        {
            return Redirect("/contacts")
        }
    }
}
