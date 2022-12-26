using DietApp.DAL.Repositories;
using DietApp.Model.Entities;
using DietApp.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BLL.Services
{
    public class UserService
    {
        UserRepository userRepository;

        public UserService()
        {
            userRepository = new UserRepository();
        }

        public bool InsertUser(User user)
        {
            
            UserAction firstPass = user.UserActions.Where(a => a.ActionType == ActionType.PasswordUpdate).FirstOrDefault();

            if (firstPass == null) throw new Exception("Lütfen şifrenizi girin.");

            //user.TrimesterType = TrimesterType.FirstTrimester;
            user.CreationDate = DateTime.Now;
            //user.UserActions.Where(a => a.ActionType == ActionType.PasswordUpdate).FirstOrDefault().CreationDate = DateTime.Now;

            return userRepository.InsertUser(user);

        }

        public User CheckLogin(string Email, string password)
        {
            if (string.IsNullOrWhiteSpace(Email) && string.IsNullOrWhiteSpace(password)) throw new Exception("Mail ve/veya şifre eksik");

            return userRepository.CheckLogin(Email, password);

        }

        public bool CheckUserMail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) throw new Exception("Mail adresini giriniz.");
            return userRepository.CheckUserMail(email);
        }

        public User GetUserId(int id)
        {
            return userRepository.GetUserById(id);
        }

        public User GetUserByMail(string email)
        {
            User user = userRepository.GetUserByMail(email);
            return user;
        }

        public bool CheckUserAndSecurityAnswer(User user, string securityAnswer, string mail)
        {
            if (string.IsNullOrWhiteSpace(securityAnswer)) throw new Exception("Lütfen ilk evcil hayvanınızın adını giriniz.");
            {
                return userRepository.CheckUserAndSecurityAnswer(user, securityAnswer, mail);
            }

        }

        public bool UpdateUserPass(int userId, string newPass, string oldPass)
        {
            if (userId > 0 && !string.IsNullOrEmpty(newPass))
            {
                return userRepository.UpdateUserPass(userId, newPass, oldPass);
            }
            else
            {
                throw new Exception("Lütfen ilk evcil hayvanınızın adını giriniz.");
            }
        }




    }
}
