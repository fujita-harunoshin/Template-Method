namespace Template_Method;

internal abstract class AbstractClass
{
    public void TemplateMethod()
    {
        BaseOperation1();
        RequiredOperations1();
        BaseOperation2();
        Hook1();
        RequiredOperations2();
        BaseOperation3();
        Hook2();
    }

    protected void BaseOperation1()
    {
        Console.WriteLine("AbstractClass syas: I am doing the bulk of the work");
    }

    protected void BaseOperation2()
    {
        Console.WriteLine("AbstractClass syas: But I let subclass override some operations");
    }

    protected void BaseOperation3()
    {
        Console.WriteLine("AbstractClass syas: But I am doing the bulk of the work anyway");
    }

    protected abstract void RequiredOperations1();

    protected abstract void RequiredOperations2();

    protected virtual void Hook1() { }

    protected virtual void Hook2() { }
}
