namespace Template_Method;

internal class ConcreteClass2 : AbstractClass
{
    protected override void RequiredOperations1()
    {
        Console.WriteLine("ConcreteClass2 syas: Implemented Operation1");
    }

    protected override void RequiredOperations2()
    {
        Console.WriteLine("ConcreteClass2 syas: Implemented Operation2");
    }

    protected override void Hook1()
    {
        Console.WriteLine("ConcreteClass2 syas: Overridden Hook1");
    }
}
