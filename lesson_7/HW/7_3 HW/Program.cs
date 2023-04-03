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

void ArithmeticMean(int[,] arr)
{
  int r = arr.GetLength(0);
  int c = arr.GetLength(1);

  double res;
  
  for (int i = 0; i < c; i++)
  {
    res = 0;
    for (int j = 0; j < r; j++) res += arr[j,i];
      Console.Write($"{Math.Round(res / r, 2)}; ");
  }
}

ArithmeticMean(mass);