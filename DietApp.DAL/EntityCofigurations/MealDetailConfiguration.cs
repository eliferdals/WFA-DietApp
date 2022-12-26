using DietApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.EntityCofigurations
{
    internal class MealDetailConfiguration : EntityTypeConfiguration<MealDetail>
    {
        public MealDetailConfiguration()
        {
            Property(a => a.CreationDate).IsRequired();
            Property(a => a.Quantity).IsRequired();

        }
    }
}
