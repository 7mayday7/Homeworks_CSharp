using static System.Console;

Clear();

WriteLine("Таблица кубов от 1 до N");

Write("Введите N: ");
if (!int.TryParse(ReadLine(), out int N))
{
    WriteLine("Ошибка! Введено не число!");
    return;
}

int i = 1;

if (N > 0)
{
    while (i <= N)
    {
        Write($"{Math.Pow(i, 3)} ");
        i++;
    }
}
else
{
    while (i >= N)
    {
        Write($"{Math.Pow(i, 3)} ");
        i--;
    }
}