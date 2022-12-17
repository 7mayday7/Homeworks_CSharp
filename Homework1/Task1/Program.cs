using static System.Console;

Console.WriteLine("Программа нахождения наибольшего из двух чисел");

Write("a = ");
int a = Convert.ToInt32(ReadLine());

Write("b = ");
int b = Convert.ToInt32(ReadLine());

if(a > b)
{
    WriteLine($"Наибольшее число: {a}");
}
else if (b > a)
{
    WriteLine($"Наибольшее число: {b}");
}
else
{
    WriteLine("Числа равны!");
}
