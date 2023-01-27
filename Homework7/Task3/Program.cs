using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));
PrintMatrixArray(array);
WriteLine();
getArrayOfAverages(array);

int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = rnd.Next(minValue, maxValue + 1);
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
            Write($"{inArray[i, j],5} ");
        }
        WriteLine();
    }
}

void getArrayOfAverages(int[,] intArray)
{
    double[] columnAverages = new double[intArray.GetLength(1)];

    for (int j = 0; j < intArray.GetLength(1); j++)
    {
        double currentSum = 0;
        for (int i = 0; i < intArray.GetLength(0); i++)
        {
            currentSum += intArray[i, j];
        }
        columnAverages[j] = currentSum / intArray.GetLength(0);
    }

    for (int i = 0; i < columnAverages.Length; i++)
    {
        Write($"{columnAverages[i]}; ");
    }
}
