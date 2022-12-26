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
    public partial class AddMeal : Form
    {
        MealService mealService;
        UsefullInformationService usefullInformationService;
        public AddMeal()
        {
            
            InitializeComponent();
        }

        User user;
        public AddMeal(User user)
        {
            mealService = new MealService();
            usefullInformationService = new UsefullInformationService();
            this.user = user;
            InitializeComponent();
        }

        private void btnKahvalti_Click(object sender, EventArgs e)
        {
            RedirectToForm(btnKahvalti.Text);
            

        }

        private void btnOgleYemegi_Click(object sender, EventArgs e)
        {
            Meal meal = mealService.GetMealByName(btnKahvalti.Text);

            RedirectToForm(btnOgleYemegi.Text);
            
        }

        private void btnAksamYemegi_Click(object sender, EventArgs e)
        {
            RedirectToForm(btnAksamYemegi.Text);
            
        }

        private void btnAraOgunler_Click(object sender, EventArgs e)
        {
            RedirectToForm(btnAraOgunler.Text);
            
        }

        void RedirectToForm(string mealName)
        {
            Meal meal = mealService.GetMealByName(mealName);

            AddMealDetail addMealDetail = new AddMealDetail(meal.ID, user);
            this.Hide();
            addMealDetail.ShowDialog();
            this.Close();
        }

        private void AddMeal_Load(object sender, EventArgs e)
        {
            int number = usefullInformationService.GetUsefulInformationCount();

            Random rnd = new Random();
            int sayi = rnd.Next(1, number);
            int sayi2 = rnd.Next(1, number);
            if (sayi == sayi2)
            {
                do
                {
                    sayi2 = rnd.Next(1, number);
                } while (sayi == sayi2);
            }
            label1.Text = "*" + usefullInformationService.GetInformationById(sayi);
            label2.Text = "*" + usefullInformationService.GetInformationById(sayi2);



        }

        private void AddMeal_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
