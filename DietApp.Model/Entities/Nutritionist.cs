using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Model.Entities
{
    public class Nutritionist : BaseEntity
    {
        public Nutritionist()
        {
            Users = new HashSet<User>();
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
