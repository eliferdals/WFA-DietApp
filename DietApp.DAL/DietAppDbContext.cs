using DietApp.DAL.EntityCofigurations;
using DietApp.DAL.Strategy;
using DietApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL
{
    internal class DietAppDbContext : DbContext
    {
        public DietAppDbContext():base("Data Source=.;Initial Catalog=DietAppDB;Integrated Security=true")
        {
            Database.SetInitializer(new DietAppStrategy());

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealDetail> MealDetails { get; set; }
        public DbSet<Nutritionist> Nutritionists { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<UsefullInformation> UsefullInformations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAction> UserActions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new FoodConfiguration());
            modelBuilder.Configurations.Add(new MealConfiguration());
            modelBuilder.Configurations.Add(new NutritionistConfiguration());
            modelBuilder.Configurations.Add(new RecipeConfiguration());
            modelBuilder.Configurations.Add(new UsefullInformationConfiguration());
            modelBuilder.Configurations.Add(new UserActionConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());

        }




    }
}
