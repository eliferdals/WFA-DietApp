using DietApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.Repositories
{
    
    public class MealDetailRepository
    {
        DietAppDbContext db;

        public MealDetailRepository()
        {
            db = new DietAppDbContext();
        }

        // Bir usera ait tüm meal detailler

        public List<MealDetail> GetByUserID(int userID)
        {
            return db.MealDetails.Where(a=>a.UserID == userID && !a.IsDeleted).ToList();
        }

        public List<MealDetail> GetByUserID(int userID, DateTime date)
        {
            return db.MealDetails.Where(a => a.UserID == userID && !a.IsDeleted && a.CreationDate==date).ToList();
        }


        // id üzerinden mealdetail bulma, bu id ye sahip mealdetaili bul bana ver
        public MealDetail GetByMealDetailID (int mealDetailID)
        {
            return db.MealDetails.Where(a=> a.ID== mealDetailID&& !a.IsDeleted).SingleOrDefault();
        }

        public List<MealDetail> GetMealDetails(int userId, int mealId, DateTime creationDate)
        {
            return  db.MealDetails.Where(a => a.UserID == userId && a.MealID == mealId && a.CreationDate == creationDate &&!a.IsDeleted).ToList();
        }

        // mealdetail insert etme

        public bool InsertMealDetail(MealDetail model)
        {
            string msg = "";
            try
            {
                MealDetail mealDetail = new MealDetail()
                {
                    CreationDate=model.CreationDate,
                    Food=db.Foods.Where(a=>a.ID==model.FoodID).FirstOrDefault(),
                    FoodID=model.FoodID,
                    IsDeleted=model.IsDeleted,
                    Meal=db.Meals.Where(a=>a.ID==model.MealID).FirstOrDefault(),
                    MealID=model.MealID,
                    Quantity=model.Quantity,
                    QuantityType=model.QuantityType,
                    User=db.Users.Where(a=>a.ID==model.ID).FirstOrDefault(),
                    UserID=model.UserID

                };

                db.MealDetails.Add(mealDetail);
                return db.SaveChanges() > 0;
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    msg += ("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);

                    foreach (var ve in eve.ValidationErrors)
                    {
                        msg += ("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            
        }

        // mealDetail update etme

        public bool UpdateMealDetail(MealDetail mealDetail)
        {
            MealDetail updatedMealDetail = GetByMealDetailID(mealDetail.ID);
            updatedMealDetail.UpdateDate = DateTime.Now;
            updatedMealDetail.Food = db.Foods.Where(a=>a.ID==mealDetail.FoodID).FirstOrDefault();
            updatedMealDetail.FoodID = mealDetail.FoodID;
            updatedMealDetail.Quantity = mealDetail.Quantity;
            updatedMealDetail.QuantityType = mealDetail.QuantityType;
            return db.SaveChanges() > 0;

        }

        // mealDetail silme

        public bool DeleteMealDetail(int userId, int mealId, DateTime creationDate)
        {
            try
            {
                List<MealDetail> mealDetails = db.MealDetails.Where(a => a.UserID == userId && a.MealID == mealId && a.CreationDate == creationDate).ToList();
                foreach (var mealDetail in mealDetails)
                {
                    mealDetail.IsDeleted = true;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public bool DeleteMealDetailByMealDetailId(int mealDetailId)
        {
            MealDetail mealDetail = db.MealDetails.Where(a => a.ID == mealDetailId).FirstOrDefault();
            mealDetail.IsDeleted = true;

            return db.SaveChanges() > 0;
        }

        //kişinin id'ye göre yediği tüm mealları verir.
        public List<string> GetFoodIDByUserID(int userID)
        {
            return db.MealDetails.Where(a => a.UserID == userID && !a.IsDeleted).Select(a => a.FoodID.ToString()).ToList();
        }

        //food id ve user id vererek detayları alma
        public List<string> GetFoodNameByUserIDFoodID(int foodID, int userID)
        {
            var data = db.MealDetails.Where(a => a.UserID == userID && a.FoodID == foodID && !a.IsDeleted).Select(a => a.Food.Name).ToList();
            return data;
        }

        public List<int> GetQuantityByUserIDFoodID(int foodID, int userID)
        {
            var data = db.MealDetails.Where(a => a.UserID == userID && a.FoodID == foodID && !a.IsDeleted).Select(a => a.Quantity).ToList();
            return data;
        }
        public List<string> GetMealByUserIDFoodID(int foodID, int userID)
        {
            var data = db.MealDetails.Where(a => a.UserID == userID && a.FoodID == foodID && !a.IsDeleted).Select(a => a.Meal.Name).ToList();
            return data;
        }

        public string GetMostEatenFoodName(int userID)
        {
            var data = db.MealDetails.Where(a => a.UserID == userID && !a.IsDeleted).Select(a => a.FoodID).ToList();
            int enbuyuksayi = 0;
            string name = null;
            foreach (var item in data)
            {
                var data2 = db.MealDetails.Where(a => a.FoodID == item).Count();
                if (enbuyuksayi < data2)
                {
                    enbuyuksayi = data2;
                    var data3 = db.Foods.Where(a => a.ID == item && !a.IsDeleted).Select(a => a.Name).SingleOrDefault();
                    name = data3;
                }

            }
            return name;

        }

    }
}
