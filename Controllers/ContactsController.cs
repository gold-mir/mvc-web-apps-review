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
            return View(Contact.GetAllInstances());
        }

        [HttpGet]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/contacts")]
        public ActionResult Create()
        {
            string newName = Request.Form["new-name"];
            string newEmail = Request.Form["new-email"];
            string newPhone = Request.Form["new-phone"];

            if(newName == "" || newEmail == "" || newPhone == "")
            {
                return View("Index", Contact.GetAllInstances());
            } else {
                Contact newContact = new Contact(newName, newEmail, newPhone);
                return View("Index", Contact.GetAllInstances());
            }
        }

        [HttpPost("/contacts/clear")]
        public ActionResult Clear()
        {
            Contact.GetAllInstances().Clear();
            return Redirect("/contacts");
        }
    }
}
