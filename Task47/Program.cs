// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int length = ReadInt("Input m: ");
int secondlength = ReadInt("Input n: ");

double[,]array = GetArray(length, secondlength);
PrintArray(array);
System.Console.WriteLine();

int ReadInt(string argument)
{
    Console.Write($"{argument}: ");
    return int.Parse(Console.ReadLine());
}

double[,] GetArray(int length, int secondlength)
{
    double [,] array = new double[length, secondlength];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < secondlength; j++)
        {
            array[i,j] = Math.Round((random.NextDouble() + random.Next(100)),2);
        }
    }
    return array;    
}

void PrintArray (double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
