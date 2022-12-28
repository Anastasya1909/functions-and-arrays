// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Task54();

void Task54()
{
    int[,] array = GetArray(ReadInt("first Length"), ReadInt("second Length"));
    PrintArray(array); 
    StringSortingArray(array);
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

void StringSortingArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}