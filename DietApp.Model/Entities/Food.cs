using DietApp.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Model.Entities
{
    public class Food : BaseEntity
    {
        public Food()
        {
            MealDetails = new HashSet<MealDetail>();

        }
        public string Name { get; set; }

        public int CalorieValue { get; set; }

        public double ProteinValue { get; set; }

        public double CalciumValue { get; set; }

        public double FatValue { get; set; }

        public double CarbonhydrateValue { get; set; }

        public double FolicAcidValue { get; set; }

        public string Description { get; set; }

        public QuantityType QuantityType { get; set; }

        public string FoodPicture { get; set; }

        public virtual ICollection<MealDetail> MealDetails { get; set; }

        public DietType DietType { get; set; }

        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
