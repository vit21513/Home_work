﻿//Задача 4: Напишите программу, которая принимает на
//вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье  число ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1; // присваиваем максимальное значение равное первому числу
if (num2 > max) 
{max = num2;}
if (num3 > max)
{max = num3;}
Console.WriteLine($"максимальное чиcло равно {max}");