using static System.Console;

Clear();

Write("Введите число: ");
int num = Convert.ToInt32(ReadLine());

int result;

if (num >= 100)
{
    while (num > 999)
    {
        num = num / 10;
    }
    result = num % 10;
    WriteLine($"Третья цифра числа: {result}");
}
else
{
    WriteLine("Третьей цифры нет");
}