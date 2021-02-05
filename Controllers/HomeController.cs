using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using alessi.lorenzo._5H.PrimaWeb.Models;

namespace alessi.lorenzo._5H.PrimaWeb.Controllers
{
    public class HomeController : Controller
    {
        static List<Prenotazione> prenotazioni = new List<Prenotazione>();

        public IActionResult Index()
        {
            var db = new PrenotazioneContext();     
            db.Prenotazioni.Add(new Prenotazione { Nome = "lorenzo", Email="lorenzo@gmail.com" });
            db.SaveChanges();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Prenota()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Prenota(Prenotazione p)
        {
            PrenotazioneContext db = new PrenotazioneContext();
            db.Prenotazioni.Add(p); 
            db.SaveChanges(); 
            return View("Grazie" , db);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
