using static System.Console;

Clear();

Write("Введите число: ");
int number = int.Parse(ReadLine());
Write("Введите степень: ");
int degree = int.Parse(ReadLine());

int answer = PovNum(number, degree);

WriteLine($"Число {number} в степени {degree} = {answer}");

int PovNum(int num, int pov)
{
    int result = 1;

    if (pov == 0) return 1;

    for (int i = 0; i < pov; i++)
    {
        result *= num;
    }
    return result;
}