using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class NotasController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // Dicionário de notas

            Dictionary<string, double> notas = new Dictionary<string, double>();
            notas.Add("Jim", 8.5);
            notas.Add("Pam", 9.5);
            notas.Add("Dwight", 10);
            notas.Add("Michael", 6.5);
            notas.Add("Angela", 9);
            notas.Add("Meredith", 4);
            notas.Add("Kevin", 2);
            notas.Add("Creed", 0);

            double mediaTurma = notas.Values.Average();
            double maiorNota = notas.Values.Max();
            double menorNota = notas.Values.Min();

            // Classificar os alunos por notas
            Dictionary<string, string> aprovações = new Dictionary<string, string>();
            foreach (var aluno in notas)
            {
                if (aluno.Value >= 7)
                {
                    aprovações.Add(aluno.Key, "Aprovado");
                } 
                else if (aluno.Value >= 5 && aluno.Value < 7)
                {
                    aprovações.Add(aluno.Key, "Em recuperação");
                }
                else
                {
                    aprovações.Add(aluno.Key, "Reprovado");
                }
            }

            // Passar os dados para a view usando ViewBag
            // Aprendi em https://learn.microsoft.com/en-us/aspnet/core/mvc/views/overview?view=aspnetcore-10.0#viewbag
            ViewBag.Notas = notas;
            ViewBag.Aprovacoes = aprovações;
            ViewBag.MediaTurma = mediaTurma;
            ViewBag.MaiorNota = maiorNota;
            ViewBag.MenorNota = menorNota;

            return View("Index");
        }
    }
}
