﻿// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

Console.WriteLine("Введите число a = ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b = ");
int b = int.Parse(Console.ReadLine());

if(a > b)
{
    Console.WriteLine("max = " + a);
    Console.WriteLine("min = " + b);
}
else
{
    Console.WriteLine("max = " + b);
    Console.WriteLine("min = " + a);
}
