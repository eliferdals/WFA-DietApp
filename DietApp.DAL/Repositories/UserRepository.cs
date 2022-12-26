using DietApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.Repositories
{
    public class UserRepository
    {
        DietAppDbContext db;
        UserActionRepository userActionRepository;
        

        public UserRepository()
        {
            db = new DietAppDbContext();
            userActionRepository = new UserActionRepository();
           
        }

        // Yeni kullanıcı kaydı ekleme
        public bool InsertUser(User user)
        {
            string msg = "";
            try
            {
                db.Users.Add(user);
                return db.SaveChanges() > 0;
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    msg+= ("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    
                    foreach (var ve in eve.ValidationErrors)
                    {
                        msg+= ("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            
        }

        // Kullanıcı giriş bilgilerini kontrol etme
        public User CheckLogin(string Email, string password)
        {
            User user = db.Users.Where(a=>a.Email == Email &&a.Password ==password && !a.IsDeleted ).SingleOrDefault();
            return user;
        }

        // Update işleri için UserID

        public User GetUserById(int userID)
        {
            return db.Users.Where(a=> a.ID==userID && !a.IsDeleted).FirstOrDefault();
        }

        // Girilen mail adresi varmı

        public bool CheckUserMail(string email)
        {
            return db.Users.Where(a=>a.Email == email).Any();
        }

        // Mail adresine göre user bulma

        public User GetUserByMail(string email)
        {
            User user = db.Users.Where(a=>a.Email == email).SingleOrDefault();
            return user;
        }


        // verilen usera ve security answera göre 

        public bool CheckUserAndSecurityAnswer(User user, string securityAnswer, string mail)
        {
            return db.Users.Where(a => a.ID == user.ID && a.SecurityAnswer == securityAnswer && a.Email == mail).Any();
        }

        public bool UpdateUserPass(int userId, string newPass, string oldPass)
        {
            User user = db.Users.Where(a => a.ID == userId && !a.IsDeleted).SingleOrDefault();
            user.Password = newPass;
            var data = db.SaveChanges() > 0;
            if (data)
            {
                UserAction userAction = new UserAction()
                {
                    ActionType=Model.Enum.ActionType.PasswordUpdate,
                    CreationDate=DateTime.Now,
                    IsDeleted=false,
                    OldValue=oldPass,
                    NewValue=newPass,
                    UserID=userId
                };
                db.UserActions.Add(userAction);
                return db.SaveChanges()>0;
            }
            return false;
        }



    }
}
