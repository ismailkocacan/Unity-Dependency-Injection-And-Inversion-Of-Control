using Microsoft.Practices.Unity;

public class ContainerManager
{
    private static UnityContainer container = new UnityContainer();

    public static UnityContainer getContainer()
    {
        return container;
    }
}

