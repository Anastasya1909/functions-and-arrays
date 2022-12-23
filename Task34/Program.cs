//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int length = ReadInt ("Array length: ");
int[] array = GetRandomArray(length, 100, 1000);

PrintArray(array);
System.Console.WriteLine();
int count = FindElements(array);
System.Console.WriteLine(count);


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
		if(array[i] % 2 == 0)
        {
            count ++;
        }
    }
    return count;
}