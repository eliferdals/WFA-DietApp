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
    public partial class NutritionistLogin : Form
    {
        NutritionistService nutritionistService;
        public NutritionistLogin()
        {
            InitializeComponent();
        }

        private void txtParola_TextChanged(object sender, EventArgs e)
        {
            txtParola.PasswordChar = '*';
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string eMail = txtDiyetisyenMail.Text;
            string password = txtParola.Text;
            

            try
            {
                nutritionistService = new NutritionistService();
                Nutritionist nutritionist = nutritionistService.CheckNutritionistLogin(eMail, password);
                if (nutritionist != null)
                {
                    NutritionistProfile nutritionistProfile = new NutritionistProfile();
                    this.Hide();
                    nutritionistProfile.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Lütfen doğru bilgileri giriniz.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            Helper.Helper.FormTemizle(this.Controls);
        }
    }
}
