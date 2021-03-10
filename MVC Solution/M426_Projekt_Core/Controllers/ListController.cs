using M426_Projekt_Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace M426_Projekt_Core.Controllers
{
    public class ListController : Controller
    {
        private readonly ILogger<ListController> _logger;

        public ListController(ILogger<ListController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Alle Listen anzeigen
            return View();
        }

        // Create a new List
        public IActionResult CreateList()
        {
            //Datenbankobjekt instanzieren

            //Daten bearbeiten / Logik mit abfragen

            //Daten weitergeben aus dem Model
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
