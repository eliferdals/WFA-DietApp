using DietApp.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Model.Entities
{
    public class Recipe : BaseEntity
    {
        public Recipe()
        {
            //Users = new HashSet<User>();
            //Diets = new HashSet<Diet>();
        }
        public string Name { get; set; }

        public string RecipeTitle { get; set; }

        public string RecipeContext { get; set; }

        public int CalorieValue { get; set; }

        public RecipeType RecipeType { get; set; }

        public int? UserID { get; set; }
        public virtual User User { get; set; }
        public DietType DietType { get; set; }
    }
}
