// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Task68();

void Task68()
{
    int m = ReadInt("m: ");
    int n = ReadInt("n: ");
    if(IsPossible(m, n))
    {
        System.Console.WriteLine("enter a positive number (number > 0)");
        return;
    }
        System.Console.WriteLine(Akkerman(m, n));
}

int ReadInt(string argument)
{
    System.Console.Write($"Input {argument}");
    return int.Parse(Console.ReadLine());
}

int Akkerman(int m, int n)
{
	if(m == 0)
    {
        return n + 1;
	}
	if(m > 0 && n == 0)
	{
		return Akkerman(m - 1, 1);
	}
	else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }	
}

bool IsPossible(int m, int n)
{
    return m < 0 && n < 0 || n < 0 || m < 0 ;
}