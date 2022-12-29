// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Task64();

void Task64()
{
    int b = 1;
    int N = ReadInt("N: ");
    System.Console.WriteLine(NumbersRec(b, N));
}

int ReadInt(string argument)
{
    System.Console.Write($"Input {argument}");
    return int.Parse(Console.ReadLine());
}
string NumbersRec(int N, int b)
{
    if (N <= b) return NumbersRec(N + 1, b) + $"{N} ";
    else return String.Empty;       
}

