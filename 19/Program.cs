// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
bool f=false;
bool Palyndrome(int N)
{
    if (N /10000 != N %10 && (N /1000%10)!=(N %100)/10 )
    {
        return false;
    } 
    else
    {
        return true;
    }
}
if (N<10000 || N>99999)
{
    Console.WriteLine("Ошибка, число должно быть пятизначным");
}
else
{
  f = Palyndrome(N); 
  if (f==true)
{
    Console.WriteLine("Данное число - палиндром");
}
else
{
    Console.WriteLine("Данное число - не палиндром");
} 
}
