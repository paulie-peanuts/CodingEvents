using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CodingEvents.Models;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        private static List<string> Events = new List<string>();

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.events = Events;

            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [Route("/Events/Add")]
        public IActionResult NewEvent(string name)
        {
            Events.Add(name);
            
            return Redirect("/Events");
        }
    }
}