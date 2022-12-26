using DietApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.EntityCofigurations
{
    internal class UserActionConfiguration : EntityTypeConfiguration<UserAction>
    {
        public UserActionConfiguration()
        {
            Property(a => a.OldValue).IsRequired();
            Property(a => a.NewValue).IsRequired();
            Property(a => a.ActionType).IsRequired();
            Property(a => a.CreationDate).IsRequired();
        }
    }
}
