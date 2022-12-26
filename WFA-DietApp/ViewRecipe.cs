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
    public partial class ViewRecipe : Form
    {
        RecipeService recipeService = new RecipeService();
        public ViewRecipe()
        {
            InitializeComponent();
        }
        User user;
        public ViewRecipe(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void ViewRecipe_Load(object sender, EventArgs e)
        {
            cmbBxKategori.Items.AddRange(Enum.GetNames(typeof(RecipeType)));
        }

        private void cmbBxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxKategori.SelectedItem != null)
            {
                string recipeType = cmbBxKategori.SelectedItem.ToString();
                var data = recipeService.GetRecipesByRecipeTypeAndDietType(recipeType, user.DietType.ToString());
                cmbBxYemekSecimi.Items.Clear();
                foreach (var item in data)
                {
                    cmbBxYemekSecimi.Items.Add(item);
                }
            }
        }

        private void btnTarifiGetir_Click(object sender, EventArgs e)
        {
            if (cmbBxYemekSecimi.SelectedItem != null)
            {
                string name = cmbBxYemekSecimi.SelectedItem.ToString();
                int recipeID = recipeService.GetRecipeIDByNameDietType(name, user.DietType.ToString());
                var context = recipeService.GetRecipesContext(recipeID, user.DietType.ToString());
                var title = recipeService.GetRecipesTitle(recipeID, user.DietType.ToString());
                textBox2.Text = context.ToString();
                textBox1.Text = title.ToString();

                var caloriValue = recipeService.GetRecipesCalorieValue(recipeID, user.DietType.ToString());
                lblKalori.Text = caloriValue.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen bir tarif seçiniz");
            }
        }
    }
}
