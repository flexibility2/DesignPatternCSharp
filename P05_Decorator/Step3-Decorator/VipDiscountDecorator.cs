using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Decorator.Step3_Decorator
{
    public class VipDiscountDecorator : IRental
    {
        private IRental _rental;
        private Customer _customer;

        public VipDiscountDecorator(IRental rental, Customer customer)
        {
            _rental = rental;
            _customer = customer;
        }

        public decimal CalculateRent()
        {
            decimal rent = _rental.CalculateRent();
            if (_customer.IsVip)
            {
                rent *= (decimal)0.9;
            }
            return rent;
        }
    }
}