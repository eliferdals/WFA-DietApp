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
    public partial class AddFood : Form
    {
        FoodService foodService;
        CategoryService categoryService;
        public AddFood()
        {
            InitializeComponent();
            foodService = new FoodService();
            categoryService = new CategoryService();
        }

        private void AddFood_Load(object sender, EventArgs e)
        {
            FillQuantity();
            FillCategories();
        }
        void FillQuantity()
        {
            cmbMiktar.Text = "Seçiniz";
            cmbMiktar.Items.Add(QuantityType.Gram);
            cmbMiktar.Items.Add(QuantityType.Mililiter);
            cmbMiktar.Items.Add(QuantityType.Adet);
        }

        void FillCategories()
        {
            cmbKategori.Text = "Seçiniz";
            List<Category> category = categoryService.GetCategories();
            foreach (var item in category)
            {
                cmbKategori.Items.Add(item.Name);
            }
            
        }

        private void btnResimSec_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;

        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            string name = txtAdi.Text;
            string calorie = txtKalori.Text;
            string protein = txtProtein.Text;
            string calcium = txtKalsiyum.Text;
            string fat = txtYag.Text;
            string carbonhydrate = txtKarbonhidrat.Text;
            string folicAcid = txtFolik.Text;
            string description = txtAciklama.Text;
            string quantityType = cmbMiktar.SelectedItem != null ? cmbMiktar.SelectedItem.ToString() : "";
            string foodPicture = pictureBox1.ImageLocation;
            string category = cmbKategori.SelectedItem != null ? cmbKategori.SelectedItem.ToString() : "";

            try
            {
                if (string.IsNullOrWhiteSpace(calcium) || string.IsNullOrWhiteSpace(calorie) || string.IsNullOrWhiteSpace(carbonhydrate) || string.IsNullOrWhiteSpace(fat) || string.IsNullOrWhiteSpace(folicAcid) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(protein) || string.IsNullOrWhiteSpace(quantityType) || string.IsNullOrWhiteSpace(category)) throw new Exception("Lütfen bilgilerinizi eksiksiz giriniz");

                var cat = categoryService.GetCategoryByName(category);

                Food food = new Food();

                food.CalciumValue = Convert.ToDouble(calcium);
                food.CalorieValue = Convert.ToInt32(calorie);
                food.CarbonhydrateValue = Convert.ToDouble(carbonhydrate);
                food.CategoryID = cat.ID;
                food.CreationDate = DateTime.Now;
                food.Description = description;
                food.FatValue = Convert.ToDouble(fat);
                food.FolicAcidValue = Convert.ToDouble(folicAcid);
                food.FoodPicture = foodPicture;
                food.IsDeleted = false;
                food.Name = name;
                food.ProteinValue = Convert.ToDouble(protein);
                food.QuantityType = quantityType == "Gram" ? QuantityType.Gram : (quantityType == "Mililiter" ? QuantityType.Mililiter : QuantityType.Adet);

                bool check = foodService.InsertFood(food);
                MessageBox.Show(check ? "Besin Eklendi" : "Besin Eklenemedi");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
