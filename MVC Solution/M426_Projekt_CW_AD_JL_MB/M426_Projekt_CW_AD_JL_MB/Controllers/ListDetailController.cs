using M426_Projekt_CW_AD_JL_MB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using M426_Projekt_CW_AD_JL_MB.Models.List;
using M426_Projekt_CW_AD_JL_MB.Models.User;
using M426_Projekt_CW_AD_JL_MB.Data;
using Microsoft.AspNetCore.Identity;
using M426_Projekt_CW_AD_JL_MB.Models.Share;
using M426_Projekt_CW_AD_JL_MB.Models.Task;

namespace M426_Projekt_CW_AD_JL_MB.Controllers {
    public class ListDetailController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ListDetailController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int id = 1)
        {
            // User überprüfen nach Berechtigung in der Share Tabelle

            // Alle Tasks verknüpft mit dieser Liste holen
            List<TaskModel> tasks = new List<TaskModel>();
            ListDetailViewModel listDetail = new ListDetailViewModel();
            tasks = _context.Task.Where(n => n.ListId == id).ToList();
            // Tasks für die Detail ansicht vorbereiten
            listDetail.Tasks = tasks;
            return View(listDetail);
        }

        public IActionResult Delete(int id)
        {
            //_context.Task.RemoveRange(_context.Task.Where(t => t. == id));
            //_context.SaveChanges();
            TaskModel task = _context.Task.Find(id);
            _context.Task.Remove(task);
            _context.SaveChanges();
            return RedirectToAction("Index", new { id = task.ListId });
        }

        [HttpPost]
        public IActionResult Create(string name)
        {
            IdentityUser user = _context.Users.Where(u => u.UserName == User.Identity.Name).FirstOrDefault();
            ListModel model = new ListModel();
            model.Name = name;
            ShareModel Share = new ShareModel();
            _context.List.Add(model);
            _context.SaveChanges();
            Share.UserId = user.Id;
            Share.ListId = model.Id;
            _context.Share.Add(Share);
            _context.SaveChanges();
            return RedirectToAction("Index");
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
