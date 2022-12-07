int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

System.Console.WriteLine(Fibonacci(10));

// 1 + 1 + 2 + 3 + 5 + 8 + 13 + 21 + 34 + 55

for (int i = 1; i <= 10; i++)
{
    System.Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}