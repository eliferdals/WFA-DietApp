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
    public partial class ViewMealDetail : Form
    {
        MealDetailService mealDetailService;
        public ViewMealDetail()
        {
            InitializeComponent();
        }
        User user;
        DateTime date;

        public ViewMealDetail(User user, DateTime date)
        {
            InitializeComponent();
            this.user = user;
            this.date = Convert.ToDateTime(date.ToString("d"));
            mealDetailService = new MealDetailService();
        }

        
        private void ViewMealDetail_Load(object sender, EventArgs e)
        {
            
            var mealDetails = mealDetailService.GetByUserID(user.ID, date).Select(a => new { a.MealID, a.Meal.Name, a.CreationDate }).Distinct().ToList();

            foreach (var item in mealDetails)
            {
                ListViewItem lvi = new ListViewItem(item.MealID.ToString());
                lvi.SubItems.Add(item.Name);
                lvi.SubItems.Add(item.CreationDate.ToString());

                lstViewOgunAdi.Items.Add(lvi);
                
            }


        }

        private void btnOgunSil_Click(object sender, EventArgs e)
        {
            if (lstViewOgunAdi.SelectedItems.Count != 0)
            {                
                string mealId = lstViewOgunAdi.SelectedItems[0].SubItems[0].Text;
                string creationDate = lstViewOgunAdi.SelectedItems[0].SubItems[2].Text;

                bool check = mealDetailService.DeleteMealDetail(user.ID,int.Parse(mealId),Convert.ToDateTime(creationDate));
                

                if (check)
                {
                    lstViewOgunAdi.Items.Remove(lstViewOgunAdi.SelectedItems[0]);
                    MessageBox.Show("Öğün silme işlemi başarılı");

                    for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                    {
                        if (Application.OpenForms[i].Name == "UserProfile") Application.OpenForms[i].Close();
                    }


                    UserProfile userProfile = new UserProfile(user);
                    userProfile.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Öğün silme işlemi sırasında hata oluştu.");
                }
                
            }
            else
            {
                MessageBox.Show("Lütfen silinecek besin seçiniz.");
            }
            
        }

        private void btnOgunIcerigiGoruntule_Click(object sender, EventArgs e)
        {
            if (lstViewOgunAdi.SelectedItems.Count != 0)
            {
                string mealId = lstViewOgunAdi.SelectedItems[0].SubItems[0].Text;
                string creationDate = lstViewOgunAdi.SelectedItems[0].SubItems[2].Text;

                List<MealDetail> mealDetails = mealDetailService.GetMealDetails(user.ID, int.Parse(mealId), Convert.ToDateTime(creationDate));
                lsvtViewOgunIcerigi.Items.Clear();

                if (mealDetails!=null)
                {
                    foreach (var item in mealDetails)
                    {
                        ListViewItem lvi = new ListViewItem(item.ID.ToString());
                        lvi.SubItems.Add(item.Food.Name);
                        lvi.SubItems.Add(item.Quantity.ToString());
                        lvi.SubItems.Add(item.Food.CalorieValue.ToString());

                        lsvtViewOgunIcerigi.Items.Add(lvi);
                    }
                }

            }
            else
            {
                MessageBox.Show("Lütfen silinecek besin seçiniz.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lsvtViewOgunIcerigi.SelectedItems.Count != 0)
            {
                string mealDetailId = lsvtViewOgunIcerigi.SelectedItems[0].SubItems[0].Text;

                bool check = mealDetailService.DeleteMealDetailByMealDetailId(int.Parse(mealDetailId));


                if (check)
                {
                    lsvtViewOgunIcerigi.Items.Remove(lsvtViewOgunIcerigi.SelectedItems[0]);
                    MessageBox.Show("Öğün içeriği silme işlemi başarılı");
                }
                else
                {
                    MessageBox.Show("Öğün içeriği silme işlemi sırasında hata oluştu.");
                }

            }
            else
            {
                MessageBox.Show("Lütfen silinecek besin seçiniz.");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lsvtViewOgunIcerigi.SelectedItems.Count != 0)
            {
                string mealDetailId = lsvtViewOgunIcerigi.SelectedItems[0].SubItems[0].Text;

                UpdateMealDetail updateMealDetail = new UpdateMealDetail(user, int.Parse(mealDetailId));
                this.Hide();
                updateMealDetail.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Lütfen değişiklik yapmak istediğiniz yemeği seçiniz.");
            }



        }

        private void ViewMealDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();

            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name == "UserProfile") Application.OpenForms[i].Close();
            }


            UserProfile userProfile = new UserProfile(user);
            userProfile.ShowDialog();
        }
    }
}
