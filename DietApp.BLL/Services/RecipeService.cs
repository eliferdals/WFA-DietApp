using DietApp.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BLL.Services
{
    public class RecipeService
    {
        RecipeRepository recipeRepository;

        public RecipeService()
        {
            recipeRepository = new RecipeRepository();
        }
        public int GetRecipeIDByNameDietType(string name, string dietType)
        {
            return recipeRepository.GetRecipeIDByNameDietType(name, dietType);
        }

        public List<string> GetRecipesByRecipeTypeAndDietType(string recipeType, string dietTypeID)
        {
            return recipeRepository.GetRecipesByRecipeTypeAndDietType(recipeType, dietTypeID);
        }

        public string GetRecipesContext(int recipeID, string dietType)
        {
            return recipeRepository.GetRecipesContext(recipeID, dietType);
        }

        public string GetRecipesTitle(int recipeID, string dietType)
        {
            return recipeRepository.GetRecipesTitle(recipeID, dietType);
        }

        public int GetRecipesCalorieValue(int recipeID, string dietType)
        {
            return recipeRepository.GetRecipesCalorieValue(recipeID, dietType);
        }


    }
}
