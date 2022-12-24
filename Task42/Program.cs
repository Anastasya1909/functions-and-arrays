// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное
int number = ReadInt("number");
Transform(number);


int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine()!);
}

void Transform(int number)
{
    string result = string.Empty;
    while (number != 0)
    {
        result += number % 2;
        number /= 2;        
    }
    string Reverse(string result)
    {
        char [] array = result.Reverse().ToArray();
        string new_result = string.Empty;
        foreach(char c in array)
        {
            new_result += c;
        }
        return new_result;
    }

    System.Console.WriteLine(Reverse(result));
}