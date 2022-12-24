//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write($"Введите элементы через пробел: ");
int [] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Transform(array);
int count = Transform(array);


int Transform(int [] array)
{
    int count = 0;
    for (int i= 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
    Console.WriteLine($"Количество элементов положительных (>0): {count} ");