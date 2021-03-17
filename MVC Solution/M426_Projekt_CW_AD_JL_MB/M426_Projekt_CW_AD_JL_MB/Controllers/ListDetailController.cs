﻿using M426_Projekt_CW_AD_JL_MB.Models;
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

        public IActionResult Index(int id = 1)
        {
            // User überprüfen nach Berechtigung in der Share Tabelle

            // Alle Tasks verknüpft mit dieser Liste holen
            List<TaskModel> tasks = new List<TaskModel>();
            List<PriorityModel> priority = new List<PriorityModel>();
            List<StatusModel> status = new List<StatusModel>();
            ListDetailViewModel listDetail = new ListDetailViewModel();
            tasks = _context.Task.Where(n => n.ListId == id).ToList();
            priority = _context.Priority.ToList();
            status = _context.Status.ToList();
            // Tasks für die Detail ansicht vorbereiten
            listDetail.Tasks = tasks;
            listDetail.Priority = priority;
            listDetail.Status = status;
            listDetail.ListId = id;
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
        public IActionResult Create(int listId, string title, string description, int statusId, int priorityId)
        {
            IdentityUser user = _context.Users.Where(u => u.UserName == User.Identity.Name).FirstOrDefault();
            TaskModel model = new TaskModel();
            model.Title = title;
            model.Description = description;
            model.UserId = user.Id;
            model.ListId = listId;
            model.StatusId = statusId;
            model.PriorityId = priorityId;
            _context.Task.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index", new { id = listId });
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
