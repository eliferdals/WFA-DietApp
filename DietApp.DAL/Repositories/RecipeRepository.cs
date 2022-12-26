using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.Repositories
{
    public class RecipeRepository
    {
        DietAppDbContext db;

        public RecipeRepository()
        {
            db = new DietAppDbContext();
        }

        //Recipe adına ve diet tipine  göre recipe id

        public int GetRecipeIDByNameDietType(string name, string dietType)
        {
            var recipeID = db.Recipes.Where(a => a.Name == name && a.DietType.ToString() == dietType).Select(a => a.ID).SingleOrDefault();
            return recipeID;
        }

        //Recipe tipine göre recipeları getirme

        public List<string> GetRecipesByRecipeTypeAndDietType(string recipeType, string dietTypeID)
        {
            var recipe = db.Recipes.Where(a => a.RecipeType.ToString() == recipeType && a.DietType.ToString() == dietTypeID && !a.IsDeleted).Select(a => a.Name).ToList();
            return recipe;
        }

        //Bütün recipların context'ini getirme

        public string GetRecipesContext(int recipeID, string dietType)
        {
            var recipe = db.Recipes.Where(a => a.ID == recipeID && a.DietType.ToString() == dietType && !a.IsDeleted).Select(a => a.RecipeContext).SingleOrDefault();
            return recipe;
        }

        //Bütün recipların title'ini getirme

        public string GetRecipesTitle(int recipeID, string dietType)
        {
            var recipe = db.Recipes.Where(a => a.ID == recipeID && a.DietType.ToString() == dietType && !a.IsDeleted).Select(a => a.RecipeTitle).SingleOrDefault();
            return recipe;
        }

        // Recipe'ın kalorisini getirme
        public int GetRecipesCalorieValue(int recipeID, string dietType)
        {
            var recipe = db.Recipes.Where(a => a.ID == recipeID && a.DietType.ToString() == dietType && !a.IsDeleted).Select(a => a.CalorieValue).SingleOrDefault();
            return recipe;
        }



    }
}
