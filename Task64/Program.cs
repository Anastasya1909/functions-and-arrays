// Задача 64. Напишите программу, которая заполнит спирально массив 4 на 4.

Task64();

void Task64()
{
    int length = 4;
    int[,] spiralarray = new int[length, length];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= spiralarray.GetLength(0) * spiralarray .GetLength(1))
    {
        spiralarray [i, j] = temp;  
        temp++;
        if (i <= j + 1 && i + j < spiralarray .GetLength(1) - 1)
        j++;
        else if (i < j && i + j >= spiralarray .GetLength(0) - 1)
        i++;
        else if (i >= j && i + j > spiralarray .GetLength(1) - 1)
        j--;
        else
        i--;
    }
    PrintArray (spiralarray); 
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}