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
    public class MealDetailService
    {
        MealDetailRepository mealDetailRepository;

        public MealDetailService()
        {
            mealDetailRepository = new MealDetailRepository();
        }

        public bool InsertMealDetail(MealDetail mealDetail)
        {
            
            return mealDetailRepository.InsertMealDetail(mealDetail);

        }

        public List<MealDetail> GetMealDetails(int userId, int mealId, DateTime creationDate)
        {
            return mealDetailRepository.GetMealDetails(userId, mealId, creationDate);
        }

        
        public List<MealDetail> GetByUserID(int userID)
        {

            return mealDetailRepository.GetByUserID(userID);
        }

        public List<MealDetail> GetByUserID(int userID, DateTime date)
        {

            return mealDetailRepository.GetByUserID(userID, date);
        }

        public MealDetail GetByMealDetailID(int mealDetailID)
        {
            return mealDetailRepository.GetByMealDetailID(mealDetailID);
        }

        public bool UpdateMealDetail(MealDetail mealDetail)
        {
            return mealDetailRepository.UpdateMealDetail(mealDetail);
        }

        public bool DeleteMealDetail(int userId, int mealId, DateTime creationDate)
        {
            return mealDetailRepository.DeleteMealDetail(userId, mealId, creationDate);
        }

        public bool DeleteMealDetailByMealDetailId(int mealDetailId)
        {
            return mealDetailRepository.DeleteMealDetailByMealDetailId(mealDetailId);
        }

        public List<string> GetFoodIDByUserID(int userID)
        {
            return mealDetailRepository.GetFoodIDByUserID(userID);
        }

        public List<string> GetFoodNameByUserIDFoodID(int foodID, int userID)
        {
            return mealDetailRepository.GetFoodNameByUserIDFoodID(foodID, userID);
        }

        public List<int> GetQuantityByUserIDFoodID(int foodID, int userID)
        {
            return mealDetailRepository.GetQuantityByUserIDFoodID(foodID, userID);
        }
        public List<string> GetMealByUserIDFoodID(int foodID, int userID)
        {
            return mealDetailRepository.GetMealByUserIDFoodID(foodID, userID);
        }

        public string GetMostEatenFoodName(int userID)
        {
            return mealDetailRepository.GetMostEatenFoodName(userID);

        }

    }
}
