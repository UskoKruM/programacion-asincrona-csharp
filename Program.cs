using System.Diagnostics;

static async Task Task1()
{
    await Task.Delay(2000);
    Console.WriteLine("Task 1 completed!");
}

static async Task Task2()
{
    await Task.Delay(4000);
    Console.WriteLine("Task 2 completed!");
}

static async Task Task3()
{
    await Task.Delay(7000);
    Console.WriteLine("Task 3 completed!");
}

static async Task Execute()
{
    Task task1 = Task1();
    Task task2 = Task2();
    Task task3 = Task3();

    await Task.WhenAll(task1, task2, task3);
}

Stopwatch stopwatch = new();
stopwatch.Start();

await Execute();

stopwatch.Stop();
Console.WriteLine($"Execution time: {stopwatch.ElapsedMilliseconds} ms.");