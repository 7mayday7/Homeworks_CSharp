using static System.Console;
Clear();

Write("Введите размер матрицы через пробел: ");
string[] parameters1 = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,,] arr = CreateThreeDimensionalArray(int.Parse(parameters1[0]),
                                          int.Parse(parameters1[1]),
                                          int.Parse(parameters1[2]));

PrintMatrixArray(arr);
Print3DArray(arr);

int[,,] CreateThreeDimensionalArray(int row, int col, int dep)
{
    int[,,] result = new int[row, col, dep];
    List<int> numbers = new List<int>();
    Random random = new Random();
    while (numbers.Count < row * col * dep)
    {
        int r = random.Next(10, 99);
        if (!numbers.Contains(r))
        {
            numbers.Add(r);
        }
    }
    int cnt = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < dep; k++)
            {
                result[i, j, k] = numbers[cnt++];
            }
        }
    }
    return result;
}

void PrintMatrixArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Write($"{inArray[i, j, k],5} ");
            }
        }
        WriteLine();
    }
}

void Print3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}