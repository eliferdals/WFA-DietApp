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
    public partial class NutritionistProfile : Form
    {
        NutritionistService nutritionistService;
        public NutritionistProfile()
        {
            InitializeComponent();
            nutritionistService = new NutritionistService();
        }

        private void NutritionistProfile_Load(object sender, EventArgs e)
        {
            FillUsersList();
        }

        public void FillUsersList()
        {
            var data = nutritionistService.GetAllUser();
            lstViewKullanicila.Items.Clear();
            foreach (var item in data)
            {
                ListViewItem lvi = new ListViewItem(item.ID.ToString());
                lvi.SubItems.Add(item.FirstName);
                lvi.SubItems.Add(item.LastName);
                lstViewKullanicila.Items.Add(lvi);
            }
        }

        private void btnTumKullanıcılarıListele_Click(object sender, EventArgs e)
        {
            FillUsersList();
        }

        private void lstViewKullanicila_DoubleClick(object sender, EventArgs e)
        {
            int userID =0;
            string selectedItem = lstViewKullanicila.SelectedItems[0].SubItems[0].Text;
            if (!string.IsNullOrEmpty(selectedItem))
            {
                userID = int.Parse(selectedItem);
            }
            if (userID>0)
            {
                User user = nutritionistService.ViewUserDetails(userID);
                ListViewItem lvi = new ListViewItem(user.ID.ToString());
                lvi.SubItems.Add(user.FirstName);
                lvi.SubItems.Add(user.LastName);
                lvi.SubItems.Add(user.Email);
                lvi.SubItems.Add(user.DietType.ToString());
                lvi.SubItems.Add(user.SmokeType.ToString());
                lvi.SubItems.Add(FindTrimesterType(user).ToString());
                lstViewKullaniciDetayBilgileri.Items.Add(lvi);
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lstViewKullaniciDetayBilgileri.Items.Clear();
        }


        private void btnBesinEkle_Click(object sender, EventArgs e)
        {
            AddFood addFood = new AddFood();
            this.Hide();
            addFood.ShowDialog();
            this.Show();
        }

        private void btnUygulamadanCik_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiiz?", "Uyarı", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Yine bekleriz :) ");
                this.Close();
            }

        }

        public TrimesterType FindTrimesterType(User user)
        {
            return DateTime.Now < user.DateOfConception.AddDays(90) ? TrimesterType.FirstTrimester : (DateTime.Now < user.DateOfConception.AddDays(180) ? TrimesterType.SecondTrimester : TrimesterType.ThirdTrimester);
        }
    }
}
