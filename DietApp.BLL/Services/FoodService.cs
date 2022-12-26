using DietApp.DAL.Repositories;
using DietApp.Model.Entities;
using DietApp.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BLL.Services
{
    public class FoodService
    {
        FoodRepository foodRepository;

        public FoodService()
        {
            foodRepository = new FoodRepository();
        }

        public List<Food> GetFoodsByCategory(int categoryId, DietType dietType)
        {
            List<Food> foods = foodRepository.GetFoodsByCategory(categoryId,dietType);
            return foods;
        }

        public Food GetFoodsById(int foodId)
        {
            Food food = foodRepository.GetFoodsById(foodId);
            return food;
        }

        public bool InsertFood(Food food)
        {
            if (string.IsNullOrWhiteSpace(food.CalciumValue.ToString()) || string.IsNullOrWhiteSpace(food.CalorieValue.ToString()) || string.IsNullOrWhiteSpace(food.CarbonhydrateValue.ToString()) || string.IsNullOrWhiteSpace(food.FatValue.ToString()) || string.IsNullOrWhiteSpace(food.FolicAcidValue.ToString()) || string.IsNullOrWhiteSpace(food.Name) || string.IsNullOrWhiteSpace(food.ProteinValue.ToString()) || string.IsNullOrWhiteSpace(food.QuantityType.ToString())) throw new Exception("Lütfen bilgilerinizi eksiksiz giriniz");

            return foodRepository.InsertFood(food);

        }

        public int GetFoodIDByFoodName(string foodName, string dietType)
        {
            return foodRepository.GetFoodIDByFoodName(foodName, dietType);
        }

        public string GetFoodByFoodID(string foodID)
        {
            return foodRepository.GetFoodByFoodID(foodID);
        }
    }
}
