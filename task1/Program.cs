﻿// Задача 1: Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num % 7) == 0 && (num % 23) == 0)
{
    Console.Write(true);
}
else
{
    Console.Write(false);
}