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

namespace M426_Projekt_CW_AD_JL_MB.Controllers {
    public class ListDetailController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ListDetailController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int id)
        {
            // Alle Tasks in verknüpfung mit dieser Aufgabe
            ListDetailViewModel listDetail = new ListDetailViewModel();
            List<IdentityUser> users = _context.Users.Where(n => n.Id != null).ToList();
            listDetail.Users = users;
            List<TaskModel> tasks = new List<TaskModel>();
            foreach (TaskModel task in tasks)
            {
                task.User = _context.Users.Where(n => n.Id == task.UserId).FirstOrDefault();
            }
            listDetail.Tasks = tasks;

            // User überprüfen nach Berechtigung in der Share Tabelle
            // Alle Tasks verknüpft mit dieser Liste holen
            List<PriorityModel> priority = new List<PriorityModel>();
            List<StatusModel> status = new List<StatusModel>();
            
            tasks = _context.Task.Where(n => n.ListId == id).ToList();
            priority = _context.Priority.ToList();
            status = _context.Status.ToList();
            // Tasks für die Detail ansicht vorbereiten
            listDetail.Tasks = tasks;
            listDetail.Priority = priority;
            listDetail.Status = status;
            listDetail.ListId = id;
            // View mit Instanz als Parameter aufrufen
            return View(listDetail);
        }

        [HttpPost]
        public IActionResult UpdateTask(int id, string userId)
        {
            // Änderungen am Task speichern
            TaskModel task = _context.Task.Where(n => n.Id == id).First();
            IdentityUser user = _context.Users.Where(n => n.Id == userId).First();
            task.User = user;
            _context.Task.Update(task);
            // Änderungen in Datenbank speichern
            _context.SaveChanges();
            // Zurück zu Listen-View
            return RedirectToAction("Index", new { id = task.ListId });
        }

        public IActionResult ChangeStatus(int id, bool back)
        {
            TaskModel task = _context.Task.Find(id);
            task.StatusId = task.StatusId = task.ChangeStatus(id, back, task.StatusId);
            _context.Task.Update(task);
            _context.SaveChanges();
            // Zurück zu Listen-View
            return RedirectToAction("Index", new { id = task.ListId });
        }

        public IActionResult Delete(int id)
        {
            //_context.Task.RemoveRange(_context.Task.Where(t => t. == id));
            //_context.SaveChanges();
            TaskModel task = _context.Task.Find(id);
            _context.Task.Remove(task);
            _context.SaveChanges();
            // Zurück zu Listen-View
            return RedirectToAction("Index", new { id = task.ListId });
        }

        [HttpPost]
        public IActionResult Create(int listId, string title, string description, int statusId, int priorityId)
        {
            // Task mit Parameter (eingabe im modal) erstellen und speicher in DB
            IdentityUser user = _context.Users.Where(u => u.UserName == User.Identity.Name).FirstOrDefault();
            TaskModel model = new TaskModel();
            // Alle Werte zu der Instanz setzen
            model.Title = title;
            model.Description = description;
            model.UserId = user.Id;
            model.ListId = listId;
            model.StatusId = statusId;
            model.PriorityId = priorityId;
            _context.Task.Add(model);
            // Task in Datenbank speichern
            _context.SaveChanges();
            // Zurück zu Listen-View
            return RedirectToAction("Index", new { id = listId });
        }

        [HttpPost]
        public IActionResult Share(int id, string username)
        {
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
