//Task25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
//Task27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
//Task29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Main();

void Main()
{
	bool isWorking = true;
	while (isWorking)
	{
		Console.Write("Input command: ");
		switch (Console.ReadLine())
		{
			case "Task25": Task25(); break;
            case "Task27": Task27(); break;
			case "Task29": Task29(); break;
			case "exit": isWorking = false; break;
		}
		Console.WriteLine();
	}
}

void Task25()
{
	Console.WriteLine("Task25");

	int numberA = ReadInt("first number (A)");
	int numberB = ReadInt("second number (B)");

	Console.WriteLine($"The power {numberB} of number {numberA} is {Pow(numberA, numberB)}");
}

int ReadInt(string argumentName)
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine());
}


int Pow(int firstNumber, int secondNumber)
{
	int result = 1;

	for (int i = 0; i < secondNumber; i++)
	{
		result *= firstNumber;
	}

	return result;
}


void Task27()
{
	Console.WriteLine("Task27");

	int number = ReadInt("Number 0 - 999: "); //579
	Console.WriteLine($"Sum of numbers is {GetNumber(number)}");
}

int GetNumber(int number)
{
    int sum = 0;
    int a = number/ 100;
    int b = (number/ 10) % 10;
    int c = number % 10;
    sum = sum + a + b + c;
    return sum;
}

void Task29()
{
	Console.WriteLine("Task29");

	int[] array = GetArray(ReadInt("array length"));

	Console.WriteLine(ArrayToString(array));
}


int[] GetArray(int length)
{
	int[] array = new int[length];

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = ReadInt($"elemtn {i}");
	}

	return array;
}

string ArrayToString(int[] array)
{
	string result = string.Empty;

	for (int i = 0; i < array.Length; i++)
	{
		result += $"{array[i]}, ";
	}

	return result;
}