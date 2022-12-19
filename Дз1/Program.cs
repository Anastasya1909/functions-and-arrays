// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 2.1. Метод, который -> Ввод числа
int GetNumberFromUser()
{
  Console.Write("Введите число от 100 до 999: ");
  int temp = int.Parse(Console.ReadLine());
  return temp;
}

// 2.2. Метод, который -> Проверка числа на валидность
bool IsValid(int number)
{
  return number >= 100 && number <= 999;  
}

// 2.3. Метод, который -> Отковырять 1 и 3 цифру
int GetNumber(int value)
{
  int a = value / 100; //563 563/100=5
  int b = (value / 10) % 10;  //563/10 53 ост 3
  int c = value % 10; //563/10 56 ост 6

  return a * 0 + b + c *0;
}

// 2.4. Метод, который -> Распечать результат
string GetText(int input, int output)
{
  return input + " -> " + output;
}

// 2.5. Метод для вывода

  int value = GetNumberFromUser();

  if (IsValid(value))
  {
    int result = GetNumber(value);
    System.Console.WriteLine(GetText(value, result));
  }
  else
  {
    System.Console.WriteLine("число кривое");
  }


