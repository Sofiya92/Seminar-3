// Напишите программу, которая принимает координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

Console.WriteLine("Введите координаты первой точки");
Console.Write ("X = ");
int xPointA = Convert.ToInt32(Console.ReadLine());
Console.Write ("Y = ");
int yPointA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write ("X = ");
int xPointB = Convert.ToInt32(Console.ReadLine());
Console.Write ("Y = ");
int yPointB = Convert.ToInt32(Console.ReadLine());
double distance = Distance(xPointA, xPointB, yPointA, yPointB);
Console.WriteLine($"Расстояние между точек = {Math.Round(distance, 2, MidpointRounding.ToZero)}");

double Distance(int xA, int xB, int yA, int yB)
{
    return Math.Sqrt(Math.Pow(xA-xB, +2)+Math.Pow(yA-yB, +2));
}