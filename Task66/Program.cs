//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Task66();

void Task66()
{
    
    int M = ReadInt("M: ");
    int N = ReadInt("N: ");
    if(IsPossible(M, N))
    {
        System.Console.WriteLine("enter a natural number (number > 0)");
        return;
    }
    System.Console.WriteLine(SumElements(M, N));
}

int ReadInt(string argument)
{
    System.Console.Write($"Input {argument}");
    return int.Parse(Console.ReadLine());
}

int SumElements (int M, int N)
{
    int result = 0;
    for (int i = M; i <= N; i++) result += i;
    return result;
}

bool IsPossible(int M, int N)
{
    return M < 0 && N < 0 || N < 0 || M < 0 ;
}