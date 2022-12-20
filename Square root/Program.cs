// Является ли число А квадратом число В
Console.WriteLine("Введите число А:");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B:");
int numberB = int.Parse(Console.ReadLine());

double result = Math.Pow(numberB,2);

if (numberA == result)
{
System.Console.WriteLine($"да");
}
else 
{
System.Console.WriteLine($"нет");  
}
