using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitySample
{
   
    public interface IStockCategory
    {
        int id { get; set; }
        string categoryName { get; set; }
        DateTime insertionTime { get; set; }
    }


    // stok kategori sınıfı
    public class StockCategory : IStockCategory
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        public DateTime insertionTime { get; set; }
    }
}
