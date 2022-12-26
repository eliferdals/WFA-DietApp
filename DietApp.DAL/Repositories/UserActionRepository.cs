using DietApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.Repositories
{
    public class UserActionRepository
    {
        DietAppDbContext db;
        public UserActionRepository()
        {
            db = new DietAppDbContext();
        }

        // son 3 şifreyi alma

        public List<UserAction> GetLastThreePassword(int userID)
        {
            return db.UserActions.Where(a => a.UserID == userID && !a.IsDeleted).OrderByDescending(a => a.CreationDate).Take(3).ToList();

        }

        // Kilo bilgisi ya da password ekleme
        public bool InsertUserAction(UserAction userAction)
        {
            db.UserActions.Add(userAction);
            return db.SaveChanges() > 0;
        }

        // kullanılan son parola ya da girilen son kiloyu getirir.
        public UserAction GetActiveUserAction(int userID)
        {
            return db.UserActions.Where(a => a.UserID == userID && !a.IsDeleted).OrderByDescending(a => a.CreationDate).FirstOrDefault();
        }
    }
}
