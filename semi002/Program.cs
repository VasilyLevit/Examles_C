﻿// SНапишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 5; b = 25 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> нет
// a = -3 b = 9 -> да

Console.WriteLine("Введите 1 число:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 2 число:");
int b = int.Parse(Console.ReadLine());

if (b == a*a)
{ 
   Console.WriteLine("2е число является квадратом первого"); 
} else
Console.WriteLine("2е число не является квадратом первого");