using Microsoft.AspNetCore.Mvc;

using ASPNET_MVC_2._0.Data;
using System.Collections.Generic;
using ASPNET_MVC_2._0.Models;

namespace ASPNET_MVC_2._0.Controllers
{
    public class ItemController : Controller 
    {
        private readonly ApplicationDbContext _db;
        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        [HttpGet]
        public IActionResult Index()
        {   
            IEnumerable<Item> objList = _db.Items;
            return View(objList);
            
        }

        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item obj)
        {
            _db.Items.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}