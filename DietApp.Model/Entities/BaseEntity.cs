using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Model.Entities
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreationDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
