using NUnit.Framework;
using Moq;
using SalesTaxes.Entities.AbstractClasses;
using SalesTaxes.Entities;
using SalesTaxes.Business.Taxes;

namespace SalesTaxes.UnitTests
{    
    public class BaseSetup
    {
        protected Mock<Interfaces.IProvider> _providerMock;
        protected TaxesCalculator taxesCalculator;
        protected Item item;
        protected Product product;

        [SetUp]
        public void Setup()
        {
            _providerMock = new Mock<Interfaces.IProvider>();
            _providerMock.Setup(x => x.GetBaseTax()).Returns(0.1m);
            _providerMock.Setup(x => x.GetImportTax()).Returns(0.05m);

            taxesCalculator = new Calculator(_providerMock.Object);
        }
    }
}