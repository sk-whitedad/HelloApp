using HelloApp.Data.interfaces;
using HelloApp.Data.Models;
using HelloApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HelloApp.Controllers
{
    public class HomeController: Controller
    {
        private readonly IAllCars _carRep;

        public HomeController(IAllCars carRep, ShopCart shopCart)
        {
            _carRep = carRep;
        }

        public ViewResult Index(int id)
        {
            var homeCars = new HomeViewModel { 
            favCars = _carRep.getFavCars,

            }; 
            return View(homeCars);
        }
    }
}
