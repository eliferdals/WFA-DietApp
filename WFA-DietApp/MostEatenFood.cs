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
    public partial class MostEatenFood : Form
    {
        MealDetailService mealDetailService = new MealDetailService();
        public MostEatenFood()
        {
            InitializeComponent();
        }
        User user;
        public MostEatenFood(User user)
        {
            this.user = user;
            InitializeComponent();
        }


        private void MostEatenFood_Load(object sender, EventArgs e)
        {
            string foodName = mealDetailService.GetMostEatenFoodName(user.ID);
            lstbxEnCokYenenYemek.Items.Add(foodName);
        }
    }
}
