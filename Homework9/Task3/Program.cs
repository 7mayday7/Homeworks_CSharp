using static System.Console;
Clear();

Write("m = ");
int m = int.Parse(Console.ReadLine()!);

Write("n = ");
int n = int.Parse(Console.ReadLine()!);

int result = Ackermann(m, n);

WriteLine($"\nРезультат вычисления функции Аккермана: {result}");

int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return Ackermann(m - 1, 1);

    return Ackermann(m - 1, Ackermann(m, n - 1));
}