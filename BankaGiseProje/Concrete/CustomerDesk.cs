using BankaGiseProje.Abstract;
using BankaGiseProje.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaGiseProje.Concrete
{
    public class CustomerDesk : BaseCustomer
    {
        public CustomerDesk(string customerId, string customerName) : base(customerId, customerName)
        {
        }

        public override void GetNumber()
        {
            Numerator numerator = new Numerator();
            Number = numerator.CreateNumber(CustomerType.DeskCustomer, this);
        }
    }
}
