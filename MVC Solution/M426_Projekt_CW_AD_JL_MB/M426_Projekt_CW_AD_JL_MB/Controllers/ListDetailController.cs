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
using M426_Projekt_CW_AD_JL_MB.Models.Status;
using M426_Projekt_CW_AD_JL_MB.Models.Priority;
using Microsoft.AspNetCore.Authorization;

namespace M426_Projekt_CW_AD_JL_MB.Controllers {
    public class ListDetailController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ListDetailController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult Index(int id)
        {
            // Selektierte Liste in ListDetail öffnen
            // Alle Aufgaben mit der List-ID holen
            ListDetailViewModel listDetail = new ListDetailViewModel();

            // Benutzer lesen
            List<IdentityUser> users = _context.Users.ToList();
            listDetail.Users = users;
            // Alle Tasks in Liste schreiben
            List<TaskModel> tasks = new List<TaskModel>();
            foreach (TaskModel task in tasks)
            {
                task.User = _context.Users.Where(n => n.Id == task.UserId).FirstOrDefault();
            }
            listDetail.Tasks = tasks;

            // List Priority lesen
            List<PriorityModel> priority = new List<PriorityModel>();
            List<StatusModel> status = new List<StatusModel>();

            // Tasks auf DB lesen
            tasks = _context.Task.Where(n => n.ListId == id).ToList();
            priority = _context.Priority.ToList();
            // Alle Status lesen
            status = _context.Status.ToList();
            // Property abfüllen
            listDetail.Tasks = tasks;
            listDetail.Priority = priority;
            listDetail.Status = status;
            listDetail.ListId = id;

            // View aufrufen mit Parameter
            return View(listDetail);
        }

        [Authorize]
        [HttpPost]
        public IActionResult UpdateTask(int id, string userId)
        {
            // Veränderungen der Tasks speichern
            TaskModel task = _context.Task.Where(n => n.Id == id).First();
            IdentityUser user = _context.Users.Where(n => n.Id == userId).First();
            task.User = user;
            _context.Task.Update(task);
            // Änderungen in Datenbank schreiben
            _context.SaveChanges();
            return RedirectToAction("Index", new { id = task.ListId });
        }

        [Authorize]
        public IActionResult ChangeStatus(int id, bool back)
        {
            // Status des Tasks verändern
            TaskModel task = _context.Task.Find(id);
            task.StatusId = task.ChangeStatus(id, back, task.StatusId);

            _context.Task.Update(task);
            // Änderungen in Datenbank schreiben
            _context.SaveChanges();
            return RedirectToAction("Index", new { id = task.ListId });
        }

        [Authorize]
        public IActionResult Delete(int id)
        {
            //_context.Task.RemoveRange(_context.Task.Where(t => t. == id));
            //_context.SaveChanges();
            TaskModel task = _context.Task.Find(id);
            _context.Task.Remove(task);
            // Änderungen in Datenbank schreiben
            _context.SaveChanges();
            // Zurück zu ListDetail
            return RedirectToAction("Index", new { id = task.ListId });
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(int listId, string title, string description, int statusId, int priorityId)
        {
            // Task erstellen
            IdentityUser user = _context.Users.Where(u => u.UserName == User.Identity.Name).FirstOrDefault();
            TaskModel model = new TaskModel();
            model.Title = title;
            model.Description = description;
            model.UserId = user.Id;
            model.ListId = listId;
            model.StatusId = statusId;
            model.PriorityId = priorityId;
            _context.Task.Add(model);
            // Änderungen in Datenbank schreiben
            _context.SaveChanges();
            // Zurück zu ListDetail
            return RedirectToAction("Index", new { id = listId });
        }

        [Authorize]
        [HttpPost]
        public IActionResult Share(int id, string username)
        {
            // Liste mit einem User Teilen
            ShareModel Share = new ShareModel();
            IdentityUser shareUser = new IdentityUser();
            shareUser = _context.Users.Where(u => u.UserName == username).FirstOrDefault();
            if (shareUser != null)
            {
                if ((_context.Share.Where(s => s.UserId == shareUser.Id && s.ListId == id).FirstOrDefault()) == null)
                {
                    Share.UserId = shareUser.Id;
                    Share.ListId = id;
                    _context.Share.Add(Share);
                    // Änderungen in Datenbank schreiben
                    _context.SaveChanges();
                }
            }
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
