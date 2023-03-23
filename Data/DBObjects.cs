using HelloApp.Data.Models;

namespace HelloApp.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
                content.AddRange(
                new Car
                                   {
                                       name = "Tesla",
                                       shortDesc = "Современный и быстрый",
                                       longDesc = "Экономичный и бесшумный автомобиль для городской жизни",
                                       img = "/img/tesla.jpg",
                                       price = 45000,
                                       isFavorite = true,
                                       available = true,
                                       Category = Categories["Электромобили"]
                                   },
                new Car
                {
                    name = "BMW M3",
                    shortDesc = "Дерзкий и стильный",
                    longDesc = "Удобный автомобиль для городской жизни",
                    img = "/img/m3.webp",
                    price = 61000,
                    isFavorite = false,
                    available = true,
                    Category = Categories["Классические автомобили"]
                },
                new Car
                        {
                            name = "Mersedes Benz",
                            shortDesc = "Комфортный и стильный",
                            longDesc = "Удобный автомобиль для городской жизни",
                            img = "/img/mersedes.jpeg",
                            price = 65000,
                            isFavorite = true,
                            available = true,
                            Category = Categories["Классические автомобили"]
                        },
                new Car
        {
            name = "Audi",
            shortDesc = "Cтильный и комфортный",
            longDesc = "Удобный автомобиль для городской жизни",
            img = "/img/audi.jpg",
            price = 55000,
            isFavorite = false,
            available = true,
            Category = Categories["Классические автомобили"]
        },
                new Car
        {
            name = "Nissan Leaf",
            shortDesc = "Дерзкий и стильный",
            longDesc = "Удобный автомобиль для городской жизни",
            img = "/img/nissan.jpg",
            price = 14000,
            isFavorite = true,
            available = true,
            Category = Categories["Электромобили"]
        }
                );
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Электромобили", desc = "Современный вид транспорта" },
                        new Category { categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания" }
                    };
                    category = new Dictionary<string, Category>();
                    foreach (var c in list)
                        category.Add(c.categoryName, c);
                }
                return category;
            }
        }
    }
}
