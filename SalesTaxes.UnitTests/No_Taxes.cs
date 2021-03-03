using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace SalesTaxes.UnitTests
{
    public class No_Taxes: BaseSetup
    {
        [SetUp]
        public void InitProduct()
        {
            product = new Entities.Product(Entities.Enums.ProductType.Book, "Dragon Ball Wiki");
            item = new Entities.Item(taxesCalculator, product, false, 40.0m);
        }

        [Test]
        public void No_Tax_Amount()
        {
            var amount = 0.0m;
            var result = taxesCalculator.GetTax(item);

            Assert.AreEqual(amount, result);
        }

        [Test]
        public void Validate_Correct_Proce()
        {
            var amount = 40.0m;
            var result = taxesCalculator.GetFinalPrice(item);

            Assert.AreEqual(amount, result);
        }

    }
}
