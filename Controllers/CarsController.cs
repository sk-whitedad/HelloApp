using HelloApp.Data.interfaces;
using HelloApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HelloApp.Controllers
{
    public class CarsController: Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;
        public CarsController(IAllCars allCars, ICarsCategory allCategories)
        {
            _allCars = allCars;
            _allCategories = allCategories;
        }
        public ViewResult List(string id)
        {
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel model = new CarsListViewModel();
            model.allCars = _allCars.Cars;
            model.currCategory = "Автомобили";
            return View(model);
        }
    }
}
