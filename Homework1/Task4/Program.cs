using static System.Console;

Console.WriteLine("Программа поиска четных чисел в диапазоне от 1 до n");

Write("n = ");
int n = Convert.ToInt32(ReadLine());

int begin = 1;

while (begin <= n)
{
    if (begin % 2 == 0)
    {
        WriteLine(begin);
    }
    begin += 1;
}
