using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Model.Entities
{
    public class Meal : BaseEntity
    {
        public Meal()
        {
            MealDetails = new HashSet<MealDetail>();
        }
        public string Name { get; set; }

        public virtual ICollection<MealDetail> MealDetails { get; set; }
    }
}
