using Factory.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System;

using Microsoft.AspNetCore.Mvc;

namespace Factory.Controllers
{
    public class HomeController : Controller
    {
    
      private readonly FactoryContext _db;

      public HomeController(FactoryContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

        public ActionResult Details()
      {
        ViewBag.Machines = _db.Machines.ToList();
        ViewBag.Engineers = _db.Engineers.ToList();
        return View();
      }             

      
    }
}