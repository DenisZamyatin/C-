// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


Console.WriteLine ("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Таблица кубов: ");
for (int i=1; i<=N; i++)
{
Console.WriteLine ($"{i*i*i}" );
} 