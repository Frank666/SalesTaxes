using System;
using System.Collections.Generic;
using System.Text;
using SalesTaxes.Entities;
using SalesTaxes.Entities.AbstractClasses;
using SalesTaxes.Entities.Enums;
using SalesTaxes.Interfaces;

namespace SalesTaxes.Business.Taxes
{
   public class Calculator : TaxesCalculator
    {
        public const ProductType NoTaxesProducts = (ProductType.Book | ProductType.Food | ProductType.Medical);
        private readonly IProvider _provider;
        public Calculator(IProvider provider)
        {
            _provider = provider;
        }

        public override decimal GetTax(Item item)
        {
            if (NoTaxesProducts.HasFlag(item.Product.Type))
            {
                return 0.0m;
            }
            return item.Price * _provider.GetBaseTax();
        }
    }
}
