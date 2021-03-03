using System;
using System.Collections.Generic;
using System.Text;
using SalesTaxes.Entities.AbstractClasses;

namespace SalesTaxes.Entities
{
    public class Item
    {
        public decimal Price { get; private set; }
        public Product Product { get; private set; }
        public bool Imported { get; private set; }
        private readonly TaxesCalculator _taxesCalculator;

        public Item(TaxesCalculator taxesCalculator, Product product, bool imported, decimal price)
        {
            _taxesCalculator = taxesCalculator;
            Product = product;
            Imported = imported;
            Price = price;
        }

        public decimal GetItemPrice()
        {
            return _taxesCalculator.GetFinalPrice(this);
        }
    }
}
