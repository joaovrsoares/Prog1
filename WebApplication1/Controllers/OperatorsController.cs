using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class OperatorsController : Controller
    {
        public IActionResult Index()
        {
            // Aritméticos
            int y = -10; // = É operador unário de atribuição
            int x = 2;
            int z = y - x;

            // Precedência
            int xx = 10 - 20 * 10;
            // Nesse caso o C# já conhece a regra de precedência dos operadores aritméticos,
            // No entanto, se eu desejar manipular a ordem das operações, posso usar ()
            int yy = (10 - 20) * 10;

            // Operadores de composição
            int xXx = 10;
            int yXy = 20;
            xXx += yXy;

            // Operadores de incremento e decremento

            // Podemos incrementar de forma original
            int luiz = x + 1;
            luiz = x++; // Incrementando
            luiz = x--; // Decrementando

            // No entanto, existe outra forma de controlar a precedência do incremento ou decremento
            // Caso eu desejar que a incrementação ocorra antes de qualquer outra operação, coloco os operadores antes da variável
            luiz = ++luiz * 2;

            // Operadores de comparação
            int num1 = 9;
            int num2 = 9;

            string resultado = string.Empty;
            if (num1 == num2)
            {
                resultado = "São iguais.";
            }

            // Também podemos atribuir uma comparação diretamente a uma variável
            bool eIgual = (num1 == num2);

            return View();
        }
    }
}
