// See https://aka.ms/new-console-template for more information

using Day45Demo.EntityFrameworkAsyncAwaitDemo;
using Day45Demo.FileHandlingAsync;
using Day45Demo.TaskDemo;
using System.Diagnostics;

//Console.WriteLine("Hello, World!");

// What is a thread?
// Smallest unit of execution

//ThreadTest.Test();

//BouncyBall.Test();
//BouncyBall.Test2();

//ThreadPoolTest.Test();

//ThreadLockTest.Test();

//TaskTest.Test();

//await TaskTest2.DummyTest2Async();

/*
var stopWatch = new Stopwatch();

stopWatch.Start();
EfCoreTest.Test();
stopWatch.Stop();
Console.WriteLine($"Sync TimeTaken = {stopWatch.ElapsedMilliseconds}ms");

stopWatch.Start();
await EfCoreTest.TestAsync();
stopWatch.Stop();
Console.WriteLine($"Async TimeTaken = {stopWatch.ElapsedMilliseconds}ms");
*/

await FileHandlingTest.TestAsync();