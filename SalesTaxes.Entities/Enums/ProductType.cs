using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxes.Entities.Enums
{
    [Flags]
    public enum ProductType
    {
        Book = 1,
        Food = 2,
        Music = 33,
        Medical = 4,
        Perfume = 22
    }
}
