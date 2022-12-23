//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int length = ReadInt ("Array length: ");
int[] array = GetRandomArray(length, 0, 100);
int sum = SumMaxAndMin(array);

PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine(sum);


int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine());
}

int[] GetRandomArray(int length, int minValue, int maxValue)
{
	int [] array = new int[length];
	Random random = new Random();

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = random.Next(minValue, maxValue + 1);
	}

	return array;
}


void PrintArray(int [] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]}, ");
	}
}

int SumMaxAndMin(int [] array)
{
    int sum = 0;
    int max = array[0];
    int min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > max )
        max = array [i];
        if (array [i] < min )
        min = array [i];
    }
    sum = max + min;
    return sum;
}