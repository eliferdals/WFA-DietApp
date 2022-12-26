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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFA_DietApp
{
    public partial class UserProfile : Form
    {
        MealDetailService mealDetailService;
        public UserProfile()
        {
            InitializeComponent();
        }

        User user;
        
        public UserProfile(User user)
        {
            InitializeComponent();
            this.user = user;
           
            mealDetailService = new MealDetailService();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            lblTrimesterBilgisiYazi.Text = FindTrimesterType(user).ToString();
            lblDiyetBicimiYazi.Text = user.DietType.ToString();
            lblMevcutAgirlikDurumuYazi.Text = user.Weight.ToString();
            lblVücutKitleIndexYazi.Text = FindVKI(user).ToString("0.##");
            lblGunlukHedefKaloriYazi.Text = FindTargetCalorie(user).ToString();
            double targetCalorie = FindTargetCalorie(user);

            List<MealDetail> mealDetails = mealDetailService.GetByUserID(user.ID);

            if (mealDetails != null )
            {
                double totalCalorie = 0;
                double totalCarbonhydrate = 0;
                double totalProtein = 0;
                double totalFat = 0;
                double totalFolicAcid = 0;
                double totalCalcium = 0;
                

                foreach (var item in mealDetails)
                {

                    if (item.CreationDate == Convert.ToDateTime(DateTime.Now.ToString("d")))
                    {
                        if (item.Food.QuantityType == QuantityType.Gram || item.Food.QuantityType == QuantityType.Mililiter)
                        {

                            totalCalorie += ((item.Food.CalorieValue) * (item.Quantity)) / 100;

                            totalCarbonhydrate += (item.Food.CarbonhydrateValue * (item.Quantity)) / 100;

                            totalProtein += (item.Food.ProteinValue * (item.Quantity)) / 100;

                            totalFat += (item.Food.FatValue * (item.Quantity)) / 100;

                            totalFolicAcid += (item.Food.FolicAcidValue * (item.Quantity)) / 100;

                            totalCalcium += (item.Food.CalciumValue * (item.Quantity)) / 100;


                        }
                        else
                        {
                            totalCalorie += ((item.Food.CalorieValue) * (item.Quantity));

                            totalCarbonhydrate += (item.Food.CarbonhydrateValue * (item.Quantity));

                            totalProtein += (item.Food.ProteinValue * (item.Quantity));

                            totalFat += (item.Food.FatValue * (item.Quantity));

                            totalFolicAcid += (item.Food.FolicAcidValue * (item.Quantity)) / 100;

                            totalCalcium += (item.Food.CalciumValue * (item.Quantity)) / 100;
                        }
                    }
                    


                }

                lblKalanKaloriYazi.Text = (Convert.ToDouble(lblGunlukHedefKaloriYazi.Text) - Convert.ToDouble(totalCalorie)).ToString("0.##");
               
                lblToplamKarbonhidratYazi.Text = totalCarbonhydrate.ToString("0.##");
                lblAlinanKaloriYazi.Text = totalCalorie.ToString("0.##");

                lblKalanKaloriYazi.ForeColor = totalCalorie > targetCalorie ? Color.Red : Color.Green;

                lblToplamProteinYazi.Text = totalProtein.ToString("0.##");
                lblToplamYagYazi.Text = totalFat.ToString("0.##");
                lblToplamFolikYazi.Text = totalFolicAcid.ToString("0.##");

                if (totalProtein > 0)
                {
                    Application.DoEvents();

                    if (totalProtein > 95)
                    {
                        prgBarProtein.Value = 95;
                    }
                    else
                    {
                        prgBarProtein.Value = (int)totalProtein;
                    }
                }

                if (totalCalcium > 0)
                {
                    Application.DoEvents();

                    if (totalCalcium > 95)
                    {
                        prgBarKalsiyum.Value = 95;
                    }
                    else
                    {
                        prgBarKalsiyum.Value = (int)totalCalcium;
                    }
                }
                if (totalFolicAcid > 0)
                {
                    Application.DoEvents();

                    if (totalFolicAcid > 600)
                    {
                        prgBarFolikasit.Value = 600;
                    }
                    else
                    {
                        prgBarFolikasit.Value = (int)totalFolicAcid;
                    }
                }

            }

        }

        //vucut kitle indeksi bulma methodu
        public double FindVKI(User user)
        {
            double weight = Convert.ToDouble(user.Weight);
            double height = Convert.ToDouble(user.Height)/100;
            return weight /(height * height);
        }
        // girilen hamile kalma tarihine göre trimester bulma methodu
        public TrimesterType FindTrimesterType(User user)
        {
            return DateTime.Now < user.DateOfConception.AddDays(90) ? TrimesterType.FirstTrimester : (DateTime.Now < user.DateOfConception.AddDays(180) ? TrimesterType.SecondTrimester:TrimesterType.ThirdTrimester);
        }

        // Kadınlar için bazal metabolizma hızı = 655.1 + (9.56 x vücut ağırlığınız (kg)) + (1.85 x boyunuz (cm.)) - (4.67 x yaş)

        public double FindTargetCalorie(User user)
        {
            double weight = Convert.ToDouble(user.Weight);
            double height = Convert.ToDouble(user.Height);

            if (user.TrimesterType == TrimesterType.FirstTrimester)
            {
                return 665.1 + (9.56 * weight) + (1.85 * height) - (4.67 * (DateTime.Now.Year - user.BirthDate.Year));
            }
            else if (user.TrimesterType == TrimesterType.SecondTrimester)
            {
                return 665.1 + (9.56 * weight) + (1.85 * height) - (4.67 * (DateTime.Now.Year - user.BirthDate.Year))+350;
            }
            else
            {
                return 665.1 + (9.56 * weight) + (1.85 * height) - (4.67 * (DateTime.Now.Year - user.BirthDate.Year)) + 450;
            }

            
        }

        private void btnTarifGorntule_Click(object sender, EventArgs e)
        {
            ViewRecipe viewRecipe = new ViewRecipe(user);
            this.Hide();
            viewRecipe.ShowDialog();
            this.Show();
        }

        private void btnOgunEkle_Click(object sender, EventArgs e)
        {
            AddMeal addMeal = new AddMeal(user);
            this.Hide();
            addMeal.ShowDialog();
            this.Show();
        }

        private void btnOgunlerıGoruntle_Click(object sender, EventArgs e)
        {
            var date = dtp.Value;
            ViewMealDetail viewMealDetail = new ViewMealDetail(user,date);
            this.Hide();
            viewMealDetail.ShowDialog();
            this.Show();
        }

        private void btnGünSonuRaporu_Click(object sender, EventArgs e)
        {
            EndOfDayReport endOfDayReport = new EndOfDayReport(user);
            this.Hide();
            endOfDayReport.ShowDialog();
            this.Show();
        }

        private void btnYemekCesidiRaporu_Click(object sender, EventArgs e)
        {
            FoodVarietyReport foodVarietyReport = new FoodVarietyReport(user);
            this.Hide();
            foodVarietyReport.ShowDialog();
            this.Show();
        }

        private void btnUygulamadanCik_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiiz?","Uyarı",MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Yine bekleriz :) ");
                this.Close();
            }


        }
    }
}
