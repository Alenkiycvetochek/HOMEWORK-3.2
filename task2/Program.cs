// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

void FindPoin3D (double x1, double y1, double z1, double x2, double y2, double z2)
{
double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine("Расстояние между двумя точками в пространстве равно" + distance);
}

Console.WriteLine ("Input point x1 number");
double x1 = Convert.ToDouble(Console.ReadLine ());
Console.WriteLine ("Input point y1 number");
double y1 = Convert.ToDouble(Console.ReadLine ());
Console.WriteLine ("Input point z1 number");
double z1 = Convert.ToDouble(Console.ReadLine ());
Console.WriteLine ("Input point x2 number");
double x2 = Convert.ToDouble(Console.ReadLine ());
Console.WriteLine ("Input point y2 number");
double y2 = Convert.ToDouble(Console.ReadLine ());
Console.WriteLine ("Input point x1 number");
double z2 = Convert.ToDouble(Console.ReadLine ());

FindPoin3D (x1, y1, z1, x2, y2, z2);
