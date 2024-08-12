using Locauto.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Locauto.Controllers
{
    public class FabricanteController : Controller
    {
        public static List<Fabricante> Fabricantes= new List<Fabricante>()
        {
            new Fabricante()
            {
                Id = 1,
                Nome = "Intel",
                Pais = "Estados Unidos",

            },
            new Fabricante()
            {
                Id = 2,
                Nome = "Apple",
                Pais = "Canada",
            },

        };
        public IActionResult Index()
        {
            return View(Fabricantes);
        }
    }
}
