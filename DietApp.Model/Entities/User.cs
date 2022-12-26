using DietApp.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Model.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            UserActions = new HashSet<UserAction>();
            MealDetails = new HashSet<MealDetail>();
        }
        private string firstName;
        public string FirstName 
        {
            get { return firstName; }
            set
            {
                if (value.Length > 3 && !value.Any(char.IsDigit) && !string.IsNullOrWhiteSpace(value)) firstName = value;
                else throw new Exception("Hatalı giriş yaptınız, lütfen kontrol ediniz. ");
            }
                
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (!value.Any(char.IsDigit) && !string.IsNullOrWhiteSpace(value)) lastName = value;
                else throw new Exception("Hatalı giriş yaptınız, lütfen kontrol ediniz. ");
            }

        }

        public string Password { get; set; }


        private string email;   

        public string Email
        {
            get {  return email; }
            set
            {
                if (value.EndsWith("@gmail.com") || value.EndsWith("@hotmail.com") || value.EndsWith("@live.com") || value.EndsWith("@yahoo.com") || value.EndsWith("@outlook.com")) email = value;
                else throw new Exception("Lütfen geçerli bir mail adresi giriniz.");
            }
        }


        public string Weight { get; set; }

        public string Height { get; set; }


        private DateTime birthDate;

        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                if (value <= DateTime.Now.AddMonths(-18)) birthDate = value;
                else throw new Exception("Kullanıcı 18 yaşından büyük olmalıdır");
            }
        }

        private DateTime dateOfConception;
        
        public DateTime DateOfConception
        {
            get { return dateOfConception; }
            set
            {
                if (value > DateTime.Now.AddMonths(-10)) dateOfConception = value;
                else throw new Exception("Geçerli bir tarih giriniz.");
            }
        }


        private string securityAnswer;
        public string SecurityAnswer
        {
            get { return securityAnswer; }
            set
            {
                if (value.Length > 2 && !string.IsNullOrWhiteSpace(value)) securityAnswer = value;
                else throw new Exception("Güvenlik cevabınız en az iki karakterden oluşmalıdır.");
            }

        }

        public TrimesterType? TrimesterType { get; set; }

        public SmokeType SmokeType { get; set; }

        public virtual ICollection<UserAction> UserActions { get; set; }

        public virtual ICollection<MealDetail> MealDetails { get; set; }

        public DietType DietType { get; set; }

        //bool IsValidEmail(string email)
        //{
        //    var trimmedEmail = email.Trim();

        //    if (trimmedEmail.EndsWith("."))
        //    {
        //        return false; 
        //    }
        //    try
        //    {
        //        var addr = new System.Net.Mail.MailAddress(email);
        //        return addr.Address == trimmedEmail;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

    }
}
