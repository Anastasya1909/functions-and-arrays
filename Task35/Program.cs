//Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]
//int length = ReadInt("Array length");
//int find = ReadInt("Find nunber");
int[] array = GetRandomArray(123, 0, 1000);

PrintArray(array);
System.Console.WriteLine();
int count = FindElements(array);
System.Console.WriteLine(count);

//PrintArray(array);

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

void plusminus(int [] array)
{
    for (int i = 0; i < array.Length; i++)
	{
		array[i] = array[i] * -1;
	}
}

void FindNumber(int [] array, int find)
{
    for (int i = 0; i < array.Length; i++)
	{
		if(array[i] == find)
        {
            Console.WriteLine("yes");
            return;
        }
    }
    Console.WriteLine("no");
}

int FindElements(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
	{
		if(array[i] >= 10 && array[i] <= 99)
        {
            count ++;
        }
    }
    return count;
}