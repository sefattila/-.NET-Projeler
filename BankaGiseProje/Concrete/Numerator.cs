using BankaGiseProje.Abstract;
using BankaGiseProje.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaGiseProje.Concrete
{
    public class Numerator
    {
        private static int _vipNumber = 100;
        private static int _standartNumber = 300;
        private static int _deskNumber = 600;

        public int VipNumber
        {
            get { return _vipNumber; }
            set
            {
                if (value < 199)
                {
                    _vipNumber = value;
                }
                else
                {
                    _vipNumber = 100;
                }
            }
        }
        public int StandartNumber
        {
            get { return _standartNumber; }
            set
            {
                if (value < 399)
                {
                    _standartNumber = value;
                }
                else
                {
                    _standartNumber = 300;
                }
            }
        }
        public int DeskNumber
        {
            get { return _deskNumber; }
            set
            {
                if (value < 699)
                {
                    _deskNumber = value;
                }
                else
                {
                    _deskNumber = 600;
                }
            }
        }

        /// <summary>
        /// Gelen müşterinin tipine göre oluşturulan 3 farklı müşteri tipli listeme atıyorum
        /// </summary>
        /// <param name="customerType"></param>
        /// <param name="baseCustomer"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int CreateNumber(CustomerType customerType,BaseCustomer baseCustomer)
        {
            switch (customerType)
            {
                case CustomerType.VipCustomer:
                    CustomerWaiting.waitingCustomerVip.Add((CustomerVip)baseCustomer);
                    return ++VipNumber;
                case CustomerType.StandartCustomer:
                    CustomerWaiting.waitingCustomerStandart.Add((CustomerStandart)baseCustomer);
                    return ++StandartNumber;
                case CustomerType.DeskCustomer:
                    CustomerWaiting.waitingCustomerDesk.Add((CustomerDesk)baseCustomer);
                    return ++DeskNumber;
                default:
                    throw new Exception("Yanlış Müşteri Tipi");
            }
        }
    }
}
