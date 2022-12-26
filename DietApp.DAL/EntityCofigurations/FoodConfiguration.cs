using DietApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.EntityCofigurations
{
    internal class FoodConfiguration : EntityTypeConfiguration<Food>
    {
        public FoodConfiguration()
        {
            Property(a => a.Name).IsRequired().HasMaxLength(100);
            Property(a => a.CalorieValue).IsRequired();
            Property(a => a.QuantityType).IsRequired();
            Property(a => a.CreationDate).IsRequired();
        }
    }
}
