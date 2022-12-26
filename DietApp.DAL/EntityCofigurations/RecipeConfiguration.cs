using DietApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.EntityCofigurations
{
    internal class RecipeConfiguration : EntityTypeConfiguration<Recipe>
    {
        public RecipeConfiguration()
        {
            Property(a=>a.Name).IsRequired().HasMaxLength(100);
            Property(a=>a.RecipeTitle).IsRequired().HasMaxLength(1000);
            Property(a => a.RecipeContext).IsRequired().HasMaxLength(5000);
            Property(a => a.CalorieValue).IsRequired();

        }
    }
}
