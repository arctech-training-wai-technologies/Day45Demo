namespace Day45Demo;

static class ThreadDemo1
{
    public static void Test()
    {
        var t1 = new Thread(DoSomething);
        t1.IsBackground = true;
        var t2 = new Thread(DoSomethingElse);
        t2.IsBackground = true;

        t1.Start(10);
        t2.Start();

        for (var i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(15);
        }
    }

    static void DoSomething(object parameter)
    {
        int paramValue = (int)parameter;
        for (var i = paramValue; i < paramValue + 10; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(20);
        }
    }

    static void DoSomethingElse()
    {
        for (var i = 20; i < 30; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(30);
        }
    }
}