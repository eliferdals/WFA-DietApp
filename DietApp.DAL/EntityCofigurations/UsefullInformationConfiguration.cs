using DietApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.EntityCofigurations
{
    internal class UsefullInformationConfiguration : EntityTypeConfiguration<UsefullInformation>
    {
        public UsefullInformationConfiguration()
        {
            Property(a => a.Name).IsRequired().HasMaxLength(100);
            Property(a => a.Description).IsRequired().HasMaxLength(1000);
        }
    }
}
