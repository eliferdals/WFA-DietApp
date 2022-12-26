using DietApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.Repositories
{
    public  class NutritionistRepository
    {
        DietAppDbContext db;

        public NutritionistRepository()
        {
            db = new DietAppDbContext();
        }

        // Diyetisyen girişi kontrolü

        public Nutritionist CheckNutritionistLogin(string eMail,string password)
        {
            Nutritionist nutritionist = db.Nutritionists.Where(a=>a.Email == eMail && !a.IsDeleted).SingleOrDefault();
            if (nutritionist != null)
            {
                if(nutritionist.Password == password)
                {
                    return nutritionist;
                }
            }
            return null;    

        }

        // Kayıtlı tüm kullanıcıları listeleme

        public List<User> GetAllUser()
        {
            return db.Users.Where(a=> !a.IsDeleted).ToList();
        }

        // Seçilen Kullanıcın detaylarını görüntüleme

        public User ViewUserDetails(int userID)
        {
            var data = db.Users.Where(a => a.ID == userID && !a.IsDeleted).SingleOrDefault();
            return data;
        }

        // Aylık Rapor Görüntüleme
        public List<MealDetail> ViewMonthlyReport(int userID)
        {
            return db.MealDetails.Where(a => a.ID == userID && !a.IsDeleted && a.CreationDate <= DateTime.Now && a.CreationDate >= DateTime.Now.AddDays(-30)).ToList();
        }

        // seçilen 

    }
}
