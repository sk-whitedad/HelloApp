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
                    img = "https://www.pvsm.ru/images/2015/08/19/kak-Tesla-izmenit-mir.jpg",
                    price = 45000,
                    isFavorite = true,
                    available = true,
                    Category = _categoryCars.AllCategories.First()
                },
                new Car{
                    name = "BMW M3",
                    shortDesc = "Дерзкий и стильный",
                    longDesc = "Удобный автомобиль для городской жизни",
                    img = "https://seite1.ru/wp-content/uploads/2022/09/s1200.webp",
                    price = 61000,
                    isFavorite = false,
                    available = true,
                    Category = _categoryCars.AllCategories.Last()
                },
                        new Car{
                    name = "Mersedes Benz",
                    shortDesc = "Комфортный и стильный",
                    longDesc = "Удобный автомобиль для городской жизни",
                    img = "https://aybaz.ru/wp-content/uploads/b/2/8/b282a365ceb9d1daff03673f66102b96.jpeg",
                    price = 65000,
                    isFavorite = true,
                    available = true,
                    Category = _categoryCars.AllCategories.Last()
                },
        new Car{
                    name = "Audi",
                    shortDesc = "Cтильный и комфортный",
                    longDesc = "Удобный автомобиль для городской жизни",
                    img = "https://damion.club/uploads/posts/2022-02/1645524753_1-damion-club-p-zelyonaya-audi-avtomobili-1.jpg",
                    price = 55000,
                    isFavorite = false,
                    available = true,
                    Category = _categoryCars.AllCategories.Last()
                },
        new Car{
                    name = "Nissan Leaf",
                    shortDesc = "Дерзкий и стильный",
                    longDesc = "Удобный автомобиль для городской жизни",
                    img = "https://electromobili.ru/images/com_hikashop/upload/nissan-leaf-long-range-1.jpg",
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
