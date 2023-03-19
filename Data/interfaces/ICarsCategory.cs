using HelloApp.Data.Models;

namespace HelloApp.Data.interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }



    }
}
