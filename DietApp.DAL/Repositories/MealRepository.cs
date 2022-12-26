using DietApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.Repositories
{
    public class MealRepository
    {
        DietAppDbContext db;
        

        public MealRepository()
        {
            db = new DietAppDbContext();

        }
        public Meal GetMealByName(string name)
        {
            return db.Meals.Where(a => a.Name == name && !a.IsDeleted).FirstOrDefault();
        }

        public Meal GetMealById(int id)
        {
            return db.Meals.Where(a => a.ID == id && !a.IsDeleted).FirstOrDefault();
        }

        public List<Meal> GetAll()
        {
            return db.Meals.Where(a => !a.IsDeleted).ToList();
        }
    }
}
