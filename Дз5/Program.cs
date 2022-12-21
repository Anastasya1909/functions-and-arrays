// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
Console.Write("Введите координаты первой точки А, x1= ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты первой точки А, y1= ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты первой точки А, z1= ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine($"Координаты точки A({x1},{y1},{z1})");

Console.Write("Введите координаты первой точки B, x2= ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты первой точки B, y2= ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты первой точки B, z2= ");
int z2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Координаты точки B({x2},{y2},{z2})");

//расстояние АВ
double result1 = (Math.Pow((x2 - x1), 2) + (Math.Pow((y2 - y1), 2)) + (Math.Pow((z2 - z1), 2)));
double result2 = Math.Sqrt(result1);
Console.WriteLine($"Расстояние от точки А до точки В равно {result2}");
