namespace Day45Demo.TaskDemo;

public static class TaskTest2
{
    public static async Task DummyTest2Async()
    {
        await DummyTest1Async();
    }

    public static async Task DummyTest1Async()
    {
        await Test();
    }
    
    public static async Task Test()
    {
        Console.WriteLine("Starting Task Demo: With await");
        var task1 = Task.Run(SomeWork);
        var task2 = Task.Run(SomeWork);
        Console.WriteLine("Ending Task Demo: With await");

        await task1;        // asynchronous
        await task2;        // asynchronous
    }

    private static void SomeWork()
    {
        for (var i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(100);
        }
    }
}
