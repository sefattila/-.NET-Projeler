using BankaGiseProje.Abstract;
using BankaGiseProje.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaGiseProje.Concrete
{
    public class Control
    {
        static int _say = 0;
        static int _processNumber = 0;
        public static int SendNumberToDesk()
        {
            if (CustomerWaiting.waitingCustomerVip.Count > 0)
            {
                Console.WriteLine("Sıradaki numara: " + CustomerWaiting.waitingCustomerVip[0].Number);
                _processNumber = CustomerWaiting.waitingCustomerVip[0].Number;
                CustomerWaiting.waitingCustomerVip.RemoveAt(0);
                DailyProcess.SetNumber(CustomerType.VipCustomer);
                return _processNumber;
            }
            else if ((CustomerWaiting.waitingCustomerDesk.Count > 0 && _say < 3) ||
                 (CustomerWaiting.waitingCustomerDesk.Count > 0 && CustomerWaiting.waitingCustomerStandart.Count == 0))
            {
                Console.WriteLine("Sıradaki numara: " + CustomerWaiting.waitingCustomerDesk[0].Number);
                _processNumber = CustomerWaiting.waitingCustomerDesk[0].Number;
                CustomerWaiting.waitingCustomerDesk.RemoveAt(0);
                DailyProcess.SetNumber(CustomerType.DeskCustomer);
                _say++;
                return _processNumber;
            }
            else if (CustomerWaiting.waitingCustomerStandart.Count > 0)
            {
                Console.WriteLine("Sıradaki numara: " + CustomerWaiting.waitingCustomerStandart[0].Number);
                _processNumber = CustomerWaiting.waitingCustomerStandart[0].Number;
                CustomerWaiting.waitingCustomerStandart.RemoveAt(0);
                DailyProcess.SetNumber(CustomerType.StandartCustomer);
                _say = 0;
                return _processNumber;
            }
            else throw new Exception("Bekleyen Müşteri Kalmadı");
        }
    }
}
