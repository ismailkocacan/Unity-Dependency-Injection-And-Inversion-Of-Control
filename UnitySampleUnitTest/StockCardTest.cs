using System;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitySample;

namespace UnitySampleUnitTest
{
    [TestClass]
    public class StockCardTest
    {

        UnityContainer um;

        [TestInitialize]
        public void testInitialize()
        {
           Initialization.registerObjects();
           um = ContainerManager.getContainer();
        }
         



        [TestMethod]
        public void stokKartiNesnesiOlustur()
        {
            if (!um.IsRegistered<IStockCard>())
                throw new Exception("stok kartı register edilmemiş.");

            // bir tane stok kartı nesnesi oluştuyoruz.
            var stockCard = um.Resolve<IStockCard>();
            // veya aşağıdaki şekilde de containerdan objecte erişmek mümkün.
            //var stockCard = this.getDIContainer().Resolve<IStockCard>();
            stockCard.stockCode = "ST0001";
            stockCard.stockName = "Buzdolabı";
            stockCard.insertionTime = DateTime.Now;
            stockCard.unitPrice = 2500;
            stockCard.amount = 60;

            stockCard.stockCategory.categoryName = "Beyaz Eşya";
            stockCard.stockCategory.id = 1;
            stockCard.stockCategory.insertionTime = DateTime.Now;
        }
    }
}
