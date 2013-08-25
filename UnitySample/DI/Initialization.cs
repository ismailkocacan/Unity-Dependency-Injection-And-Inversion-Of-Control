using Microsoft.Practices.Unity;
using UnitySample;


public class Initialization
{
    public static void registerObjects()
    {
        UnityContainer container = ContainerManager.getContainer();
        container.RegisterType<IStockCategory, StockCategory>();

        // StockCard sınıfının,stockCategory property değeri dinamik olarak set ediliyor.
        var injectMember = new InjectionProperty("stockCategory", container.Resolve<IStockCategory>());
        container.RegisterType<IStockCard, StockCard>(injectMember);
    }
}



