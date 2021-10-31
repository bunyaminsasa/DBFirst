using Microsoft.AspNetCore.Mvc;
using SimpleHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleHouse.Controllers
{
    public class ContactController : Controller
    {
        [Route("/iletisim")]

        public IActionResult Index()
        {
            
            ViewBag.menu = "iletisim";
            return View();
        }

        [HttpPost]
        public IActionResult Send(Contact _model)
        {
            DBSimpleHouseContext db = new DBSimpleHouseContext();
            db.Contacts.Add(_model);
            db.SaveChanges();
            TempData["mesaj"] = "Sayın" + " " + _model.Name + " " + "Mesajınız Başarıyla alındı";
            return RedirectToAction("Index");
        }
    }
}
