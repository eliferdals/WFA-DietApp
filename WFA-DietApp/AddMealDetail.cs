using DietApp.BLL.Services;
using DietApp.Model.Entities;
using DietApp.Model.Enum;
using System;
using System.CodeDom;
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
    public partial class AddMealDetail : Form
    {
        CategoryService categoryService;
        FoodService foodService;
        MealService mealService;
        MealDetailService mealDetailService;
        UserService userService;

        public AddMealDetail()
        {
            InitializeComponent();
        }

        int mealId = 0;
        User user;
        public AddMealDetail(int mealId, User user)
        {
            InitializeComponent();
            this.mealId = mealId;
            this.user = user;
            mealService = new MealService();
            mealDetailService = new MealDetailService();
            categoryService = new CategoryService();
            foodService = new FoodService();
            userService = new UserService();
        }

        private void AddMealDetail_Load(object sender, EventArgs e)
        {
            FillCategories();
        }

        void FillCategories()
        {
            
            var categories = categoryService.GetCategories();
            foreach (var item in categories)
            {
                cmbKategori.Items.Add(item.Name);
            }
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string selectedCategory = cmbKategori.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(selectedCategory))
            {
                var category = categoryService.GetCategoryByName(selectedCategory);

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
            lblSecilenUrun.Text = selectedFoodName;

            Food food= foodService.GetFoodsById(int.Parse(selectedFoodID));

            if (food!=null)
            {
                string quantityName = (byte)food.QuantityType == 1 ? QuantityType.Gram.ToString() : ((byte)food.QuantityType == 2 ? QuantityType.Adet.ToString() : QuantityType.Mililiter.ToString());
                lblQuantity.Text = "(" + quantityName + ")";

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            selectedQuantity = txSecilenUrunMiktari.Text;

            if (!string.IsNullOrWhiteSpace(selectedQuantity) && !string.IsNullOrEmpty(selectedFoodName))
            {

                ListViewItem lvi = new ListViewItem(selectedFoodID);
                lvi.SubItems.Add(selectedFoodName);
                lvi.SubItems.Add(selectedQuantity);

                lstViewEklenenUrunler.Items.Add(lvi);

            }
            else
            {
                MessageBox.Show("Lütfen ürün ve/veya ürün adedi giriniz.");
            }

        
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstViewEklenenUrunler.Items)
            {
                User userDetail = userService.GetUserId(user.ID);

                int id = int.Parse(item.SubItems[0].Text);
                int quantity = int.Parse(item.SubItems[2].Text);
                
                var food = foodService.GetFoodsById(id);
                MealDetail mealDetail = new MealDetail()
                {
                    FoodID = id,
                    CreationDate = DateTime.Now,
                    IsDeleted = false,
                    Meal = mealService.GetMealById(mealId),
                    MealID=mealId,
                    Quantity=quantity,
                    QuantityType=food.QuantityType,
                    UserID= user.ID
                };

                mealDetailService.InsertMealDetail(mealDetail);

            }

            MessageBox.Show("Öğün ekleme işleminiz başarılı");

            this.Hide();

            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name == "UserProfile") Application.OpenForms[i].Close();
            }


            UserProfile userProfile = new UserProfile(user);
            userProfile.ShowDialog();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstViewEklenenUrunler.SelectedItems.Count !=0) lstViewEklenenUrunler.Items.Remove(lstViewEklenenUrunler.SelectedItems[0]);
            else
            {
                MessageBox.Show("Lütfen silinecek besin seçiniz.");
            }
        }

    }
}
