using HelloApp.Data.interfaces;
using HelloApp.Data.Models;
using HelloApp.Data.Repository;
using HelloApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HelloApp.Controllers
{
    public class ShopCartController: Controller
    {
        private readonly IAllCars _carRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllCars carRep, ShopCart shopCart)
        {
            _carRep = carRep;
            _shopCart = shopCart;
        }

        public ViewResult Index() {
            var items = _shopCart.GetShopCartItems();
            _shopCart.listShopItems = items;
            
            var obj = new ShopCartViewModel { shopCart = _shopCart };
                
            return View(obj);
        }

        public RedirectToActionResult addToCart(int id) { 
        var item = _carRep.Cars.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
