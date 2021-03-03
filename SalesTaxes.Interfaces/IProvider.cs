using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxes.Interfaces
{
    public interface IProvider
    {
        decimal GetBaseTax();
        decimal GetImportTax();
    }
}
