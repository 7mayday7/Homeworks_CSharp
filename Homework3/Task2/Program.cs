using static System.Console;

Clear();

WriteLine("Введите координаты двух точек\n");

WriteLine("A(x1, y1, z1)\n");

Write("Введите x1: ");
if (!int.TryParse(ReadLine(), out int x1))
{
    WriteLine("Ошибка! Введено не число!");
    return;
}

Write("Введите y1: ");
if (!int.TryParse(ReadLine(), out int y1))
{
    WriteLine("Ошибка! Введено не число!");
    return;
}

Write("Введите z1: ");
if (!int.TryParse(ReadLine(), out int z1))
{
    WriteLine("Ошибка! Введено не число!");
    return;
}

WriteLine("\nB(x2, y2, z2)\n");

Write("Введите x2: ");
if (!int.TryParse(ReadLine(), out int x2))
{
    WriteLine("Ошибка! Введено не число!");
    return;
}

Write("Введите y2: ");
if (!int.TryParse(ReadLine(), out int y2))
{
    WriteLine("Ошибка! Введено не число!");
    return;
}

Write("Введите z2: ");
if (!int.TryParse(ReadLine(), out int z2))
{
    WriteLine("Ошибка! Введено не число!");
    return;
}

WriteLine($"\nA({x1},{y1},{z1})");
WriteLine($"B({x2},{y2},{z2})");


double res = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));

WriteLine($"\nРасстояние между двумя точками в 3D пространстве: {res:f2}");