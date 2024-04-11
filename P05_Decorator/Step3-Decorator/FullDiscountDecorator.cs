using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Decorator.Step3_Decorator
{
    public class FullDiscountDecorator : RentalDecorator
    {
        public FullDiscountDecorator(IRental inner) : base(inner)
        {
        }

        public override decimal CalculateRent()
        {
            decimal rent = base.CalculateRent();
            int discountTime = (int)Math.Floor(rent / 500);
            return rent - discountTime * 30;
        }
    }
}