//Task31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9;9]
// найдите сумму отрицательных и положительных элементов массива

int maxSum =0;
int minSum = 0;
int Length = ReadInt ("Array length: ");
int[] array = GetRandomArray(Length, -9, 9);

PrintArray(array);
CalculateSum(array);
System.Console.WriteLine($"Positive sum: {maxSum}; Negative sum {minSum}");
    


int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine());
}


int[] GetRandomArray(int Length, int minValue, int maxValue)
{
   	int[] array = new int[Length];
    Random random = new Random();

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = random.Next(minValue, maxValue + 1);
	}

	return array;
}

void CalculateSum(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] < 0)
        {
            minSum += array[i];  
        }
    
    	else
        {
            maxSum += array[i];
        }  
    } 
}

 
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
}
