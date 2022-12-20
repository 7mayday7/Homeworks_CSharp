using static System.Console;

Clear();

Write("Введите трехзначное число: ");
int num = Convert.ToInt32(ReadLine());

int second_digit = num % 100 / 10;

WriteLine($"Вторая цифра числа: {second_digit}");
