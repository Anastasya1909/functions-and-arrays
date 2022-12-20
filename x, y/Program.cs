// Принять координаты и определить четверть
Console.Write("Введите х: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine());

int qwarter = 0;
if (x > 0)
{
    if (y < 0)
    {
        qwarter = 4;
    }
    else
    {
        qwarter = 1;
    }
}
else
{
    if (y > 0)
    {
        qwarter = 2;
    }
    else
    {
        qwarter = 3;
    }
};

Console.WriteLine(qwarter + " " + "qwater");
         

 