using DietApp.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Model.Entities
{
    public class MealDetail : BaseEntity
    {
        public DateTime? UpdateDate { get; set; }

        public int Quantity { get; set; }

        public QuantityType QuantityType { get; set; }

        public int UserID { get; set; }
        public virtual User User { get; set; }

        public int MealID { get; set; }
        public virtual Meal Meal { get; set; }

        public int FoodID { get; set; }
        public virtual Food Food { get; set; }
    }
}
