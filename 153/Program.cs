// Программа, которая принимает трухзначное число и на выходе показывает последнюю цифру этого числа
Console.WriteLine("Напишите трехзначное число от 100 до 999: ");
if(int.TryParse(Console.ReadLine(), out int n))
{
    if (n >= 100 && n <1000)
    {
        int x = n % 10;
        Console.Write($"Последняя цифра {x}");
    }
    else
    {
        Console.Write($"Не трехзначное число!");
    }
}
else
{
    Console.WriteLine($"Вы ввели не число!");
};
