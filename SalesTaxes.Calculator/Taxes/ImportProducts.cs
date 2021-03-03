using System;
using System.Collections.Generic;
using System.Text;
using SalesTaxes.Entities;
using SalesTaxes.Entities.AbstractClasses;
using SalesTaxes.Interfaces;

namespace SalesTaxes.Business.Taxes
{
    public class ImportProducts: TaxesCalculator
    {
        private readonly IProvider _provider;
        public ImportProducts(IProvider provider)
        {
            _provider = provider;
        }

        public override decimal GetTax(Item item)
        {
            decimal result = 0;
            if (item.Imported)
            {
                result = item.Price * _provider.GetImportTax();
            }
            return result;
        }
    }
}
