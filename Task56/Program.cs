// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Task56();

void Task56()
{
    int[,] array = GetArray(ReadInt("first Length"), ReadInt("second Length"));
     if(IsPossibleArray (array))
    {
        System.Console.WriteLine("Enter a rectangular array (first length and second length are not equal)");
        return;
    }

    PrintArray(array); 
    int minSumRow = 0;
    int sumRow = SumOfRowElements(array, 0);
    for (int i =1; i < array.GetLength(0); i++)
    {
        int tempSumRow = SumOfRowElements(array, i);
        if (sumRow > tempSumRow)
        {
            sumRow = tempSumRow;
            minSumRow =i;
        }
    }
    System.Console.WriteLine($"{minSumRow +1} - row with the smallest sum of elements {sumRow}");
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

int SumOfRowElements(int[,] array, int i)
{
  int sumRow = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumRow += array[i,j];
  }
  return sumRow;
}

bool IsPossibleArray (int[,] array)
{
    return array.GetLength(0) == array.GetLength(1);
}