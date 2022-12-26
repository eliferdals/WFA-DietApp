using DietApp.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BLL.Services
{
    public class UsefullInformationService
    {
        UsefullInformationRepository usefullInformationRepository;

        public UsefullInformationService()
        {
            usefullInformationRepository = new UsefullInformationRepository();
        }

        public string GetInformationById(int usefulInformationId)
        {
            return usefullInformationRepository.GetInformationById(usefulInformationId);
        }

        public int GetUsefulInformationCount()
        {
            return usefullInformationRepository.GetUsefulInformationCount();
        }
    }
}
