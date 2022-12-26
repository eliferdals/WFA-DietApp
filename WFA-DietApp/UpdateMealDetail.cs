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
    public partial class UpdateMealDetail : Form
    {
        MealDetailService mealDetailService;
        CategoryService categoryService;
        FoodService foodService;
        public UpdateMealDetail()
        {
            InitializeComponent();
        }

        User user;
        int mealDetailId;
        DateTime date;
        public UpdateMealDetail(User user, int mealDetailId)
        {
            this.user = user;
            this.mealDetailId = mealDetailId;
            InitializeComponent();
            mealDetailService = new MealDetailService();
            categoryService = new CategoryService();
            foodService = new FoodService();
        }

        private void UpdateMealDetail_Load(object sender, EventArgs e)
        {
            MealDetail mealDetail = mealDetailService.GetByMealDetailID(mealDetailId);
            date = mealDetail.CreationDate;
            FillCategories(mealDetail.Food.Category.Name);
            FillFoods(mealDetail.Food.Category.Name);
            txtGüncenllenecekUrunMiktari.Text = mealDetail.Quantity.ToString();
            lblGuncellenecekUrun.Text = mealDetail.Food.Name;

        }

        void FillCategories(string categoryName)
        {

            var categories = categoryService.GetCategories();
            foreach (var item in categories)
            {
                cmbKategori.Items.Add(item.Name);
            }
            cmbKategori.SelectedText = categoryName;
        }

        void FillFoods(string categoryName)
        {
            if (!string.IsNullOrEmpty(categoryName))
            {
                var category = categoryService.GetCategoryByName(categoryName);

                var foods = foodService.GetFoodsByCategory(category.ID, user.DietType);

                lstViewUrunler.Items.Clear();
                foreach (var item in foods)
                {
                    ListViewItem lvi = new ListViewItem(item.ID.ToString());
                    lvi.SubItems.Add(item.Name);
                    lvi.SubItems.Add(item.CalorieValue.ToString());
                    lvi.SubItems.Add(item.ProteinValue.ToString());
                    lvi.SubItems.Add(item.CalciumValue.ToString());
                    lvi.SubItems.Add(item.CarbonhydrateValue.ToString());
                    lvi.SubItems.Add(item.FolicAcidValue.ToString());

                    lstViewUrunler.Items.Add(lvi);
                }
            }
        }

        string selectedFoodName;
        string selectedFoodID;
        string selectedQuantity;
        private void lstViewUrunler_DoubleClick(object sender, EventArgs e)
        {
            selectedFoodName = lstViewUrunler.SelectedItems[0].SubItems[1].Text;
            selectedFoodID = lstViewUrunler.SelectedItems[0].SubItems[0].Text;
            lblGuncellenecekUrun.Text = selectedFoodName;

            Food food = foodService.GetFoodsById(int.Parse(selectedFoodID));

            if (food != null)
            {
                string quantityName = (byte)food.QuantityType == 1 ? QuantityType.Gram.ToString() : ((byte)food.QuantityType == 2 ? QuantityType.Adet.ToString() : QuantityType.Mililiter.ToString());
                lblQuantity.Text = "(" + quantityName + ")";

            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (lstViewUrunler.SelectedItems.Count != 0)
            {
                MealDetail mealDetail = new MealDetail()
                {

                    ID = mealDetailId,
                    FoodID = int.Parse(selectedFoodID),
                    Quantity = int.Parse(txtGüncenllenecekUrunMiktari.Text),
                    UpdateDate = DateTime.Now,
                    UserID = user.ID
                };

                bool check = mealDetailService.UpdateMealDetail(mealDetail);
                if (check)
                {
                    MessageBox.Show("Güncelleme işleminiz başarıyla gerçekleştirildi.");
                    this.Hide();

                    for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                    {
                        if (Application.OpenForms[i].Name == "ViewMealDetail") Application.OpenForms[i].Close();
                    }


                    ViewMealDetail viewMealDetail = new ViewMealDetail(user,date);
                    viewMealDetail.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Güncelleme işleminiz sırasında hata oluştu.");
                }
                Helper.Helper.FormTemizle(this.Controls);
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçiniz.");
            }





        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillFoods(cmbKategori.Text);
        }
    }
}
