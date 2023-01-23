using static System.Console;

Clear();

Write("Ведите размер массива: ");
int arraySize = int.Parse(ReadLine()!);
int[] array = GetArray(arraySize);

WriteLine($"Получившийся массив: [{String.Join(", ", array)}]");

int countPositive = FindPositiveNum(array);

WriteLine($"Количество положительных чисел: {countPositive}");

int[] GetArray(int size)
{
    Console.Write($"Введите {size} чисел через пробел: ");
    string M = Console.ReadLine()!;
    string[] stringArray = M.Split(' ');
    int[] resultArray = new int[size];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = int.Parse(stringArray[i]);
    }
    return resultArray;
}

int FindPositiveNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}