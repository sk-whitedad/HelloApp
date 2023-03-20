using HelloApp.Data.interfaces;
using HelloApp.Data.Models;

namespace HelloApp.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car> {
                new Car{
                    name = "Tesla",
                    shortDesc = "Современный и быстрый",
                    longDesc = "Экономичный и бесшумный автомобиль для городской жизни",
                    img = "/img/tesla.jpg",
                    price = 45000,
                    isFavorite = true,
                    available = true,
                    Category = _categoryCars.AllCategories.First()
                },
                new Car{
                    name = "BMW M3",
                    shortDesc = "Дерзкий и стильный",
                    longDesc = "Удобный автомобиль для городской жизни",
                    img = "/img/m3.webp",
                    price = 61000,
                    isFavorite = false,
                    available = true,
                    Category = _categoryCars.AllCategories.Last()
                },
                        new Car{
                    name = "Mersedes Benz",
                    shortDesc = "Комфортный и стильный",
                    longDesc = "Удобный автомобиль для городской жизни",
                    img = "/img/mersedes.jpeg",
                    price = 65000,
                    isFavorite = true,
                    available = true,
                    Category = _categoryCars.AllCategories.Last()
                },
        new Car{
                    name = "Audi",
                    shortDesc = "Cтильный и комфортный",
                    longDesc = "Удобный автомобиль для городской жизни",
                    img = "/img/audi.jpg",
                    price = 55000,
                    isFavorite = false,
                    available = true,
                    Category = _categoryCars.AllCategories.Last()
                },
        new Car{
                    name = "Nissan Leaf",
                    shortDesc = "Дерзкий и стильный",
                    longDesc = "Удобный автомобиль для городской жизни",
                    img = "/img/nissan.jpg",
                    price = 14000,
                    isFavorite = true,
                    available = true,
                    Category = _categoryCars.AllCategories.First()
                }

                }; 
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
