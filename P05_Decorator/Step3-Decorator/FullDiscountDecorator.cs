using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Decorator.Step3_Decorator
{
    public class FullDiscountDecorator : IRental
    {
        private IRental _inner;

        public FullDiscountDecorator(IRental inner)
        {
            _inner = inner;
        }

        public decimal CalculateRent()
        {
            decimal rent = _inner.CalculateRent();
            int discountTime = (int)Math.Floor(rent / 500);
            return rent - discountTime * 30;
        }
    }
}