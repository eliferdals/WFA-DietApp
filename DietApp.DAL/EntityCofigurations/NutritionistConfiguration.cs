using DietApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.EntityCofigurations
{
    internal class NutritionistConfiguration : EntityTypeConfiguration<Nutritionist>
    {
        public NutritionistConfiguration()
        {
            Property(a=>a.FirstName).IsRequired().HasMaxLength(100);
            Property(a=>a.LastName).IsRequired().HasMaxLength(100);
            Property(a => a.Email).IsRequired().HasMaxLength(100);
            HasIndex(a => a.Email).IsUnique();
            Property(a => a.Password).IsRequired();

        }
    }
}
