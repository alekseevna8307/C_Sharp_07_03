void Intersection(double b1, double k1, double b2, double k2)
{
  if (k1 - k2 != 0)
  {
  double x = (b2 - b1) / (k1 - k2);
  double y = k1 * x + b1;
  Console.Write($"({x};{y})");
  }
  
  else if (k1 == k2 && b1 == b2) 
  Console.Write("Прямые совпадают друг с другом");

  else 
  Console.Write("Прямые параллельные, не имеют точек пересечения");
}

Console.Write("Enter b1->");
double b1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter k1->");
double k1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter b2->");
double b2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter k2->");
double k2 = int.Parse(Console.ReadLine()!);

Intersection(b1, k1, b2, k2);