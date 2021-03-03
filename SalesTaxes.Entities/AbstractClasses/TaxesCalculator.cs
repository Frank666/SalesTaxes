using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxes.Entities.AbstractClasses
{
    abstract public class TaxesCalculator
    {
        public abstract decimal GetTax(Item item);
        public decimal GetFinalPrice(Item item)
        {
            return item.Price + RoundUp(GetTax(item));
        }

        private decimal RoundUp(decimal price)
        {
            return Math.Ceiling(price * 20) / 20;
        }
    }
}
