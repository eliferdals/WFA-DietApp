using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.Repositories
{
    public class UsefullInformationRepository
    {
        DietAppDbContext db;

        public UsefullInformationRepository()
        {
            db = new DietAppDbContext();
        }

        public int GetUsefulInformationCount()
        {
            var data = db.UsefullInformations.Select(a => a.Name).Count();
            return data;
        }

        public string GetInformationById(int usefulInformationId)
        {
            var data = db.UsefullInformations.Where(a => a.ID == usefulInformationId).Select(a => a.Description).SingleOrDefault();
            return data;
        }
    }
}
