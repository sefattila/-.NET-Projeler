﻿using BankaGiseProje.Abstract;
using BankaGiseProje.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaGiseProje.Concrete
{
    public class CustomerStandart : BaseCustomer
    {
        public CustomerStandart(string customerId, string customerName) : base(customerId, customerName)
        {
        }

        public override void GetNumber()
        {
            Numerator numerator= new Numerator();
            Number = numerator.CreateNumber(CustomerType.StandartCustomer, this);
        }
    }
}
