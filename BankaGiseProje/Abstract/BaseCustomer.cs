using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaGiseProje.Abstract
{
    public abstract class BaseCustomer
    {
        protected BaseCustomer(string customerId, string customerName)
        {
            this.CustomerId = customerId;
            this.CustomerName = customerName;
        }

        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int Number { get; set; }

        public abstract void GetNumber();
    }
}
