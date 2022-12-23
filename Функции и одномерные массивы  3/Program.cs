// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве

int length = ReadInt("Array length");
int find = ReadInt("Find nunber");
int[] array = GetRandomArray(length, -15, 15);
PrintArray(array);
System.Console.WriteLine();
FindNumber(array, find);

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