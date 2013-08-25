using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace UnitySample
{

    public interface IStockCard
    {
        int id { get; set; }
        string stockCode { get; set; }
        string stockName { get; set; }
        double unitPrice { get; set; }
        double amount { get; set; }
        double total { get; set; }
        DateTime insertionTime { get; set; }

        [Dependency("stokCategory")]
        IStockCategory stockCategory { get; set; }
    }


    // Stok Kartı sınıfımız
    public class StockCard : IStockCard
    {
        public int id { get; set; }
        public string stockCode { get; set; }
        public string stockName { get; set; }
        public double unitPrice { get; set; }
        public double amount { get; set; }
        public double total { get; set; }
        public DateTime insertionTime { get; set; }


        [Dependency("stockCategory")]
        public IStockCategory stockCategory { get; set; }


        public StockCard()
        {

        }
    }
}
