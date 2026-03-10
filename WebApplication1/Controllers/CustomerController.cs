using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            int id = 1;

            Customer cu = new Customer();
            cu.CustomerId = id;
            cu.EmailAddress = "fulano@mail.com.br";
            cu.FirstName = "Fulano";
            cu.LastName = "de Tal";

            Customer cu1 = new Customer()
            {
                CustomerId = ++id,
                EmailAddress = "ciclano@mail.com.br",
                FirstName = "Ciclano",
                LastName = "de Tal",
            };

            var cu2 = new Customer()
            {
                CustomerId = ++id,
                EmailAddress = "beltrano@mail.com.br",
                FirstName = "Beltrano",
                LastName = "de Tal"
            };

            List<Customer> customers = new List<Customer>();
            customers.Add(cu);
            customers.Add(cu1);
            customers.Add(cu2);

            return View(customers);
        }
    }
}