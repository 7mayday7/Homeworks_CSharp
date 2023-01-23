using static System.Console;

Clear();

Write("Введите число: ");
int number = int.Parse(ReadLine()!);

int answer = SumDigit(number);

WriteLine($"Сумма цифр в числе {number} = {answer}");

int SumDigit(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}