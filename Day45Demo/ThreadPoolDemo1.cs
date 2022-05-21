namespace Day45Demo;

static class ThreadPoolDemo1
{
    public static void Test()
    {
        //var t1 = new Thread(DoSomething);
        //t1.IsBackground = true;
        //var t2 = new Thread(DoSomethingElse);
        //t2.IsBackground = true;

        //t1.Start();
        //t2.Start();

        ShowAvailableThreads();
        ShowMinThreads();
        ShowMaxThreads();

        ThreadPool.QueueUserWorkItem(DoSomething);
        ThreadPool.QueueUserWorkItem(DoSomethingElse);

        for (var i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(15);
        }
    }

    private static void ShowMaxThreads()
    {
        ThreadPool.GetMaxThreads(out var workerThreads, out var ioThreads);
        Console.WriteLine("Max Thread pool threads by default are: ");
        Console.WriteLine($" worker threads = {workerThreads:N0}");
        Console.WriteLine($" i/o threads = {ioThreads:N0}");
        Console.Write("Press any key to continue");
        Console.ReadKey();
    }

    private static void ShowMinThreads()
    {
        ThreadPool.GetMinThreads(out var workerThreads, out var ioThreads);
        Console.WriteLine("Min Thread pool threads by default are: ");
        Console.WriteLine($" worker threads = {workerThreads:N0}");
        Console.WriteLine($" i/o threads = {ioThreads:N0}");
        Console.Write("Press any key to continue");
        Console.ReadKey();
    }

    private static void ShowAvailableThreads()
    {
        ThreadPool.GetAvailableThreads(out var workerThreads, out var ioThreads);
        Console.WriteLine("Thread pool threads available by default are: ");
        Console.WriteLine($" worker threads = {workerThreads:N0}");
        Console.WriteLine($" i/o threads = {ioThreads:N0}");
        Console.Write("Press any key to continue");
        Console.ReadKey();
    }

    static void DoSomething(object parameter)
    {
        for (var i = 10; i < 20; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(20);
        }
    }

    static void DoSomethingElse(object parameter)
    {
        for (var i = 20; i < 30; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(30);
        }
    }
}