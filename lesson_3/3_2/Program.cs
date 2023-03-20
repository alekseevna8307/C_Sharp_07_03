Console.Write("Введите x1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите y1: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите x2: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите y2: ");
int y2 = int.Parse(Console.ReadLine()!);

double Coordinate(int x1, int y1, int x2, int y2)
{
  return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 3);
}

Console.Write(Coordinate(x1, y1, x2, y2));
