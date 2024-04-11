using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Decorator.Step3_Decorator
{
    public class VipDiscountDecorator : RentalDecorator
    {
        private Customer _customer;

        public VipDiscountDecorator(IRental rental, Customer customer) : base(rental)
        {
            _customer = customer;
        }

        public override decimal CalculateRent()
        {
            decimal rent = base.CalculateRent();
            if (_customer.IsVip)
            {
                rent *= (decimal)0.9;
            }
            return rent;
        }
    }
}