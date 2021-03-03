using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace SalesTaxes.UnitTests
{
    public class Imported: BaseSetup
    {
        [SetUp]
        public void InitProduct()
        {
            product = new Entities.Product(Entities.Enums.ProductType.Perfume, "Goku Spirit Ball Limited Edition");
            item = new Entities.Item(taxesCalculator, product, true, 15.0m);
        }

        [Test]
        public void Validate_Tax_Import()
        {
            var amount = 1.5m;
            var result = taxesCalculator.GetTax(item);

            Assert.AreEqual(amount, result);
        }

        [Test]
        public void Validate_Total_Import()
        {
            var amount = 16.5m;
            var result = taxesCalculator.GetFinalPrice(item);

            Assert.AreEqual(amount, result);
        }
    }
}
