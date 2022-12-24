using static System.Console;

Clear();

Write("Введите число: ");

if (!Int32.TryParse(ReadLine(), out int num))
{
    WriteLine("Ошибка! Введено не число!");
    return;
}

int remainder;
int sum = 0;
int temp = num;

while (num > 0)
{
    remainder = num % 10;
    sum = (sum * 10) + remainder;
    num = num / 10;
}

Console.WriteLine(temp == sum ? $"Число {temp} - палиндром" : $"Число {temp} - не палиндром");