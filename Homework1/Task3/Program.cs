using static System.Console;

Console.WriteLine("Программа определения четности числа");

Write("Введите целое число: ");
int num = Convert.ToInt32(ReadLine());

if (num % 2 == 0)
{
    WriteLine($"Число {num} — четное");
}
else
{
    WriteLine($"Число {num} — нечетное");
}
