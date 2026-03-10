using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FlowerController : Controller
    {
        public IActionResult Index()
        {
            Flower rosa = new Flower();
            rosa.Type = "Rosa";
            rosa.Color = "Vermelha";
            rosa.Petals = 32;
            rosa.Size = 5.5;
            rosa.IsFragrant = true;

            Flower girassol = new Flower();
            girassol.Type = "Girassol";
            girassol.Color = "Amarelo";
            girassol.Petals = 34;
            girassol.Size = 15.0;
            girassol.IsFragrant = false;

            Flower tulipa = new Flower();
            tulipa.Type = "Tulipa";
            tulipa.Color = "Rosa";
            tulipa.Petals = 6;
            tulipa.Size = 6.0;
            tulipa.IsFragrant = false;

            Flower lirio = new Flower();
            lirio.Type = "Lírio";
            lirio.Color = "Branco";
            lirio.Petals = 6;
            lirio.Size = 12.0;
            lirio.IsFragrant = true;

            Flower margarida = new Flower();
            margarida.Type = "Margarida";
            margarida.Color = "Branca";
            margarida.Petals = 21;
            margarida.Size = 3.5;
            margarida.IsFragrant = false;

            Flower orquidea = new Flower();
            orquidea.Type = "Orquídea";
            orquidea.Color = "Roxa";
            orquidea.Petals = 3;
            orquidea.Size = 7.0;
            orquidea.IsFragrant = true;

            Flower cravo = new Flower();
            cravo.Type = "Cravo";
            cravo.Color = "Vermelho";
            cravo.Petals = 40;
            cravo.Size = 4.0;
            cravo.IsFragrant = true;

            Flower jasmim = new Flower();
            jasmim.Type = "Jasmim";
            jasmim.Color = "Branco";
            jasmim.Petals = 5;
            jasmim.Size = 2.0;
            jasmim.IsFragrant = true;

            Flower lavanda = new Flower();
            lavanda.Type = "Lavanda";
            lavanda.Color = "Lilás";
            lavanda.Petals = 4;
            lavanda.Size = 1.5;
            lavanda.IsFragrant = true;

            Flower violeta = new Flower();
            violeta.Type = "Violeta";
            violeta.Color = "Roxa";
            violeta.Petals = 5;
            violeta.Size = 2.5;
            violeta.IsFragrant = true;

            List<Flower> flowersList = new List<Flower>
            {
                rosa, girassol, tulipa, lirio, margarida, orquidea, cravo, jasmim, lavanda, violeta
            };

            return View(flowersList);
        }
    }
}
