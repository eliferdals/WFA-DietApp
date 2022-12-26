using DietApp.DAL.Repositories;
using DietApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BLL.Services
{
    public class MealService
    {
        MealRepository mealRepository;

        public MealService()
        {
            mealRepository = new MealRepository();
        }

        public Meal GetMealByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new Exception("Eksik parametre.");
            Meal meal = mealRepository.GetMealByName(name);
            return meal;
        }

        public Meal GetMealById(int id)
        {
            Meal meal = mealRepository.GetMealById(id);
            return meal;
        }

        public List<Meal> GetAll()
        {
            List<Meal> meals = mealRepository.GetAll();
            return meals; 
        }
    }
}
