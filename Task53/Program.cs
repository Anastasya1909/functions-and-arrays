// Задача 53. Задайте двумерный массив.Напишите программу, которая поменяет местами первую и последнюю строку массива
Task53();

void Task53()
{
    int[,] array = GetArray(ReadInt("first Length"), ReadInt("second Length"));
    PrintArray(array); 
    ChangeFirstAndLastRows(array);
    PrintArray(array);
}

int ReadInt(string argument)
{
    System.Console.Write($"Input {argument}:");
    return int.Parse(Console.ReadLine());
}

int[,] GetArray (int firstLength, int secondLength)
{
    int[,] array = new int[firstLength, secondLength];
    Random random = new Random();
    for (int i = 0; i < firstLength; i++)
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
    Console.WriteLine();
}

void ChangeFirstAndLastRows(int[,] array)
{
    int[] firstRow = GetFirstRow(array);
    PutLastRowOnFirstRow(array);
    PutfirstRowOnLastRow(array, firstRow);
}

int[] GetFirstRow(int[,] array)
{
    int[] tempArray = new int[array.GetLength(0)];    
    for (int i = 0; i < array.GetLength(1); i++)
    {
        tempArray[i] = array[0,i];
    }
    return tempArray;
}

void PutLastRowOnFirstRow(int[,] array)
{
    int lastRowIndex = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++ )
    {
        array[0,i] = array[lastRowIndex, i];
    }
}

void PutfirstRowOnLastRow(int[,] array, int[] firstRow)
{
    int lastRowIndex = array.GetLength(0) -1;
    for (int i = 0; i < array.GetLength(1); i++ )
    {
        array[lastRowIndex, i] = firstRow[i];
    }
}