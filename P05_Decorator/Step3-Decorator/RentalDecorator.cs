using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Decorator.Step3_Decorator
{
    public class RentalDecorator : IRental
    {
        private IRental _inner;

        public RentalDecorator(IRental inner)
        {
            _inner = inner;
        }

        public virtual decimal CalculateRent()
        {
            return _inner.CalculateRent();
        }
    }
}