﻿// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно




//  Console.Write ("Введите первое целое число: ");
//     int number1 = Convert.ToInt32(Console.ReadLine());

//     Console.Write ("Введите второе целое число: ");
//     int number2 = Convert.ToInt32(Console.ReadLine());
//     int number3 = number1 % number2;
//     if (number3 == 0)
//     {
//         Console.WriteLine("Кратное");
//     }
//     else 
//     {
//         Console.WriteLine("Не кратное ");
//         Console.WriteLine(number3);
//     }
   //////Решение методом


 Console.Write ("Введите первое целое число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.Write ("Введите второе целое число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    
    int result = RemainderDivision(number1, number2);
    Console.WriteLine(result == 0 ? "кратно" : $"не кратно, остаток {result
    }" );
    // if (result == 0)
    //     Console.WriteLine("Кратно");
    // else
    //     Console.WriteLine($"Не кратно, остаток {result}");
    
    int RemainderDivision(int num1, int num2)
    {

        return num1 % num2;
    }
 