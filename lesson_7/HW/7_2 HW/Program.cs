void Print(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}

int[,] MassNums(int row, int col, int from, int to)
{
  int[,] arr = new int[row, col];

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < col; j++)
    {
      arr[i, j] = new Random().Next(from, to + 1);
    }
  }
  return arr;
}

Console.Write("Enter the number of rows: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int columns = int.Parse(Console.ReadLine()!);

Console.Write("Enter the min number of massive: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(rows, columns, start, stop);
Console.WriteLine();
Print(mass);

///////

Console.Write("Enter number -> ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter number -> ");
int num2 = int.Parse(Console.ReadLine()!);

string PositionNum(int[,] arr, int a, int b)
{
  if (a > arr.GetLength(0) || a <= 0 || b > arr.GetLength(1) || b <= 0)
    return $"{a}, {b} -> not found";
  return $"[{a}, {b}] = {arr[a - 1, b - 1]}";  
}

Console.WriteLine(PositionNum(mass, num1, num2));
