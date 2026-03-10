using System.Diagnostics;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
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
            return View();
        }

        [HttpGet]
        public IActionResult Variables()
        {
            string retorno = string.Empty;

            // Escrita implícita
            int userCount = 10;

            // Tipos de anotações
            int totalUsers;
            totalUsers = 20;

            // Constante
            const int interestRate = 5;

            retorno += $"Contagem de usuários: {userCount}\n";
            retorno += $"Total de usuários: {totalUsers}\n";
            retorno += $"Taxa de juros: {interestRate}%\n";

            return View("Variables", retorno);
        }

        [HttpGet]
        public IActionResult Joao()
        {
            string dadosJoao = string.Empty;

            string name = "João Vitor Soares da Rosa";
            int age = 19;
            double height = 1.8;
            string mail = "joao.vr@unoesc.edu.br";

            dadosJoao += $"Nome: {name}<br>";
            dadosJoao += $"Idade: {age} anos<br>";
            dadosJoao += $"Altura: {height:F2}m<br>";
            dadosJoao += $"E-mail: {mail}<br>";
            return View("Joao", dadosJoao);
        }

        [HttpGet]
        public async Task<IActionResult> Numbers()
        {
            string retorno = string.Empty;

            retorno += $"Valor máximo para int: {int.MaxValue}<br />";
            retorno += $"Valor mínimo para int: {int.MinValue}<br />";
            retorno += $"Valor máximo para double: {double.MaxValue}<br />";
            retorno += $"Valor mínimo para double: {double.MinValue}<br />";
            retorno += $"Valor máximo para decimal: {decimal.MaxValue}<br />";
            retorno += $"Valor mínimo para decimal: {decimal.MinValue}<br />";
            retorno += $"Valor máximo para long: {long.MaxValue}<br />";
            retorno += $"Valor mínimo para long: {long.MinValue}<br />";
            retorno += $"Valor máximo para float: {float.MaxValue}<br />";
            retorno += $"Valor mínimo para float: {float.MinValue}<br />";
            retorno += $"Valor máximo para byte: {byte.MaxValue}<br />";
            retorno += $"Valor mínimo para byte: {byte.MinValue}<br />";
            retorno += $"Valor máximo para short: {short.MaxValue}<br />";
            retorno += $"Valor mínimo para short: {short.MinValue}<br />";
            retorno += $"Valor máximo para sbyte: {sbyte.MaxValue}<br />";
            retorno += $"Valor mínimo para sbyte: {sbyte.MinValue}<br />";
            retorno += $"Valor máximo para uint: {uint.MaxValue}<br />";
            retorno += $"Valor mínimo para uint: {uint.MinValue}<br />";

            return View("Numbers", retorno);
        }

        [HttpGet]
        public IActionResult Dictionary()
        {
            Dictionary<int, string> data = [];

            for (int i = 1; i <= 10; i++)
            {
                data.Add(i, $"Valor {i}");
            }

            return View("Dictionary", data);
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
