//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


Console.WriteLine("Введите координату x первой точки a:");
int numx1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки a:");
int numy1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки a:");
int numz1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x второй точки b:");
int numx2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки b:");
int numy2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки b:");
int numz2 = Convert.ToInt32(Console.ReadLine());


double dis(int x1, int y1, int z1, int x2, int y2, int z2)
{
int corx = x2 - x1;
int cory = y2 - y1;
int corz = z2 - z1;
return Math.Sqrt(corx*corx+cory*cory+corz*corz);
}
double result = dis(numx1, numy1, numz1, numx2, numy2, numz2 );
double resRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками равно {resRound}");