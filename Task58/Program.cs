// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Task58();

void Task58()
{
    int m = ReadInt("number of rows of the first array: ");
    int n = ReadInt("Enter the number of columns of the 1st array (and rows of the 2nd): ");
    int p = ReadInt("Enter the number of columns of the 2nd array: ");

    System.Console.WriteLine("Array 1: ");
    int[,] array1 = GetArray(m, n);
    PrintArray(array1); 
    System.Console.WriteLine(" ");

    System.Console.WriteLine("Array 2: ");
    int[,] array2 = GetArray(n, p);
    PrintArray(array2); 

    int[,] resultarray = new int[m, p];
    MultiplicationArray(array1, array2, resultarray);
    System.Console.WriteLine($"Array multiplication result: ");
    PrintArray(resultarray); 
}


int ReadInt(string argument)
{
    System.Console.Write($"Input {argument}");
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
            array[i, j] = random.Next(10);
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

void MultiplicationArray(int[,] array1, int[,] array2, int[,] resultarray)
{
  for (int i = 0; i < resultarray.GetLength(0); i++)
  {
    for (int j = 0; j < resultarray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array1.GetLength(1); k++)
      {
        sum += array1[i,k] * array2[k,j];
      }
      resultarray[i,j] = sum;
    }
  }
}