//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Write("Input b1: ");
double b1 = double.Parse(Console.ReadLine());
	
Console.Write("Input k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Input b2: ");
double b2 = double.Parse(Console.ReadLine());
	
Console.Write("Input k2: ");
double k2 = double.Parse(Console.ReadLine());

if(k1 == k2 && b1 == b2)
{
    System.Console.WriteLine($"lines coincide"); //прямые совпадают
}
if(k1 == k2)
{
    System.Console.WriteLine($"lines are parallel"); //прямые параллельны
}
else 
{
    double y = 0;
    double x = 0;
    x = (b2 - b1) / (k1 -k2);
    y = (k2 * x) + b2;
    System.Console.WriteLine($"intersection point A({x};{y})");
}  




///double b1= ReadInt("Input b1: ");
//double k1= ReadInt("Input k1: ");
//double b2= ReadInt("Input b2: ");
//double k2= ReadInt("Input k2: ");
////Intersection(b1, b2, k1, k2);

//double ReadInt(string argument)
//{
	//Console.Write($"Input {argument}: ");
	//return double.Parse(Console.ReadLine());
///}

//void Intersection(double b1, double k1, double b2, double k2)  //Пересечение
//{
    
    //if(k1 == k2 && b1 == b2)
    //{
    //    System.Console.WriteLine($"lines coincide"); //прямые совпадают
    //}
    //if(k1 == k2)
    //{
   //     System.Console.WriteLine($"lines are parallel"); //прямые параллельны
   // }
   //else 
   // {
       // double y = 0;
       // double x = 0;
       // x = (b2 - b1) / (k1 -k2);
      //  y = (k2 * x) + b2;
      //  System.Console.WriteLine($"intersection point A({x};{y})");
      //  }  
//}
