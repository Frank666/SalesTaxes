using SalesTaxes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxes.General
{
    public class TaxProvider : IProvider
    {
        public decimal GetBaseTax()
        {
            return 0.1m;
        }

        public decimal GetImportTax()
        {
            return 0.05m;
        }
    }
}
