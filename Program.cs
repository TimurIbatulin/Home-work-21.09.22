﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// // 918 -> 1
// Console.Write("Введите трехзначное число - ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = a/10;
// int c = b%10;
// Console.WriteLine($"Число на второй позиции = {c}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите трехзначное число - ");
int a = Convert.ToInt32(Console.ReadLine());
if (a<100)
{
    Console.WriteLine($"Число {a} меньше 100");
}
if (a > 100)
{
    while (a > 999)
    {
        a = a/10;
    }
    a = a%10;
    Console.WriteLine($"Число на третьей позиции = {a}");
}




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет