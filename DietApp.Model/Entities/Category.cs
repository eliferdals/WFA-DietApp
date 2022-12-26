using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Model.Entities
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Foods = new HashSet<Food>();
        }
        public string Name { get; set; }

        public string Description { get; set; }

        public string CategoryPicture { get; set; }

        public virtual ICollection<Food> Foods { get; set; }
    }
}
