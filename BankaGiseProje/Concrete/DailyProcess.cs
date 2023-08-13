using BankaGiseProje.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaGiseProje.Concrete
{
    public class DailyProcess
    {
        public static int VipNumber = 0;
        public static int DeskNumber = 0;
        public static int StandartNumber = 0;

        public static void SetNumber(CustomerType customerType)
        {
            switch (customerType)
            {
                case CustomerType.VipCustomer:
                    VipNumber++;
                    break;
                case CustomerType.DeskCustomer:
                    DeskNumber++;
                    break;
                case CustomerType.StandartCustomer:
                    StandartNumber++;
                    break;
                default: 
                    throw new Exception("Hatalı Müşteri Tipi");
            }
        }
    }
}
