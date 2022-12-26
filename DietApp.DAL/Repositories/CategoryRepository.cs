using DietApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.Repositories
{
    public class CategoryRepository
    {
        DietAppDbContext db;

        public CategoryRepository()
        {
            db = new DietAppDbContext();
        }

        // Bir usera ait tüm meal detailler

        public List<Category> GetCategories()
        {
            return db.Categories.Where(a => !a.IsDeleted).OrderBy(a=>a.Name).ToList();
        }
        public Category GetCategoryById(int categoryId)
        {
            return db.Categories.Where(a => a.ID==categoryId && !a.IsDeleted).FirstOrDefault();
        }

        public Category GetCategoryByName(string categoryName)
        {
            return db.Categories.Where(a => a.Name == categoryName && !a.IsDeleted).FirstOrDefault();
        }
    }
}
