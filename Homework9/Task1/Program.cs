using static System.Console;
Clear();

Write("N = ");
int N = int.Parse(Console.ReadLine()!);
WriteLine($"\nНатуральные числа в промежутке от {N} до 1: \n{GetNumbers(N)}");

string GetNumbers(int num)
{
    if (num == 1) return num.ToString();
    else return $"{num}, {GetNumbers(num - 1)}";
}