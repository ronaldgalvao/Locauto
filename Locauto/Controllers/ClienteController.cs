using Locauto.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Locauto.Controllers
{
    public class ClienteController : Controller
    {
        public static List<Cliente> Clientes = new List<Cliente>()
        {
            new Cliente()
            {
                Id = 1,
                Nome = "Rebeca",
                Email = "rebecaandrade@gmail.com",
                Telefone = "(21)9991236098",
                Cidade = "Rio de Janeiro"

            },
            new Cliente()
            {
                Id = 2,
                Nome = "Gabriel Medina",
                Email = "gabrielmedina@gmail.com",
                Telefone = "(24)9993214015",
                Cidade = "Saquarema"
            },

        };
        public IActionResult Index()
        {
            return View(Clientes);
        }
    }
}
