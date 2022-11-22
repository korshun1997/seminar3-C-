// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Enter coordinate xa");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinate ya");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinate za");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinate xb");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinate yb");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinate zb");
int zb = Convert.ToInt32(Console.ReadLine());
double r = 0;
double f;
double length(double r,int xa, int ya, int za, int xb, int yb, int zb)
{
    r = Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za));
    return r;
}
f = length(r, xa, xb, ya, yb, za, zb);
Console.WriteLine($"Way between points A and B = {f}");
