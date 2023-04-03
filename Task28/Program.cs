// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine()); 

int sumnumbers = Sumnumbers(number);
Console.WriteLine ($"произведение чисел от 1 до {number} = {sumnumbers}");


int Sumnumbers(int num)
{
    int product = 1;
    for (int count = 2; count <=num; count++)
    {
       product=product*count; // sum = sum + i; 
    }
    return product;
}

