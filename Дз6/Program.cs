﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число от 0 до N: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    double result = Math.Pow(i, 3);
    Console.Write(result);
    Console.Write(", ");
};
