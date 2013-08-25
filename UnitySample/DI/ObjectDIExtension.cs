using System.Windows.Forms;
using Microsoft.Practices.Unity;

public static class ObjectDIExtension
{
    // object sınıfına yazdığımız extension(uzanım) methodu.
    // en alt sınıfa uzanım methodu olarak yazdığımız için her nesne üzerinden erişilebileceğiz.
    
    // sınıf içersindeki iken kullanım : this.getDIContainer().... methodlarını kullanabileceğiz.
    // var obj; obj.getDIContainer()...
    public static UnityContainer getDIContainer(this object obj)
    {
        return ContainerManager.getContainer();
    }
}