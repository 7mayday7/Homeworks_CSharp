using static System.Console;

Clear();

Write("b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Write("k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Write("b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Write("k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

FindIntersection(k1, b1, k2, b2);

void FindIntersection(double pointK1, double pointB1, double pointK2, double pointB2)
{
    double x = Math.Round((pointB2 - pointB1) / (pointK1 - pointK2), 3);
    double y = Math.Round(pointK1 * x + pointB1, 3);
    Console.WriteLine($"({x};{y})");
}