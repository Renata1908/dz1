﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число С: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int maximal = Math.Max(Math.Max(numberA, numberB), numberC);

Console.WriteLine(maximal);

