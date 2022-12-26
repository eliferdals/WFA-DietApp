using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Model.Enum
{
    public enum ActionType
    {
        // Database' e yansılatacağı için 1' den başlatılmıştır ve daha sonrasıda karışıklık olmaması için numaralandırmaya devam
        // edilmiştir.

        PasswordUpdate = 1,
        WeightUpdate = 2
    }
}
