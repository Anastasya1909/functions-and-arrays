//Является ли день выходным?
Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("да");
  }

  else if (dayNumber < 1 || dayNumber > 7) 
  {
    Console.WriteLine("введите цифру от 1 до 7");
  }

  else Console.WriteLine("нет");
}

CheckingTheDayOfTheWeek(dayNumber);