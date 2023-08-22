using System.Diagnostics;

Stopwatch stopwatch = new Stopwatch();
int n1 = 5;
int n2 = 10;
int n3 = 20;

#region Рекурсивный метод
stopwatch.Start();
int result1 = FibonacciRecursive(n1);
stopwatch.Stop();
Console.WriteLine($"Время выполнения рекурсивного метода для n = {n1}: {stopwatch.ElapsedMilliseconds} мс");

stopwatch.Reset();

stopwatch.Start();
int result2 = FibonacciRecursive(n2);
stopwatch.Stop();
Console.WriteLine($"Время выполнения рекурсивного метода для n = {n2}: {stopwatch.ElapsedMilliseconds} мс");

stopwatch.Reset();

stopwatch.Start();
int result3 = FibonacciRecursive(n3);
stopwatch.Stop();
Console.WriteLine($"Время выполнения рекурсивного метода для n = {n3}: {stopwatch.ElapsedMilliseconds} мс");

stopwatch.Reset();

Console.WriteLine();
#endregion

#region Итеративный метод
stopwatch.Start();
int result4 = FibonacciIterative(n1);
stopwatch.Stop();
Console.WriteLine($"Время выполнения итеративного метода для n = {n1}: {stopwatch.ElapsedMilliseconds} мс");

stopwatch.Reset();

stopwatch.Start();
int result5 = FibonacciIterative(n2);
stopwatch.Stop();
Console.WriteLine($"Время выполнения итеративного метода для n = {n2}: {stopwatch.ElapsedMilliseconds} мс");

stopwatch.Reset();

stopwatch.Start();
int result6 = FibonacciIterative(n3);
stopwatch.Stop();
Console.WriteLine($"Время выполнения итеративного метода для n = {n3}: {stopwatch.ElapsedMilliseconds} мс");
#endregion

int FibonacciRecursive(int n)
{
    if (n <= 1)
        return n;

    return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
}

int FibonacciIterative(int n)
{
    if (n <= 1)
        return n;

    int previous = 0;
    int current = 1;

    for (int i = 2; i <= n; i++)
    {
        int temp = previous;
        previous = current;
        current = temp + current;
    }

    return current;
}