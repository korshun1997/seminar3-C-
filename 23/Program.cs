// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
if (N<0)
{
    Console.WriteLine("Error, N must be >0");
}
int i = 1;
int m = i;
void Cubes(int i,int m, int N)
{
    while (i<=N)
    {
        m = i*i*i;
        i++;
        Console.Write($"{m} ");
    }
}
Cubes(i, m, N);