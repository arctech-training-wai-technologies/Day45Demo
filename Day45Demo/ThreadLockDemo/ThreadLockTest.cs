namespace Day45Demo.ThreadLockDemo;

public static class ThreadLockTest
{
    public static void Test()
    {
        var numberProcessor = new NumberProcessor(10, 20);

        Console.WriteLine("This is the NON-Thread demo");
        Console.WriteLine("---------------------------");
        numberProcessor.DoSomething();  // 10, 20 | 20, 10
        numberProcessor.DoSomething();  // 20, 10 | 10, 20
        Console.WriteLine("---------------------------");
        
        Console.WriteLine("This is the Thread demo");
        Console.WriteLine("-----------------------");
        var numberProcessorForThread = new NumberProcessor(10, 20);
        var thread1 = new Thread(numberProcessorForThread.DoSomething);
        var thread2 = new Thread(numberProcessorForThread.DoSomething);
        Console.WriteLine("-----------------------");

        thread1.Start();
        thread2.Start();
    }
}

class NumberProcessor
{
    private readonly object _myKey = new object();
    private int _num1;
    private int _num2;

    public NumberProcessor(int num1, int num2)
    {
        _num1 = num1;
        _num2 = num2;
    }

    public void DoSomething()
    {
        lock (_myKey)
        {
            Show();
            ProcessSwap();
            Show();
        }
    }

    public void ProcessSwap()
    {
        var numTemp = _num1;
        Thread.Sleep(1000);
        _num1 = _num2;
        Thread.Sleep(1000);
        _num2 = numTemp;
    }

    public void Show()
    {
        Console.WriteLine($"num1={_num1}, num2={_num2}");
    }
}