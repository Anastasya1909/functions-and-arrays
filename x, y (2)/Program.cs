﻿// Напишите программу, которая по заданному номеру четверти определит возможные координаты
Console.Write("Введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine());

int x_min = 0;
int x_max = 0;
int y_min = 0;
int y_max = 0;

if (quarter == 4)
{
    x_max = int.MaxValue;
    y_max = -1;
    x_min = 1;
    y_min = int.MinValue;
}

else if (quarter == 3)
{
    x_max = -1;
    y_max = int.MinValue;
    x_min = int.MinValue;
    y_min = -1;
}

else if (quarter == 2)
{
    x_max = -1;
    y_max = int.MaxValue;
    x_min = int.MinValue;
    y_min = 1;
}

else if (quarter == 1)
{
    x_max = int.MaxValue;
    y_max = int.MaxValue;
    x_min = 1;
    y_min = 1;
};

Console.WtiteLine($"Диапазон возможных координат: x: ({x_min}, {x_max}), y: {y_min}, {y_max})");