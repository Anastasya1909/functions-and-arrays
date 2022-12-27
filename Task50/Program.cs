// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int length = 4;
int secondLength = 4;

int[,] array = GetArray(length, secondLength);
PrintArray(array);
int columns = ReadInt("column index");
int rows = ReadInt("row index");


FindElements (array, columns, rows);

int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine()!);
}

int[,] GetArray (int length, int secondLength)
{
    int[,] array = new int[length, secondLength]; 
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < secondLength; j++)
        {
            array[i, j] = random.Next(100); 
        }
    }
    return array;
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindElements (int[,] array, int columns, int rows)
{
    if (rows < array.GetLength(0) && columns < array.GetLength(1))
    {
        Console.WriteLine(array[rows,columns]);
    }
        else
    {
        Console.WriteLine($"array[{rows},{columns}] no such element");
    }
}
