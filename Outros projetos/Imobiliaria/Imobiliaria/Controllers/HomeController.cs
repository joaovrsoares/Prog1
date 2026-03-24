using Imobiliaria.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Imobiliaria.Entidades;

namespace Imobiliaria.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Imovel> lista = new List<Imovel>()
            {
                new Casa
                {
                    Id = 1,
                    Endereco = "Rua A, 123",
                    Preco = 1000,
                    TipoNegocio = "Aluguel",
                    TemQuintal = true,
                    NumeroAndares = 2
                },

                new Apartamento
                {
                    Id = 2,
                    Endereco = "Avenida B, 456",
                    Preco = 1500,
                    TipoNegocio = "Aluguel",
                    Andar = 3,
                    TemElevador = true
                },

                new Casa
                {
                    Id = 3,
                    Endereco = "Rua C, 789",
                    Preco = 300000,
                    TipoNegocio = "Venda",
                    TemQuintal = false,
                    NumeroAndares = 3
                },

                new Apartamento
                {
                    Id = 4,
                    Endereco = "Avenida D, 321",
                    Preco = 120000,
                    TipoNegocio = "Venda",
                    Andar = 5,
                    TemElevador = false
                },
                
                new Casa
                {
                    Id = 5,
                    Endereco = "Rua E, 654",
                    Preco = 2000,
                    TipoNegocio = "Aluguel",
                    TemQuintal = true,
                    NumeroAndares = 2
                }
            };

            return View(lista);
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
