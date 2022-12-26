using DietApp.DAL.Repositories;
using DietApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BLL.Services
{
    public class CategoryService
    {
        CategoryRepository categoryRepository;

        public CategoryService()
        {
            categoryRepository = new CategoryRepository();
        }

        public List<Category> GetCategories()
        {
            List<Category> categories = categoryRepository.GetCategories();
            return categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            Category category = categoryRepository.GetCategoryById(categoryId);
            return category;
        }

        public Category GetCategoryByName(string categoryName)
        {
            Category category = categoryRepository.GetCategoryByName(categoryName);
            return category;
        }

    }
}
