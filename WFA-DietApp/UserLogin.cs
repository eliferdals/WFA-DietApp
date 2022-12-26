using DietApp.BLL.Services;
using DietApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_DietApp
{
    public partial class UserLogin : Form
    {
        UserService userService;
        public UserLogin()
        {
            InitializeComponent();
        }

        private void lnkLblHenuzUyeDegilMisin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegister userRegister = new UserRegister();
            this.Hide();
            userRegister.ShowDialog();
            this.Show();
        }

        private void lnkLblSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserChangePassword userChangePassword = new UserChangePassword();
            this.Hide();
            userChangePassword.ShowDialog();
            this.Show();
        }

        private void lnkLblDiyetisyenGirisi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NutritionistLogin nutritionistLogin = new NutritionistLogin();
            this.Hide();
            nutritionistLogin.ShowDialog();
            this.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string eMail = txtKullaniciMail.Text;
            string password = txtbxParola.Text;
            string hashPassword = Utility.Generator.GenerateSHA256Hash(password);
            string msg = "";
            try
            {
                userService = new UserService();
                User user = userService.CheckLogin(eMail, hashPassword);
                
                if (user != null)
                {
                    UserProfile userProfile = new UserProfile(user);
                    this.Hide();
                    userProfile.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen doğru bilgileri giriniz.");
                }
            }
            catch (DbEntityValidationException exx)
            {
                foreach (var eve in exx.EntityValidationErrors)
                {
                    msg += ("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);

                    foreach (var ve in eve.ValidationErrors)
                    {
                        msg += ("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            Helper.Helper.FormTemizle(this.Controls);
        }

        private void txtbxParola_TextChanged(object sender, EventArgs e)
        {
            txtbxParola.PasswordChar = '*';
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
