using static System.Console;

Console.WriteLine("Программа нахождения наибольшего из трех чисел");

Write("a = ");
int a = Convert.ToInt32(ReadLine());

Write("b = ");
int b = Convert.ToInt32(ReadLine());

Write("c = ");
int c = Convert.ToInt32(ReadLine());

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.WriteLine($"Наибольшее число: {max}");
