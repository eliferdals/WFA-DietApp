using DietApp.Model.Entities;
using DietApp.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.Repositories
{
    public class FoodRepository
    {
        DietAppDbContext db;

        public FoodRepository()
        {
            db = new DietAppDbContext();
        }

       

        public List<Food> GetFoodsByCategory(int categoryId, DietType dietType)
        {
            return db.Foods.Where(a => a.Category.ID==categoryId && a.DietType==dietType && !a.IsDeleted).OrderBy(a => a.Name).ToList();
        }

        public Food GetFoodsById(int foodId)
        {
            return db.Foods.Where(a => a.ID == foodId && !a.IsDeleted).OrderBy(a => a.Name).FirstOrDefault();
        }

        public List<Food> GetAll()
        {
            var data = db.Foods.Where(a => !a.IsDeleted).ToList();
            return data;
        }

        public Food GetByName(string name)
        {
            var data = db.Foods.Where(a => a.Name == name && !a.IsDeleted).OrderBy(a => a.ID).FirstOrDefault();
            return data;
        }

        public Food GetById(int id)
        {
            var data = db.Foods.Where(a => a.ID == id && !a.IsDeleted).OrderBy(a => a.ID).FirstOrDefault();
            return data;
        }

        public bool InsertFood(Food model)
        {
            Food food = new Food()
            {
                CalciumValue = model.CalciumValue,
                CalorieValue = model.CalorieValue,
                CarbonhydrateValue = model.CarbonhydrateValue,
                Category = db.Categories.Where(a => a.ID == model.CategoryID).FirstOrDefault(),
                CreationDate = DateTime.Now,
                Description = model.Description,
                FatValue = model.FatValue,
                FolicAcidValue = model.FolicAcidValue,
                FoodPicture = model.FoodPicture,
                IsDeleted = false,
                Name = model.Name,
                ProteinValue = model.ProteinValue,
                QuantityType = model.QuantityType

            };

            db.Foods.Add(food);
            return db.SaveChanges() > 0;
        }

        public int GetFoodIDByFoodName(string foodName, string dietType)
        {
            var data = db.Foods.Where(a => a.Name == foodName && !a.IsDeleted && a.DietType.ToString() == dietType).Select(a => a.ID).FirstOrDefault();
            return data;
        }

        public string GetFoodByFoodID(string foodID)
        {
            var data = db.Foods.Where(a => a.ID.ToString() == foodID && !a.IsDeleted).Select(a => a.Name).SingleOrDefault();
            return data;
        }

    }
}
