// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число"); // 54321

if(int.TryParse(Console.ReadLine(), out int n))
{
    if (n >= 10000 && n <99999)
    {
        int a = n / 10000;//5
        int b = (n % 10000) / 1000 ; //4
        int d = (n % 100) / 10; //2
        int e = n % 10; //1

        if (a == e && b == d)
        {
           Console.Write($"Палиндром");
        }
        else
        {
            Console.Write($"Не палиндром");
        }


       
    }
    else
    {
        Console.Write($"Не пятизначное число!");
    }
}
else
{
    Console.WriteLine($"Вы ввели не число!");
};