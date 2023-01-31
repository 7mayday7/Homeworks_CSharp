using static System.Console;
Clear();

Write("Введите размер и диапазон значений для первой матрицы через пробел: ");
string[] parameters1 = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array1 = GetMatrixArray(int.Parse(parameters1[0]),
                              int.Parse(parameters1[1]),
                              int.Parse(parameters1[2]),
                              int.Parse(parameters1[3]));


Write("Введите размер и диапазон значений для второй матрицы через пробел: ");
string[] parameters2 = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array2 = GetMatrixArray(int.Parse(parameters2[0]),
                               int.Parse(parameters2[1]),
                               int.Parse(parameters2[2]),
                               int.Parse(parameters2[3]));

PrintMatrixArray(array1);
WriteLine();
PrintMatrixArray(array2);
WriteLine();
int[,] resultMatrix = GetMatrixProduct(array1, array2);
PrintMatrixArray(resultMatrix);

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

int[,] GetMatrixProduct(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}