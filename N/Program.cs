//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

int count = (-n);
while (count <= n)
{
    Console.Write(count);
    count = count + 1;
};
