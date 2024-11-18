using Microsoft.AspNetCore.Mvc;
using patika_w8_CustomerOrdersApp.Models;


namespace patika_w8_CustomerOrdersApp.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            // Örnek bir müşteri oluştur
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Yaşar",
                LastName = "Doğan",
                Email = "yasar@gmail.com"
            };

            // Örnek siparişler oluştur
            List<Order> orders = new List<Order>
            {
                new Order { Id = 1, ProductName = "Forma", Price = 999, Quantity = 1 },
                new Order { Id = 2, ProductName = "Atkı", Price = 250, Quantity = 1 },
                new Order { Id = 3, ProductName = "Bere", Price = 199, Quantity = 1 }
            };

            // ViewModel oluştur ve view'a gönder
            CustomerOrderViewModel viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            return View(viewModel);
        }
    }
}
