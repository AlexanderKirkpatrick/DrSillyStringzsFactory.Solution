using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Silly_Factory.Models;

using Microsoft.AspNetCore.Mvc;

namespace Silly_Factory.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      public ActionResult Details(int id)
      {
        List<Engineer> model = _db.Engineers.Include(engineer => engineer.Machine)ToList();
        List<Machine> model = _db.Machines.Include(machine => machine.Engineer).ToList();
        return View(model);
      }
    }
}