using DietApp.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Model.Entities
{
    public class UserAction : BaseEntity
    {
        public string OldValue { get; set; }

        public string NewValue { get; set; }

        public ActionType ActionType { get; set; }

        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
