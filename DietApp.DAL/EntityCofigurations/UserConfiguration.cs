using DietApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.EntityCofigurations
{
    internal class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(a => a.FirstName).IsRequired().HasMaxLength(100);
            Property(a => a.LastName).IsRequired().HasMaxLength(100);
            Property(a => a.Password).IsRequired().HasMaxLength(75);
            Property(a => a.Email).IsRequired().HasMaxLength(100);
            HasIndex(a => a.Email).IsUnique();
            Property(a => a.Weight).IsRequired();
            Property(a => a.Height).IsRequired();
            Property(a => a.DateOfConception).IsRequired();
            Property(a => a.SecurityAnswer).IsRequired().HasMaxLength(50);
            Property(a => a.SmokeType).IsRequired();
            Property(a => a.CreationDate).IsRequired();

        }
    }
}
