void Print(double[,] arr)
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

double[,] MassNums(int row, int col, int from, int to)
{
  double[,] arr = new double[row, col];
  Random n_new = new Random();

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < col; j++)
    {
      arr[i, j] = Math.Round(n_new.NextDouble()*(to-from)+from, 2);
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

double[,] mass = MassNums(rows, columns, start, stop);
Console.WriteLine();
Print(mass);

