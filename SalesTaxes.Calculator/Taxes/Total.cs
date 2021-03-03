using System;
using System.Collections.Generic;
using System.Linq; 
using SalesTaxes.Entities;
using SalesTaxes.Entities.AbstractClasses;


namespace SalesTaxes.Business.Taxes
{   
    public class Total: TaxesCalculator
    {
        private readonly IEnumerable<TaxesCalculator> _taxesCalculators;
        public Total(IEnumerable<TaxesCalculator> taxesCalculators)
        {
            _taxesCalculators = taxesCalculators;
        }

        public override decimal GetTax(Item item)
        {
            return _taxesCalculators.Sum(x => x.GetTax(item));
        }
    }
}
