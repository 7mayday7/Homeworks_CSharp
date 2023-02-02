using static System.Console;
Clear();

Write("M = ");
int m = int.Parse(Console.ReadLine()!);

Write("N = ");
int n = int.Parse(Console.ReadLine()!);

int result = GetSum(m, n);

WriteLine($"\nСумма натуральных элементов в промежутке от {m} до {n} = {result}");

int GetSum(int m, int n)
{
    return m == n ? m : n + GetSum(m, n - 1);
}