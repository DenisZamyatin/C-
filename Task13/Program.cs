// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int numDigit = NumberDigit(num);
if (numDigit <= 2)
{
    Console.WriteLine("третьей цифры нет");
}

else
{
    if (numDigit > 3)
    {
        num = num/Convert.ToInt32(Math.Pow(10, numDigit - 3)); 
    }
    num = num % 10;
    Console.WriteLine($"Третья цифра введённого числа: {num}");
}
