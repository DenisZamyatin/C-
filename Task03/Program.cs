﻿//  Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write ("Введите число: ");


int a = Convert.ToInt32(Console.ReadLine());

if (a== 1)
{
    Console.Write ($"По номеру {a} - Понедельник ");

}
if (a== 2)
{
    Console.Write ($"По номеру {a} - Вторник ");

}
if (a== 3)
{
    Console.Write ($"По номеру {a} - Среда ");

}
if (a== 4)
{
    Console.Write ($"По номеру {a} - Четверг ");

}
if (a== 5)
{
    Console.Write ($"По номеру {a} - Пятница ");

}
if (a== 6)
{
    Console.Write ($"По номеру {a} - Суббота ");

}
if (a== 7)
{
    Console.Write ($"По номеру {a} - Воскресенье");

}
if (a>7)
{
    Console.Write ($"По номеру {a} - По этому номеру нет дня недели");
}

if (a<7)
{
    Console.Write ($"По номеру {a} - По этому номеру нет дня недели");
}