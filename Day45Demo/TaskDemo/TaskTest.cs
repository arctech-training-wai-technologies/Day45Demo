namespace Day45Demo.TaskDemo;

public static class TaskTest
{
    public static void Test()
    {
        Console.WriteLine("Starting Task Demo: With Wait()");
        var task1 = Task.Run(SomeWork);
        var task2 = Task.Run(SomeWork);
        Console.WriteLine("Ending Task Demo: With Wait()");

        task1.Wait();   // synchronous
        task2.Wait();   // synchronous
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
