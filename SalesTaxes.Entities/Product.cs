using SalesTaxes.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxes.Entities
{
    public class Product
    {
        public ProductType Type { get; private set; }
        public string Name { get; private set; }
        public Product(ProductType productType, string name)
        {
            Type = productType;
            Name = name;
        }
    }
}
