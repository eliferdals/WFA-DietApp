using DietApp.BLL.Services;
using DietApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_DietApp
{
    public partial class UserChangePassword : Form
    {
        UserService userService;
        public UserChangePassword()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            userService = new UserService();
            string mail = txtMail.Text;
            User user = userService.GetUserByMail(mail);
            string newPass = txtYeniSifre.Text;

            if (string.IsNullOrWhiteSpace(mail))
            {
                MessageBox.Show("Lütfen mail adresinizi giriniz");
                return;
            }


            if (!(newPass.Length >= 8 && newPass.Any(char.IsDigit) && !string.IsNullOrWhiteSpace(newPass) && newPass.Any(char.IsPunctuation)))
            {
                MessageBox.Show("Parolanız en az 8 karakterden oluşmalı, en az 1 rakam ve noktalama işareti içermelidir.");
                return;
            }
            string newPassRepeat = txtYeniSifreTekrar.Text;


            if (newPass != newPassRepeat)
            {
                MessageBox.Show("Şifreleriniz uyuşmuyor, kontrol ediniz.");
                return;
            }
            

            if (user!=null)
            {
                string securityAnswer = txtIlkEvcilHayvanAdi.Text;

                if (string.IsNullOrWhiteSpace(securityAnswer))
                { 
                    MessageBox.Show("Lütfen ilk evcil hayvanınızın adını giriniz."); 
                    return ;
                }


                if (userService.CheckUserAndSecurityAnswer(user, securityAnswer, mail))
                {
                    if ( newPass== newPassRepeat)
                    {
                        string hashPass = Utility.Generator.GenerateSHA256Hash(newPass);
                        string hashOldPass = Utility.Generator.GenerateSHA256Hash(user.Password);

                        bool returner  = userService.UpdateUserPass(user.ID, hashPass, hashOldPass);
                        if (returner)
                            MessageBox.Show("Şifre değiştirme işlemi başarıyla gerçekleştirildi.");
                            
                        else
                            MessageBox.Show("Şifre değiştirme işlemi sırasında hata oluştu. Lütfen tekrar deneyin.");
                    }
                    else
                    {
                        MessageBox.Show("Girilen şifreler eşleşmiyor.");
                    }
                }
                else
                {
                    MessageBox.Show("Girilen mail adresi ve güvenlik sorusu eşleşmiyor.");
                }

            }
            else
            {
                MessageBox.Show("Girilen mail adresinde bir kullanıcı bulunmamaktadır");
            }

            Helper.Helper.FormTemizle(this.Controls);
        }

        private void UserChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
