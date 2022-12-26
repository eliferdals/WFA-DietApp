using DietApp.DAL.Repositories;
using DietApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BLL.Services
{
    public class NutritionistService
    {
        NutritionistRepository nutritionistRepositoy;

        public NutritionistService()
        {
            nutritionistRepositoy = new NutritionistRepository();
        }

        public Nutritionist CheckNutritionistLogin(string eMail, string password)
        {
            if (string.IsNullOrWhiteSpace(eMail) || string.IsNullOrWhiteSpace(password)) throw new Exception("Email ve/veya şifre eksik");

            return nutritionistRepositoy.CheckNutritionistLogin(eMail, password);

        }

        public List<User> GetAllUser()
        {
            return nutritionistRepositoy.GetAllUser();
        }

        public User ViewUserDetails(int userID)
        {
            if(userID <= 0) throw new Exception("Lütfen bir seçim yapınız.");
            return nutritionistRepositoy.ViewUserDetails(userID);
        }
    }
}
