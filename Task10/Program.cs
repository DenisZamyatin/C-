// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите целое трехзначенное положительное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num >=100 && num <=999)

{
    int numSecond = (num %100 - num%10)/10;
    Console.Write(numSecond);
}
else
{
    Console.Write("Некорректное число");
}