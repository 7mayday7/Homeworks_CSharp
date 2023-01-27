using static System.Console;
Clear();

Write("Введите размер матрицы через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]));
WriteLine();
PrintMatrixArray(array);

Write("\nВведите номер строки элемента: ");
int r = int.Parse(ReadLine()!);
Write("\nВведите номер столбца элемента: ");
int c = int.Parse(ReadLine()!);

WriteLine();
FindElement(array, r, c);


int[,] GetMatrixArray(int rows, int columns)
{
    int[,] resultArray = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = random.Next(1, 10);
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],3} ");
        }
        WriteLine();
    }
}

void FindElement(int[,] array, int row, int col)
{
    if (row >= array.GetLength(0) || col >= array.GetLength(1))
    {
        WriteLine("Такого элемента в массиве нет");
    }
    else
    {
        WriteLine($"Значение элемента: {array[row, col]}");
    }
}