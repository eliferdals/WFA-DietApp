using DietApp.BLL.Services;
using DietApp.Model.Entities;
using DietApp.Model.Enum;
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
    public partial class UserRegister : Form
    {
        UserService userService;
        public UserRegister()
        {
            InitializeComponent();

        }

        private void UserRegister_Load(object sender, EventArgs e)
        {
            FillHeight();
            FillWeight();
            FillSmoke();
            FillDiet();
        }

        void FillWeight()
        {
            for (int i = 30; i < 200; i++)
            {
                cmbKilo.Items.Add(i);
            }
        }

        void FillHeight()
        {
            for (int i = 80; i < 250; i++)
            {
                cmbBoy.Items.Add(i);
            }
        }

        void FillSmoke()
        {
            cmbSigaraKullanim.Items.Add(SmokeType.Kullanıyor);
            cmbSigaraKullanim.Items.Add(SmokeType.Kullanmıyor);

        }

        void FillDiet()
        {

            cmbDiyetBicimi.Items.Add(DietType.Klasik);
            cmbDiyetBicimi.Items.Add(DietType.Vegan);

        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            userService = new UserService();

            string firstName = txtAd.Text;
            string lastName = txtSoyad.Text;
            string password = txtSifre.Text;
            string passwordRepeat = txtSifreTekrar.Text;
            string email = txtMail.Text;
            string weight = cmbKilo.Text;
            string height = cmbBoy.Text;
            DateTime birthDate = dateTimePickerDogumTarihi.Value;
            DateTime dateOfConception = dateTimePickerHamileKalmaTarihi.Value;
            string securityAnswer = txtGuvenlikSorusu.Text;
            string smokeType = cmbSigaraKullanim.Text;
            string diet = cmbDiyetBicimi.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(weight.ToString()) || string.IsNullOrEmpty(height.ToString()) || string.IsNullOrEmpty(dateOfConception.ToString()) || string.IsNullOrEmpty(smokeType) || string.IsNullOrEmpty(diet) || string.IsNullOrWhiteSpace(securityAnswer))
            { 
                MessageBox.Show("Lütfen bilgilerinizi eksiksiz giriniz");
                return;
            }

            if (!(password.Length >= 8 && password.Any(char.IsDigit) && !string.IsNullOrWhiteSpace(password) && password.Any(char.IsPunctuation)))
            {
                MessageBox.Show("Parolanız en az 8 karakterden oluşmalı, en az 1 rakam ve noktalama işareti içermelidir.");
                return;
            }


            if (password!= passwordRepeat)
            {
                MessageBox.Show("Şifreleriniz uyuşmuyor, kontrol ediniz.");
                return;
            }

            string hashPass = Utility.Generator.GenerateSHA256Hash(password);

            try
            {
                
                User user = new User();

                user.FirstName = firstName;
                user.LastName = lastName;
                user.Password = hashPass;
                user.Email = email;
                user.Weight = weight;
                user.Height = height;
                user.BirthDate = birthDate;
                user.DateOfConception = dateOfConception;
                user.SecurityAnswer = securityAnswer;
                user.SmokeType = smokeType==SmokeType.Kullanıyor.ToString() ?SmokeType.Kullanıyor:SmokeType.Kullanmıyor;
                user.DietType = diet==DietType.Klasik.ToString() ? DietType.Klasik:DietType.Vegan;
                
                user.CreationDate = DateTime.Now;
                user.IsDeleted = false;
                user.UserActions.Add(new UserAction { ActionType = ActionType.PasswordUpdate, IsDeleted = false, NewValue = hashPass, OldValue = hashPass, CreationDate = DateTime.Now });

                bool check = userService.InsertUser(user);
                MessageBox.Show(check ? "Kullanıcı eklendi" : "Kullanıcı eklenemedi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bu mail adresine ait kullanıcı bulunmaktadır.");
            }

            Helper.Helper.FormTemizle(this.Controls);

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }

        private void txtSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            txtSifreTekrar.PasswordChar = '*';
        }
    }
}
