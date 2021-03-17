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

namespace M426_Projekt_CW_AD_JL_MB.Controllers {
    public class ListController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ListController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<ListModel> lists = new List<ListModel>();
            ListViewModel listViewModel = new ListViewModel();
           
            List<ShareModel> Shares = _context.Share.Where(s => s.User.UserName == User.Identity.Name).ToList();

            foreach(ShareModel Share in Shares)
            {
                lists.Add(_context.List.Where(l => l.Id == Share.ListId).FirstOrDefault());
            }

            listViewModel.Lists = lists;
            return View(listViewModel);
        }

        public IActionResult Delete(int id)
        {
            return View();
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
