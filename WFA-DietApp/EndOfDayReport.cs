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
    public partial class EndOfDayReport : Form
    {
        MealService mealService;
        MealDetailService mealDetailService;
        public EndOfDayReport()
        {
            InitializeComponent();
        }

        User user;
        public EndOfDayReport(User user)
        {
            this.user = user;
            InitializeComponent();
            mealService = new MealService();
            mealDetailService = new MealDetailService();
        }

        private void cmbOgunAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            double totalCalorie=0;

            string selectedMealName = cmbOgunAdi.SelectedItem.ToString();

            Meal meal = mealService.GetMealByName(selectedMealName);
            if (meal!=null)
            {
                List<MealDetail> mealDetails = mealDetailService.GetMealDetails(user.ID, meal.ID, Convert.ToDateTime(DateTime.Now.ToString("d")));
                foreach (var item in mealDetails)
                {
                    if (item.Food.QuantityType == QuantityType.Gram || item.Food.QuantityType == QuantityType.Mililiter)
                    {

                        totalCalorie += ((item.Food.CalorieValue) * (item.Quantity)) / 100;
                    }
                    else
                    {
                        totalCalorie += ((item.Food.CalorieValue) * (item.Quantity));
                    }

                }

            }

            lblKalori.Text = totalCalorie.ToString();

        }

        void FillMeal()
        {
            List<Meal> meals = mealService.GetAll();
            foreach (var item in meals)
            {
                cmbOgunAdi.Items.Add(item.Name);
            }
            cmbOgunAdi.Text = "Seçiniz";
        }

        private void EndOfDayReport_Load(object sender, EventArgs e)
        {
            FillMeal();
        }


    }
}
