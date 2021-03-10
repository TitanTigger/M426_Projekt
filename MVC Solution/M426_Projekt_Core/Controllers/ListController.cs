﻿using M426_Projekt_Core.Models;
using M426_Projekt_Core.Models.List;
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
            //Datenbankobjekt instanzieren
            List<ListViewModel> model = new List<ListViewModel>();
            ListViewModel obj = new ListViewModel();
            obj.ID = 1;
            obj.Name = "M426";
            model.Add(obj);
            ListViewModel obj2 = new ListViewModel();
            obj.ID = 2;
            obj.Name = "M122";
            model.Add(obj2);
            ListViewModel obj3 = new ListViewModel();
            obj.ID = 3;
            obj.Name = "M131";
            model.Add(obj3);
            ListViewModel obj4 = new ListViewModel();
            obj.ID = 4;
            obj.Name = "M226B";
            model.Add(obj4);

            //Daten bearbeiten / Logik mit abfragen

            //Daten weitergeben aus dem Model
            return View(model);
        }

        // Create a new List
        public IActionResult CreateList()
        {
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