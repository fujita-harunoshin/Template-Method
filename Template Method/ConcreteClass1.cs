namespace Template_Method;

internal class ConcreteClass1 : AbstractClass
{
    protected override void RequiredOperations1()
    {
        Console.WriteLine("ConcreteClass1 says: Implemented Operations1");
    }

    protected override void RequiredOperations2()
    {
        Console.WriteLine("ConcreteClass1 says: Implemented Operations2");
    }
}
