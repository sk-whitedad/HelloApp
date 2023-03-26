using HelloApp.Data;
using HelloApp.Data.interfaces;
using HelloApp.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloApp.Controllers
{
    public class OrderController: Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;
        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }
    }
}
