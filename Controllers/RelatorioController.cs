using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class RelatorioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Novo()
        {
            return View();
        }
         public IActionResult TitulosReceber()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Novo( RelatorioViewModel model)
        {
            if(ModelState.IsValid)
            {
                var relatorio = model;
                return RedirectToAction("Index");
            }

            return View(model);
        }

    }
}