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
    public partial class FoodVarietyReport : Form
    {
        MealDetailService mealDetailService = new MealDetailService();
        FoodService foodService = new FoodService();

        public FoodVarietyReport()
        {
            InitializeComponent();
        }
        User user;
        public FoodVarietyReport(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        

        private void FoodVarietyReport_Load(object sender, EventArgs e)
        {
            var data = mealDetailService.GetFoodIDByUserID(Convert.ToInt32(user.ID));
            foreach (var item in data)
            {
                string foodName = foodService.GetFoodByFoodID(item);
                if (!cmbBxYemekAdi.Items.Contains(foodName))
                {
                    cmbBxYemekAdi.Items.Add(foodName);
                }
            }
        }

        private void cmbBxYemekAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string foodName = cmbBxYemekAdi.SelectedItem.ToString();
            int foodID = foodService.GetFoodIDByFoodName(foodName,user.DietType.ToString());
            lstViewYemekCesidi.Items.Clear();

            var data1 = mealDetailService.GetFoodNameByUserIDFoodID(foodID, Convert.ToInt32(user.ID));
            var data2 = mealDetailService.GetQuantityByUserIDFoodID(foodID, Convert.ToInt32(user.ID));
            var data3 = mealDetailService.GetMealByUserIDFoodID(foodID, Convert.ToInt32(user.ID));

            int i = 0;
            foreach (var item in data1)
            {
                lstViewYemekCesidi.Items.Add(item);

                lstViewYemekCesidi.Items[i].SubItems.Add(data3[i]);
                lstViewYemekCesidi.Items[i].SubItems.Add(data2[i].ToString());
                i++;
            }
        }

        private void btnKullaniciProfilineDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnCokYenenYemekler_Click(object sender, EventArgs e)
        {
            MostEatenFood mostEatenFood = new MostEatenFood(user);
            this.Hide();
            mostEatenFood.ShowDialog();
            this.Show();
        }
    }
}
