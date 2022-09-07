using FoodieApi.Model;

namespace FoodieApi.Services
{
    public interface IFoodServices
    {
        Task<List<Foods>> GettheFood();

        Task InsertFoodDetails(Foods foods);

        Task<Foods> GetById(string id);

        Task UpdateFoodDetails(string id, Foods food);

        Task DeleteFoodDetails(string id);

    }
}
